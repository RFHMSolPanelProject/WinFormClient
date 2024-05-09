using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class PartToProject : Form
    {
        MySqlConnection con = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=napelem");
        MySqlCommand command;
        MySqlDataAdapter adapter;

        public PartToProject()
        {
            InitializeComponent();
        }

        private void PartToProject_Load(object sender, EventArgs e)
        {
            // Itt helyezheted el az adatbázis kapcsolatot és az adatok lekérdezését
           
            con.Open();
            command = new MySqlCommand("SELECT ANev FROM alkatreszek", con);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string itemName = reader["ANev"].ToString();
                        PartComboBox.Items.Add(itemName);
                    }
                }
                else
                {
                    PartComboBox.Text = "Nincs találat az adatbázisban.";
                }
            }
            con.Close();
        }
        

        private void AddBtn_Click(object sender, EventArgs e)
        {         
            // Van e választott alkatrész a PartCombobox-ból
            if (PartComboBox.SelectedItem != null && !string.IsNullOrWhiteSpace(StockField.Text))
            {
                // Kiválasztott alkatrész neve
                string selectedPart = PartComboBox.SelectedItem.ToString();
                string projectIDInput = ProjectIDField.Text;
                

                // Megadott darabszám
                int quantity;
                if (!int.TryParse(StockField.Text, out quantity))
                {
                    MessageBox.Show("Kérlek adj meg egy érvényes darabszámot!");
                    return;
                }

                // Van-e elegendő raktárkészlet
                int currentStock;
                con.Open();
                    command = new MySqlCommand("SELECT Darab FROM alkatreszek WHERE ANev = @ANev", con);
                    command.Parameters.AddWithValue("@ANev", selectedPart);
                    currentStock = Convert.ToInt32(command.ExecuteScalar());
                con.Close() ;
                // Ha van elegendő raktárkészlet, frissítjük a projektraktárban az alkatrész mennyiségét
                if (currentStock >= quantity)
                {

                    con.Open();                      
                        command = new MySqlCommand("INSERT INTO projektraktar(ProjektKod, ANev, SzDarab) VALUES(@ProjectID, @ANev, @SZDarab)", con);                       
                        command.Parameters.AddWithValue("@ProjectID", projectIDInput);
                        command.Parameters.AddWithValue("@ANev", selectedPart);
                        command.Parameters.AddWithValue("@SZDarab", quantity);        
                        command.ExecuteNonQuery();       
                    con.Close();
                    //Javítási lehetőség feltétellel megnézi van-e már ilyen alkatrész adott projekt kódon a COUNT-tal és ott lehet neki if-et adni INSERT-re vagy UPDATE-re hogy ne akadjon ki ha esetleg ismételt hozzáadás történik a projektraktárhoz ugyanabból az alkatrészből
                 
                    
                    // Levonjuk az alkatrész kiválasztott mennyiségét az adatbázisból
                    con.Open();                  
                        command = new MySqlCommand("UPDATE alkatreszek SET Darab = Darab - @quantity WHERE ANev = @ANev", con);            
                        command.Parameters.AddWithValue("@quantity", quantity);
                        command.Parameters.AddWithValue("@ANev", selectedPart);
                        command.ExecuteNonQuery();                                            
                    con.Close();

                    con.Open();
                    command = new MySqlCommand("UPDATE projekt SET Statusz = 'Draft' WHERE ProjektKod = @ProjectID", con);
                    command.Parameters.AddWithValue("@ProjectID", projectIDInput);
                    command.Parameters.AddWithValue("@quantity", quantity);
                    command.Parameters.AddWithValue("@ANev", selectedPart);
                    command.ExecuteNonQuery();
                    con.Close();


                    MessageBox.Show("A projektraktárba áthelyezés megtörtént.");
                    // Hozzáadjuk az információkat a PartListBox-hoz
                    PartsListBox.Items.Add($"{selectedPart}: {quantity} darab");
                }
                else
                {
                    // Ha nincs elegendő raktárkészlet, küldünk egy üzenetet az InfoLog TextBox-ba
                    InfoLogTextbox.AppendText($"Nincs elegendő készlet: {currentStock} darab van a raktárban.");
                }
                
            }
            else
            {
                MessageBox.Show("Kérlek válassz ki egy alkatrészt és adj meg egy darabszámot!");
            }
        }



        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void stockField_TextChanged(object sender, EventArgs e)
        {

        }

        private void InfoLogTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProjectIDField_TextChanged(object sender, EventArgs e)
        {

        }

        private void PartsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


/* Javítási lehetőség
 try
        {
            // Ellenőrizzük, hogy létezik-e már ilyen rekord
            command = new MySqlCommand("SELECT COUNT(*) FROM projektraktar WHERE ProjektKod = @ProjectID AND ANev = @ANev", con);
            command.Parameters.AddWithValue("@ProjectID", projectIDInput);
            command.Parameters.AddWithValue("@ANev", selectedPart);
            int count = Convert.ToInt32(command.ExecuteScalar());

            if (count > 0)
            {
                // Frissítjük a darabszámot
                command = new MySqlCommand("UPDATE projektraktar SET SzDarab = SzDarab + @Quantity WHERE ProjektKod = @ProjectID AND ANev = @ANev", con, tran);
                command.Parameters.AddWithValue("@Quantity", quantity);
            }
            else
            {
                // Beszúrjuk az új rekordot
                command = new MySqlCommand("INSERT INTO projektraktar (ProjektKod, ANev, SzDarab) VALUES (@ProjectID, @ANev, @Quantity)", con, tran);
                command.Parameters.AddWithValue("@Quantity", quantity);
            }

            command.Parameters.AddWithValue("@ProjectID", projectIDInput);
            command.Parameters.AddWithValue("@ANev", selectedPart);
            command.ExecuteNonQuery();

 */