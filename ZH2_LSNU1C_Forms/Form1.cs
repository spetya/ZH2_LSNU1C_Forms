namespace ZH2_LSNU1C_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl1 userControl1 = new UserControl1();
            panel1.Controls.Add(userControl1);
            userControl1.Dock = DockStyle.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl2 userControl2 = new UserControl2();
            panel1.Controls.Add(userControl2);
            userControl2.Dock = DockStyle.Fill;
        }


        private static void CancelConfirmation(FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Biztos be szeretn�d z�rni?", "Bez�r�s", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            CancelConfirmation(e);
        }
    }
}