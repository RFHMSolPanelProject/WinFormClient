using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Data;
using System.Drawing;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ProjectList : Form
    {
        MySqlConnection con = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=napelem");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable table;
        string conn = @"datasource=127.0.0.1;port=3306;username=root;password=;database=napelem";
        string query = "SELECT * FROM Projekt";     //Projektek volt
        string seged;

        public ProjectList()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            projectListGrid.AutoGenerateColumns = false;
            projectListGrid.Columns[0].Name = "ProjektKod";
            projectListGrid.Columns[0].HeaderText = "ProjektKod";
            projectListGrid.Columns[0].DataPropertyName = "ProjektKod";
            projectListGrid.Columns[1].Name = "Helyszin";
            projectListGrid.Columns[1].HeaderText = "Helyszin";
            projectListGrid.Columns[1].DataPropertyName = "Helyszin";
            projectListGrid.Columns[2].Name = "Leiras";
            projectListGrid.Columns[2].HeaderText = "Leiras";
            projectListGrid.Columns[2].DataPropertyName = "Leiras";
            projectListGrid.Columns[3].Name = "Statusz";
            projectListGrid.Columns[3].HeaderText = "Statusz";
            projectListGrid.Columns[3].DataPropertyName = "Statusz";
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    // Az adatbázis kapcsolat nyitva van
                    // Ide írd a teendőket, amelyeket a kapcsolat nyitva lévő állapotban szeretnél végrehajtani
                }
                else
                {
                    con.Open();
                    // Az adatbázis kapcsolat zárva van
                    // Ide írd a teendőket, amelyeket a kapcsolat zárva lévő állapotban szeretnél végrehajtani
                }
                cmd = new MySqlCommand("SELECT * FROM Projekt", con);
                adapter = new MySqlDataAdapter(cmd);
                table = new DataTable();
                adapter.Fill(table);
                projectListGrid.DataSource = table;
                projectListGrid.Refresh();
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

        private void button1_Click(object sender, System.EventArgs e) => projectListGrid.DataSource = GetProjects();

        private DataTable GetProjects()
        {
            DataTable dtProj = new DataTable();

            using (var con = new MySqlConnection(conn))
            {
                using (var cmd = new MySqlCommand(query, con))
                {
                    con.Open();
                    var dr = cmd.ExecuteReader();
                    dtProj.Load(dr);
                    LoadData();


                }
                con.Close();
            }

            return dtProj;
        }

        private void projectListGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void IsDraftSelected(DataGridView dataGridView)
        {
            // Ellenőrizzük, hogy van-e kiválasztott sor
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Ellenőrizzük a kiválasztott sor negyedik oszlopát
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
                string fourthColumnValue = selectedRow.Cells[3].Value.ToString();

                // Ellenőrizzük, hogy a negyedik oszlop értéke "draft" szöveggel egyezik-e
                if (fourthColumnValue.Equals("draft", StringComparison.OrdinalIgnoreCase))
                {
                    seged = selectedRow.Cells[0].Value.ToString();
                    try
                    {
                        con.Open();
                        cmd = new MySqlCommand("UPDATE Projekt SET statusz = 'InProgress' WHERE Projektkod = @Projektkod", con);
                        cmd.Parameters.AddWithValue("@Projektkod", seged);
                        cmd.ExecuteNonQuery();
                        // Frissítjük az adatokat a DataGridView-ban
                        LoadData();

                        MessageBox.Show("A státusz sikeresen módosítva lett, megkezdődhet a munka.");
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
                else
                {

                }
            }
            else
            {
                MessageBox.Show("Válassz ki egy sort!");
            };
        }
        private void button2_Click(object sender, EventArgs e)
        {
            IsDraftSelected(projectListGrid);
        }
    }
}
