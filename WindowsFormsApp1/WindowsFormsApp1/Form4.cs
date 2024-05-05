using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        MySqlConnection con = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=napelem");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable table;

        public Form4()
        {
            InitializeComponent();
        }
        private void Forms4_Load(object sender, EventArgs e)
        {
            

        }
       
        private void Form4_Load(object sender, EventArgs e)
        {
            datagrid.AutoGenerateColumns = false;
            datagrid.Columns[0].Name = "ProjektNev";
            datagrid.Columns[0].HeaderText = "ProjektNev";
            datagrid.Columns[0].DataPropertyName = "ProjektNev";
            datagrid.Columns[1].Name = "Munkavegzes";
            datagrid.Columns[1].HeaderText = "Munkavegzes";
            datagrid.Columns[1].DataPropertyName = "Munkavegzes";
            datagrid.Columns[2].Name = "Munkadij";
            datagrid.Columns[2].HeaderText = "Munkadij";
            datagrid.Columns[2].DataPropertyName = "Munkadij";
        

            // Adatok betöltése DataGridView-be
            LoadData();
        }
        private void button2_Click(object sender, EventArgs e) => LoadData();
        private void LoadData()
        {
            datagrid.AutoGenerateColumns = false;
            datagrid.Columns[0].Name = "ProjektNev";
            datagrid.Columns[0].HeaderText = "ProjektNev";
            datagrid.Columns[0].DataPropertyName = "ProjektNev";
            datagrid.Columns[1].Name = "Munkavegzes";
            datagrid.Columns[1].HeaderText = "Munkavegzes";
            datagrid.Columns[1].DataPropertyName = "Munkavegzes";
            datagrid.Columns[2].Name = "Munkadij";
            datagrid.Columns[2].HeaderText = "Munkadij";
            datagrid.Columns[2].DataPropertyName = "Munkadij";
           
            try
            {
                con.Open();
                cmd = new MySqlCommand("SELECT * FROM Munkavegzes", con);
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) => RunQuery();
        private void RunQuery()
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO Munkavegzes(ProjektNev,Munkavegzes,Munkadij) VALUES (@ProjektNev,@Munkavegzes, @Munkadij)", con);

            cmd.Parameters.AddWithValue("@ProjektNev", textBox2.Text);
            cmd.Parameters.AddWithValue("@Munkavegzes", textBox3.Text);
            cmd.Parameters.AddWithValue("@Munkadij", textBox5.Text);



            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

      
    }
}
