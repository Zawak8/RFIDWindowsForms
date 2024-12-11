using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFIDWindowsForms
{
    public partial class UCWrite : UserControl
    {
        void findSQLData(string chip)
        {
            string datetime = DateTime.Now.ToString("yyyyMMddHHmmss");
            string LogFolder = @"Data Source=C:\Users\ВикторАДиндев\source\repos\RFIDWindowsForms";
            try
            {

                //Create Connection to SQL Server
                SqlConnection SQLConnection = new SqlConnection();
                SQLConnection.ConnectionString = @"Data Source=C:\Users\ВикторАДиндев\source\repos\RFIDWindowsForms\xsqlite.db;Version=3;";


                //Query for getting Count
                string QueryFind = "select count(*) from dbo.Customer";
                //Query for getting Name ( Returns only single value)
                string QueryName = "select Top 1 Name  from dbo.Customer";



                //Execute Queries and save results into variables
                SqlCommand CmdCnt = SQLConnection.CreateCommand();
                

                SqlCommand CmdName = SQLConnection.CreateCommand();
                CmdName.CommandText = QueryName;

                SQLConnection.Open();
                Int32 CustomerCnt = (Int32)CmdCnt.ExecuteScalar();
                string CustomerName = (string)CmdName.ExecuteScalar();
                SQLConnection.Close();

                //Show values from variables
                Console.WriteLine("CustomerName:" + CustomerName);
                Console.WriteLine("CustomerCount:" + CustomerCnt.ToString());
                Console.ReadLine();
            }
            catch (Exception exception)
            {
                // Create Log File for Errors
                using (StreamWriter sw = File.CreateText(LogFolder
                    + "\\" + "ErrorLog_" + datetime + ".log"))
                {
                    sw.WriteLine(exception.ToString());

                }

            }

        }
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
