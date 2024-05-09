using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ProjectList : Form
    {
        string conn = @"datasource=127.0.0.1;port=3306;username=root;password=;database=napelem";
        string query = "SELECT * FROM Projekt";

        public ProjectList()
        {
            InitializeComponent();
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
                }
            }

            return dtProj;
        }
    }
}
