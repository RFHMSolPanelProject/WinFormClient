using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Hiany : Form
    {
        public Hiany()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) => missing_datagrid.DataSource = GetMissingList();

        // B.3
        private DataTable GetMissingList()
        {
            DataTable dtMissing = new DataTable();

            string conn = @"datasource=127.0.0.1;port=3306;username=root;password=;database=napelem";
            string query = "Select * from hianyzoalkatreszek where hiany_statusz like 'hiányzik'";

            using (var con = new MySqlConnection(conn))
            {
                using (var cmd = new MySqlCommand(query, con))
                {
                    con.Open();
                    var dr = cmd.ExecuteReader();
                    dtMissing.Load(dr);
                }
            }

            return dtMissing;
        }

        private void button2_Click(object sender, EventArgs e) => missing_datagrid.DataSource = GetOccupiedList();

        // B.4
        private DataTable GetOccupiedList()
        {
            DataTable dtOcc = new DataTable();

            string conn = @"datasource=127.0.0.1;port=3306;username=root;password=;database=napelem";
            string query = "Select * from hianyzoalkatreszek where hiany_statusz like 'lefoglalva';";

            using (var con = new MySqlConnection(conn))
            {
                using (var cmd = new MySqlCommand(query, con))
                {
                    con.Open();
                    var dr = cmd.ExecuteReader();
                    dtOcc.Load(dr);
                }
            }

            return dtOcc;
        }
    }
}
