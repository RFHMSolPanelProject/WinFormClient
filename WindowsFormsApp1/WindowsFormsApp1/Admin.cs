﻿using MySql.Data.MySqlClient;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Admin : Form
    {
        private readonly string conn = @"datasource=127.0.0.1;port=3306;username=root;password=;database=napelem";
        private readonly string query = "INSERT INTO felhasznalok(Felhasznalonev, Jelszo, Beosztas) VALUES (@Felhasznalonev, @Jelszo, @Beosztas)";

        public Admin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (var con = new MySqlConnection(conn))
                {
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Felhasznalonev", textBox5.Text);
                        cmd.Parameters.AddWithValue("@Jelszo", HashPWD(textBox2.Text));
                        cmd.Parameters.AddWithValue("@Beosztas", comboBox1.SelectedIndex.ToString());

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba a beszúrás során: {ex}");
            }
        }

        private string HashPWD(string pwd)
        {
            using(var sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(pwd));
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
            Login l = new Login();
            l.Show();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void Check()
        {
            bool isHidden = textBox5.Text.Trim() != "" && textBox2.Text.Trim() != "" && comboBox1.SelectedItem != null;
            button2.Visible = isHidden;
        }
    }
}
