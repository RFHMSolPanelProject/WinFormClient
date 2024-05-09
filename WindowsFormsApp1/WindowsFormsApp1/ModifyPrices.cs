using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class ModifyPrices : Form
    {
        private readonly MySqlConnection con;
        private readonly MySqlCommand cmd;
        public ModifyPrices()
        {
            con = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=napelem");
<<<<<<< Updated upstream
            cmd = new MySqlCommand("INSERT INTO Alkatreszek(ANev, Maxdb, Darab, Ar) VALUES (@ANev, @Maxdb, @Darab, @Ar)", con);
=======
            //cmd = new MySqlCommand("INSERT INTO Alkatreszek(ANev, Maxdb, Darab, Ar) VALUES (@ANev, @Maxdb, @Darab, @Ar)", con);
            cmd = new MySqlCommand("UPDATE Alkatreszek SET Ar = @Ar WHERE ANev = @ANev", con);
>>>>>>> Stashed changes
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)      // Hozzáad
        {        
            cmd.Parameters.AddWithValue("@ANev", textBox2.Text);    // Anev
            cmd.Parameters.AddWithValue("@Maxdb", textBox3.Text);   // Maxdb
            cmd.Parameters.AddWithValue("@Darab", textBox5.Text);   // Db
            cmd.Parameters.AddWithValue("@Ar", textBox7.Text);      // Ár

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e) => Close(); // Mégse
    }
}
