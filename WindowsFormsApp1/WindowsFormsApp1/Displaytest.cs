using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Displaytest : Form
    {
        private readonly MySqlConnection con = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=napelem");
        private MySqlCommand cmd;
        private MySqlDataAdapter adapter;
        private DataTable table;


        public Displaytest()
        {
            InitializeComponent();
        }
        private void Displaytest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'napelemDataSet.Components' table. You can move, or remove it, as needed.

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // DataGridView oszlopok beállítása
            datagrid.AutoGenerateColumns = false;
            datagrid.ColumnCount = 4;
            datagrid.Columns[0].Name = "ANev";
            datagrid.Columns[0].HeaderText = "Név";
            datagrid.Columns[0].DataPropertyName = "ANev";
            datagrid.Columns[1].Name = "Maxdb";
            datagrid.Columns[1].HeaderText = "Maxdb";
            datagrid.Columns[1].DataPropertyName = "Maxdb";
            datagrid.Columns[2].Name = "Darab";
            datagrid.Columns[2].HeaderText = "Darab";
            datagrid.Columns[2].DataPropertyName = "Darab";
            datagrid.Columns[3].Name = "Ar";
            datagrid.Columns[3].HeaderText = "Ár";
            datagrid.Columns[3].DataPropertyName = "Ar";

            // Adatok betöltése DataGridView-be
            LoadData();
        }


        private void button2_Click(object sender, EventArgs e)      //Listáz
        => LoadData();

        private void LoadData()
        {
            datagrid.AutoGenerateColumns = false;
            datagrid.Columns[0].Name = "ANev";
            datagrid.Columns[0].HeaderText = "Név";
            datagrid.Columns[0].DataPropertyName = "ANev";
            datagrid.Columns[1].Name = "Maxdb";
            datagrid.Columns[1].HeaderText = "Maxdb";
            datagrid.Columns[1].DataPropertyName = "Maxdb";
            datagrid.Columns[2].Name = "Darab";
            datagrid.Columns[2].HeaderText = "Darab";
            datagrid.Columns[2].DataPropertyName = "Darab";
            datagrid.Columns[3].Name = "Ar";
            datagrid.Columns[3].HeaderText = "Ár";
            datagrid.Columns[3].DataPropertyName = "Ar";
            try
            {
                con.Open();
                cmd = new MySqlCommand("SELECT * FROM Alkatreszek", con);
                adapter = new MySqlDataAdapter(cmd);
                table = new DataTable();
                adapter.Fill(table);
                datagrid.DataSource = table;
                datagrid.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt az adatok betöltése közben: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)      //Hozzáad
        => runQuery();
        private void runQuery()
        {
           //MySqlConnection con = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=napelem");
            MySqlCommand cmd = new MySqlCommand("INSERT INTO Alkatreszek(ANev, Maxdb, Darab, Ar) VALUES (@ANev, @Maxdb, @Darab, @Ar)", con);

            cmd.Parameters.AddWithValue("@ANev", textBox2.Text);    //Anev
            cmd.Parameters.AddWithValue("@Maxdb", textBox3.Text);   //Maxdb
            cmd.Parameters.AddWithValue("@Darab", textBox5.Text);   //Db
            cmd.Parameters.AddWithValue("@Ar", textBox7.Text);      //Ár

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            /* MySqlConnection con = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=napelem");
             MySqlCommand cmd = new MySqlCommand("INSERT INTO Alkatreszek(ANev, Maxdb,Darab, Ar) VALUES", con);
             cmd.CommandType = CommandType.StoredProcedure;
             cmd.Parameters.AddWithValue("@ANev", textBox2.Text);        //Anev
             cmd.Parameters.AddWithValue("@Maxdb", textBox3.Text);       //Maxdb
             cmd.Parameters.AddWithValue("@Darab", textBox5.Text);       //Db
             cmd.Parameters.AddWithValue("@Ar", textBox7.Text);     //Ár
             try
             {

                 con.Open();
                 int i = cmd.ExecuteNonQuery();

                 con.Close();

                 if (i != 0)
                 {
                     MessageBox.Show(i + "Data Saved");
                 }
             }
             catch (Exception e)
             {

                 MessageBox.Show("Query error:" + e.Message);
             }*/

            /*string query = textBox2.Text;
            if (query == "")
            {
                MessageBox.Show("Kerlek adj meg adatot!"); return;
            }
            string MYSQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=napelem";
            MySqlConnection databaseConnection = new MySqlConnection(MYSQLConnectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 30;
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                if (myReader.HasRows)
                {
                    MessageBox.Show("Beiras folyamatban");
                    while (myReader.Read())         //ANev                  //Maxdb                             //DB                      //Ár
                    {
                        Console.WriteLine(myReader.GetString(0) + "-" + myReader.GetString(1) + "-" + myReader.GetString(2) + "-" + myReader.GetString(3)); }
                }
                else
                {
                    MessageBox.Show("Sikeres beiras");
                }
            }
            catch (Exception e)
            {

                MessageBox.Show("Query error:" + e.Message);
            }*/
        }
    }
}

