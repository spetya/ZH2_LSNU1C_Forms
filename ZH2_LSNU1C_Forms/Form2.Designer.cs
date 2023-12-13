namespace ZH2_LSNU1C_Forms
{
    partial class Form2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            textBoxID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxKod = new TextBox();
            label3 = new Label();
            textBoxName = new TextBox();
            textBoxDesc = new TextBox();
            label4 = new Label();
            numericUpDown1 = new NumericUpDown();
            label5 = new Label();
            buttonOK = new Button();
            buttonCancel = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(74, 31);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(179, 23);
            textBoxID.TabIndex = 0;
            textBoxID.Validating += textBoxID_Validating;
            textBoxID.Validated += textBoxID_Validated;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 34);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 1;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 74);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 2;
            label2.Text = "Kód:";
            // 
            // textBoxKod
            // 
            textBoxKod.Location = new Point(74, 71);
            textBoxKod.Name = "textBoxKod";
            textBoxKod.Size = new Size(179, 23);
            textBoxKod.TabIndex = 3;
            textBoxKod.Validating += textBoxKod_Validating;
            textBoxKod.Validated += textBoxKod_Validated;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 113);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 4;
            label3.Text = "Név:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(74, 110);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(179, 23);
            textBoxName.TabIndex = 5;
            textBoxName.Validating += textBoxName_Validating;
            textBoxName.Validated += textBoxName_Validated;
            // 
            // textBoxDesc
            // 
            textBoxDesc.Location = new Point(74, 152);
            textBoxDesc.Name = "textBoxDesc";
            textBoxDesc.Size = new Size(179, 23);
            textBoxDesc.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 155);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 7;
            label4.Text = "Leírás";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(74, 195);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(179, 23);
            numericUpDown1.TabIndex = 8;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 197);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 9;
            label5.Text = "Szemeszter";
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(30, 274);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(75, 23);
            buttonOK.TabIndex = 10;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.CausesValidation = false;
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(249, 274);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 337);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOK);
            Controls.Add(label5);
            Controls.Add(numericUpDown1);
            Controls.Add(label4);
            Controls.Add(textBoxDesc);
            Controls.Add(textBoxName);
            Controls.Add(label3);
            Controls.Add(textBoxKod);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxID);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox textBoxID;
        private Label label1;
        private Label label2;
        public TextBox textBoxKod;
        private Label label3;
        public TextBox textBoxName;
        public TextBox textBoxDesc;
        private Label label4;
        public NumericUpDown numericUpDown1;
        private Label label5;
        private Button buttonOK;
        private Button buttonCancel;
        private ErrorProvider errorProvider1;
    }
}