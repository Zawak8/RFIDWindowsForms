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
            SQLiteConnection.CreateFile(@"C:\Users\ВикторАДиндев\source\repos\RFIDWindowsForms\xsqlite.db");

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string createEmployesTableQuery = @"
                        CREATE TABLE IF NOT EXISTS employes (
                            id INTEGER PRIMARY KEY AUTOINCREMENT,
                            name TEXT NOT NULL,
                            sirName TEXT NOT NULL,
                            rfid TEXT NOT NULL
                        );";
                string createDateTableQuery = @"
                        CREATE TABLE IF NOT EXISTS date (
                            id INTEGER PRIMARY KEY AUTOINCREMENT,
                            name TEXT NOT NULL,
                            sirName TEXT NOT NULL,
                            rfid TEXT NOT NULL,
                            date DATE 
                        );";
                using (var command = new SQLiteCommand(connection))
                {
                    command.CommandText = createEmployesTableQuery;
                    command.ExecuteNonQuery();

                    command.CommandText = createDateTableQuery;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
