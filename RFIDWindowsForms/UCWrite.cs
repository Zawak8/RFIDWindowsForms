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
                SQLConnection.ConnectionString = @"Data Source=xsqlite.db;Version=3;";


                //Query for getting Count
                //      string QueryFind = "select count(*) from dbo.Customer";
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
            var employeeData = new DatabaseHelper();
            employeeData.insertSqlRfid(txt_firstName_write.Text,
                txt_secondName_write.Text,
                txt_lastName_write.Text,
                txt_rfid_write.Text);
        }
    }
}

