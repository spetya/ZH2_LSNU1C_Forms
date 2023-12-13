namespace ZH2_LSNU1C_Forms
{
    partial class UserControl1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxStudent = new TextBox();
            textBoxSubject = new TextBox();
            listBoxStudent = new ListBox();
            listBoxSubject = new ListBox();
            dataGridView1 = new DataGridView();
            buttonAddNewSub = new Button();
            buttonAdd = new Button();
            buttonDel = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBoxStudent
            // 
            textBoxStudent.Location = new Point(28, 23);
            textBoxStudent.Name = "textBoxStudent";
            textBoxStudent.Size = new Size(156, 23);
            textBoxStudent.TabIndex = 0;
            textBoxStudent.TextChanged += textBoxStudent_TextChanged;
            // 
            // textBoxSubject
            // 
            textBoxSubject.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxSubject.Location = new Point(821, 24);
            textBoxSubject.Name = "textBoxSubject";
            textBoxSubject.Size = new Size(188, 23);
            textBoxSubject.TabIndex = 1;
            textBoxSubject.TextChanged += textBoxSubject_TextChanged;
            // 
            // listBoxStudent
            // 
            listBoxStudent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listBoxStudent.FormattingEnabled = true;
            listBoxStudent.ItemHeight = 15;
            listBoxStudent.Location = new Point(28, 72);
            listBoxStudent.Name = "listBoxStudent";
            listBoxStudent.Size = new Size(156, 439);
            listBoxStudent.TabIndex = 2;
            listBoxStudent.SelectedIndexChanged += listBoxStudent_SelectedIndexChanged;
            // 
            // listBoxSubject
            // 
            listBoxSubject.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            listBoxSubject.FormattingEnabled = true;
            listBoxSubject.ItemHeight = 15;
            listBoxSubject.Location = new Point(821, 72);
            listBoxSubject.Name = "listBoxSubject";
            listBoxSubject.Size = new Size(188, 439);
            listBoxSubject.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(204, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(611, 451);
            dataGridView1.TabIndex = 4;
            // 
            // buttonAddNewSub
            // 
            buttonAddNewSub.Anchor = AnchorStyles.Top;
            buttonAddNewSub.Location = new Point(246, 23);
            buttonAddNewSub.Name = "buttonAddNewSub";
            buttonAddNewSub.Size = new Size(188, 23);
            buttonAddNewSub.TabIndex = 5;
            buttonAddNewSub.Text = "Új tantárgy hozzáadása";
            buttonAddNewSub.UseVisualStyleBackColor = true;
            buttonAddNewSub.Click += buttonAddNewSub_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.Top;
            buttonAdd.Location = new Point(616, 14);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(188, 52);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Kiválasztott tantárgy felvétele tanulóhoz";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDel
            // 
            buttonDel.Anchor = AnchorStyles.Top;
            buttonDel.Location = new Point(440, 23);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(170, 23);
            buttonDel.TabIndex = 7;
            buttonDel.Text = "Tantárgy törlése";
            buttonDel.UseVisualStyleBackColor = true;
            buttonDel.Click += buttonDel_Click;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            Controls.Add(buttonDel);
            Controls.Add(buttonAdd);
            Controls.Add(buttonAddNewSub);
            Controls.Add(dataGridView1);
            Controls.Add(listBoxSubject);
            Controls.Add(listBoxStudent);
            Controls.Add(textBoxSubject);
            Controls.Add(textBoxStudent);
            Name = "UserControl1";
            Size = new Size(1019, 627);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxStudent;
        private TextBox textBoxSubject;
        private ListBox listBoxStudent;
        private ListBox listBoxSubject;
        private DataGridView dataGridView1;
        private Button buttonAddNewSub;
        private Button buttonAdd;
        private Button buttonDel;
    }
}
