using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;

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
                        CREATE TABLE IF NOT EXISTS employees (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            Name TEXT NOT NULL,
                            SecondName TEXT NOT NULL,
                            LastName TEXT NOT NULL,
                            RFID TEXT NOT NULL
                        );";
                    string createDateTableQuery = @"
                        CREATE TABLE IF NOT EXISTS date (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            EmployeeId INTEGER NOT NULL,
                            FOREIGN KEY(EmployeeId) REFERENCES employees(Id),
                            Date DATE 
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

        void insertSqlRfid(string name, string secondName, string lastName, string chip)
        {
            string datetime = DateTime.Now.ToString("yyyyMMddHHmmss");
            string LogFolder = @"Data Source=C:\Users\ВикторАДиндев\source\repos\RFIDWindowsForms";
            try
            {

                //Create Connection to SQL Server
                SqlConnection SQLConnection = new SqlConnection();
                SQLConnection.ConnectionString = @"Data Source=C:\Users\ВикторАДиндев\source\repos\RFIDWindowsForms\xsqlite.db;Version=3;";

                string QueryRfid = $"INSERT INTO Employees(FirstName, SecondName, LastName, RFID)" +
                                $"VALUES({name}, {secondName}, {lastName}, {chip})";

                //Execute Queries and save results into variables
                
                SqlCommand CmdRfid = SQLConnection.CreateCommand();
                CmdRfid.CommandText = QueryRfid;

                SQLConnection.Open();
                CmdRfid.CommandText = QueryRfid;
                CmdRfid.ExecuteNonQuery();
                SQLConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        void findSqlRfid(string chip)
        {
            string datetime = DateTime.Now.ToString("yyyyMMddHHmmss");
            string LogFolder = @"Data Source=C:\Users\ВикторАДиндев\source\repos\RFIDWindowsForms";
            try
            {

                //Create Connection to SQL Server
                SqlConnection SQLConnection = new SqlConnection();
                SQLConnection.ConnectionString = @"Data Source=C:\Users\ВикторАДиндев\source\repos\RFIDWindowsForms\xsqlite.db;Version=3;";

                string QueryRfid = $"SELECT *" +
                                   $"FROM Employes" +
                                   $"WHERE RFID = {chip}";

                //Execute Queries and save results into variables

                SqlCommand CmdRfid = SQLConnection.CreateCommand();
                CmdRfid.CommandText = QueryRfid;

                SQLConnection.Open();
                string CustomerName = (string)CmdRfid.ExecuteScalar();
                SQLConnection.Close();

                //Show values from variables
                Console.WriteLine("CustomerName:" + CustomerName);
                Console.WriteLine("CustomerCount:");
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

    }
}
