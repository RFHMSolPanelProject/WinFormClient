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

        private void button1_Click(object sender, EventArgs e) => GetMissingList();

        // B.3
        private void GetMissingList()
        {
            string conn = @"datasource=127.0.0.1;port=3306;username=root;password=;database=napelem";
            var con = new MySqlConnection(conn);
            try
            {
                con.Open();
                string query = "Select hiany_nev as 'Terméknév', hiany_db as 'Darabszám', hiany_ar as 'Ár', hiany_statusz as 'Státusz' from hianyzoalkatreszek where hiany_statusz like 'hiányzik'";            
                var cmd = new MySqlCommand(query, con);
                var apt = new MySqlDataAdapter(cmd);
                DataTable dtMissing = new DataTable();

                apt.Fill(dtMissing);

                miss_occ_datagrid.DataSource = dtMissing;

                miss_occ_datagrid.Columns["Terméknév"].HeaderText = "Terméknév";
                miss_occ_datagrid.Columns["Darabszám"].HeaderText = "Darabszám";
                miss_occ_datagrid.Columns["Ár"].HeaderText = "Ár";
                miss_occ_datagrid.Columns["Státusz"].HeaderText = "Státusz";
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Hiba történt az adatok lekérdezése során: {ex}!");
            }
            finally
            {
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e) => GetOccupiedList();

        // B.4
        private void GetOccupiedList()
        {
            string conn = @"datasource=127.0.0.1;port=3306;username=root;password=;database=napelem";
            var con = new MySqlConnection(conn);
            try
            {
                con.Open();
                string query = "Select hiany_nev as 'Terméknév', hiany_db as 'Darabszám', hiany_ar as 'Ár', hiany_statusz as 'Státusz' from hianyzoalkatreszek where hiany_statusz like 'lefoglalva'";
                var cmd = new MySqlCommand(query, con);
                var apt = new MySqlDataAdapter(cmd);
                DataTable dtMissing = new DataTable();

                apt.Fill(dtMissing);

                miss_occ_datagrid.DataSource = dtMissing;

                miss_occ_datagrid.Columns["Terméknév"].HeaderText = "Terméknév";
                miss_occ_datagrid.Columns["Darabszám"].HeaderText = "Darabszám";
                miss_occ_datagrid.Columns["Ár"].HeaderText = "Ár";
                miss_occ_datagrid.Columns["Státusz"].HeaderText = "Státusz";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba történt az adatok lekérdezése során: {ex}!");
            }
            finally
            {
                con.Close();
            }
        }
    }
}
