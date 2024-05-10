using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddProject : Form
    {
        public AddProject()
        {
            InitializeComponent();
            HideExecButton();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conn = @"datasource=127.0.0.1;port=3306;username=root;password=;database=napelem";
            string query = "INSERT INTO Projekt(ProjektKod, Helyszin, Leiras, Statusz) VALUES (@ProjektKod, @Helyszin, @Leiras, @Statusz)";

            using (var con = new MySqlConnection(conn))
            {
                using(var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ProjektKod", textBox6.Text);
                    cmd.Parameters.AddWithValue("@Helyszin", textBox7.Text);
                    cmd.Parameters.AddWithValue("@Leiras", textBox5.Text);
                    cmd.Parameters.AddWithValue("@Statusz", "InProgress");

                    con.Open();
                    try
                    {
                        int i = cmd.ExecuteNonQuery();
                        if (i != 0)
                        {
                            DialogResult = DialogResult.OK;
                        }
                    }
                    catch
                    {
                        MessageBox.Show($"{textBox6.Text} néven már létre van hozva egy projekt!");
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
        }

        private void HideExecButton()
        {
            button1.Visible = false;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void Check()
        {
            bool allFilled = textBox6.Text.Trim() != "" && textBox7.Text.Trim() != "" && textBox5.Text.Trim() != "";
            button1.Visible = allFilled;
        }
    }
}
