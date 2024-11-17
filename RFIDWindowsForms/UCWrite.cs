using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFIDWindowsForms
{
    public partial class UCWrite : UserControl
    {
       
        public UCWrite()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=C:\Users\ВикторАДиндев\source\repos\RFIDWindowsForms\xsqlite.db;Version=3;";
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                SQLiteCommand cmd = new SQLiteCommand(connection);
                cmd.CommandText = $@"SELECT * FROM employes WHERE rfid={txt_rfid_write.Text}";
                
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                
                if (count == 0)
                {
                    cmd.CommandText = $@"INSERT INTO employes (rfid, name, sirName)
                        VALUES ($rfid, $name, $sirName)";
                    
                    cmd.Parameters.AddWithValue("$rfid", txt_rfid_write.Text);
                    cmd.Parameters.AddWithValue("$name", txt_name_write.Text);
                    cmd.Parameters.AddWithValue("$sirName", txt_sirName_write.Text);

                    cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("The CHIP is already inserted!!!");
                }
/*                string addEmployesToTableQuery = @"
                        INSERT INTO employes
                        VALUES ($rfid, $name ,$sirName)
                        ";

                using (var command = new SQLiteCommand(connection))
                {
                    command.CommandText = addEmployesToTableQuery;
                    command.Parameters.AddWithValue("$rfid", UCWrite.)
                        command.ExecuteNonQuery();
                }
*/
            }
        }
    }
}
