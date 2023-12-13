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
    public partial class UserControl2 : UserControl
    {
        StudentContext context = new StudentContext();
        public UserControl2()
        {
            InitializeComponent();
            listBoxTeachers.DisplayMember = "email";
            GetTeachers();
        }

        private void GetTeachers()
        {
            listBoxTeachers.DataSource = (from x in context.Teachers
                                          select x).ToList();
        }

        private void listBoxTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = ((Teachers)listBoxTeachers.SelectedItem).TeacherId;
            var assignedsub = from x in context.AssignedSubjects
                              where x.TeacherId == id
                              select new NewSubject
                              {
                                  Id = x.SubjectId,
                                  Name = x.Subject.SubjectName,
                                  Code = x.Subject.SubjectCode,
                                  Semester = x.Subject.Semester,
                              };
            newSubjectBindingSource.DataSource = assignedsub.ToList();
        }
    }
}
