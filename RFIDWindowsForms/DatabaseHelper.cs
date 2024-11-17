using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace RFIDWindowsForms
{
    internal class DatabaseHelper
    {
        private static string connectionString = @"Data Source=C:\Users\ВикторАДиндев\source\repos\RFIDWindowsForms\xsqlite.db;Version=3;";

        public static void InitializeDatabase()
        {
            if (!File.Exists(@"C:\Users\ВикторАДиндев\source\repos\RFIDWindowsForms\xsqlite.db"))
            {
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
}
