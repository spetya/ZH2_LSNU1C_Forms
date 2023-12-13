using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZH2_LSNU1C_Forms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void textBoxID_Validating(object sender, CancelEventArgs e)
        {
            Regex regexid = new Regex("^[0-9]{4}$");
            if (!regexid.IsMatch(textBoxID.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxID, "Adjon meg egy négyjegyű számot!");
            }
        }

        private void textBoxID_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxID, string.Empty);
        }

        private void textBoxKod_Validating(object sender, CancelEventArgs e)
        {
            Regex regexid = new Regex("^[A-Z]{6}$");
            if (!regexid.IsMatch(textBoxKod.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxKod, "Adjon meg 6 nagybetűt!");
            }
        }

        private void textBoxKod_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxKod, string.Empty);
        }

        private void textBoxName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxName, "A mező nem lehet üres!");
            }
        }

        private void textBoxName_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxName, string.Empty);
        }
    }
}
