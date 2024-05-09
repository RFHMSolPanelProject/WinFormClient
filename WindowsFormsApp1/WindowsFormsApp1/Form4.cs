using System;
using System.Data;
using System.Linq;
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
            /*
            datagrid.AutoGenerateColumns = false;
            datagrid.Columns[0].Name = "ProjectID";
            datagrid.Columns[0].HeaderText = "ProjectID";
            datagrid.Columns[0].DataPropertyName = "ProjectID";

            datagrid.Columns[1].Name = "Munkavegzes";
            datagrid.Columns[1].HeaderText = "Munkavegzes";
            datagrid.Columns[1].DataPropertyName = "Munkavegzes";

            datagrid.Columns[2].Name = "Munkadij";
            datagrid.Columns[2].HeaderText = "Munkadij";
            datagrid.Columns[2].DataPropertyName = "Munkadij";
            */
           

            // Adatok betöltése DataGridView-be
           // LoadData();
        }
        private void ListPriceAndTime_Click(object sender, EventArgs e) => LoadData();
        private void LoadData()
        {
            datagrid.AutoGenerateColumns = false;
            datagrid.Columns[0].Name = "ProjectID";
            datagrid.Columns[0].HeaderText = "ProjectID";
            datagrid.Columns[0].DataPropertyName = "ProjectID";

            datagrid.Columns[1].Name = "Munkaora";
            datagrid.Columns[1].HeaderText = "Munkaóra";
            datagrid.Columns[1].DataPropertyName = "Munkaora";

            datagrid.Columns[2].Name = "Munkadij";
            datagrid.Columns[2].HeaderText = "Munkadíj";
            datagrid.Columns[2].DataPropertyName = "Munkadij";

            datagrid.Columns[3].Name = "Arkalkulacio";
            datagrid.Columns[3].HeaderText = "Arkalkulacio";
            datagrid.Columns[3].DataPropertyName = "Arkalkulacio";


            try
            {
                con.Open();
                cmd = new MySqlCommand("SELECT ProjectID, Munkaora, Munkadij, Munkaora * Munkadij AS Arkalkulacio FROM Arkalkulacio", con);
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

        private void WorkTimeField_TextChanged(object sender, EventArgs e)
        {

        }

        private void WorkPriceField_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProjectIDField_TextChanged(object sender, EventArgs e)
        {

        }

      
    }
}
