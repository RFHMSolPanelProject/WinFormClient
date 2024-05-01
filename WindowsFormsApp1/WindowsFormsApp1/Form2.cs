using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProjectList pl = new ProjectList();
            pl.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
            Login l = new Login();
            l.Show();
        }
    }
}
