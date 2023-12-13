using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZH2_LSNU1C_Forms.Models;

namespace ZH2_LSNU1C_Forms
{
    public partial class UserControl1 : UserControl
    {
        StudentContext context = new StudentContext();
        public UserControl1()
        {
            InitializeComponent();
            listBoxStudent.DisplayMember = "email";
            listBoxSubject.DisplayMember = "subjectname";
            GetStudents();
            GetSubjects();
            GetSelectedSubs();
        }

        private void GetSelectedSubs()
        {
            var id = ((Students)listBoxStudent.SelectedItem).StudentId;
            var enrollments = from x in context.Enrollments
                              where x.StudentId == id
                              select new NewSubject
                              {
                                  Id = x.SubjectId,
                                  Name = x.Subject.SubjectName,
                                  Code = x.Subject.SubjectCode,
                                  Semester = x.Subject.Semester,
                              };
            dataGridView1.DataSource = enrollments.ToList();
        }

        private void GetSubjects()
        {
            listBoxSubject.DataSource = (from x in context.Subjects
                                         where x.SubjectName.Contains(textBoxSubject.Text)
                                         select x).ToList();
        }

        private void GetStudents()
        {
            listBoxStudent.DataSource = (from x in context.Students
                                         where x.Email.Contains(textBoxStudent.Text)
                                         select x).ToList();
        }

        private void textBoxStudent_TextChanged(object sender, EventArgs e)
        {
            GetStudents();
        }

        private void textBoxSubject_TextChanged(object sender, EventArgs e)
        {
            GetSubjects();
        }

        private void listBoxStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetSelectedSubs();
        }

        private void buttonAddNewSub_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                Models.Subjects subject = new Models.Subjects();
                subject.SubjectId = int.Parse(form2.textBoxID.Text);
                subject.SubjectName = form2.textBoxName.Text;
                subject.SubjectDescription = form2.textBoxDesc.Text;
                subject.SubjectCode = form2.textBoxKod.Text;
                subject.Semester = (int)form2.numericUpDown1.Value;
                try
                {
                    context.Add(subject);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                GetSubjects();
            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Students student = (Students)listBoxStudent.SelectedItem;
            Subjects subject = (Subjects)listBoxSubject.SelectedItem;

            Enrollments ed = new Enrollments();
            ed.EnrollmentDate = DateTime.Now;
            ed.StudentId = student.StudentId;
            ed.SubjectId = subject.SubjectId;
            context.Enrollments.Add(ed);
            try
            {
                context.SaveChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            GetSelectedSubs();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            listBoxSubject.ValueMember = "SubjectId";

            int sID = Convert.ToInt32(listBoxSubject.SelectedValue);
            var sd = from x in context.Subjects
                     where x.SubjectId == sID
                     select x;
            context.Subjects.Remove(sd.FirstOrDefault());

            var confirm = MessageBox.Show("Biztos törölni akarod?", "Törlés", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    context.SaveChanges();
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show("Nem lehet törölni olyan tárgyat, amit felvett valaki");
                    foreach (var entry in ex.Entries)
                    {
                        entry.State = EntityState.Detached;
                    }
                }
            }
            else
            {
                return;
            }
            GetSubjects();
        }
    }
}