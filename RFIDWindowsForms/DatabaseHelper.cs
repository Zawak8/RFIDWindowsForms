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
        private static string connectionString = @"Data Source=xsqlite.db;Version=3;";

        public static void InitializeDatabase()
        {
            if (!File.Exists(@"xsqlite.db"))
            {
                SQLiteConnection.CreateFile(@"xsqlite.db");

                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string createEmployesTableQuery = @"
                        CREATE TABLE IF NOT EXISTS employees (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            FirstName TEXT,
                            SecondName TEXT,
                            LastName TEXT ,
                            RFID TEXT
                        );";
                    string createDateTableQuery = @"
                        CREATE TABLE IF NOT EXISTS date (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            Date DATE, 
                            EmployeeId INTEGER NOT NULL,
                            FOREIGN KEY(EmployeeId) REFERENCES employees(Id)
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

        internal void insertSqlRfid(string firstName, string secondName, string lastName, string chip)
        {
            string queryInsertEmployee = $"INSERT INTO employees(FirstName, SecondName, LastName, RFID)" +
                                $"VALUES(@FirstName, @SecondName, @LastName, @RFID)";
            try
            {
                // Open a new database connection
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    // Bind parameters values
                    using (var insertDataCommand = new SQLiteCommand(queryInsertEmployee, connection))
                    {
//                        insertDataCommand.Parameters.AddWithValue("@ID", id);
                        insertDataCommand.Parameters.AddWithValue("@FirstName", firstName);
                        insertDataCommand.Parameters.AddWithValue("@SecondName", secondName);
                        insertDataCommand.Parameters.AddWithValue("@LastName", lastName);
                        insertDataCommand.Parameters.AddWithValue("@RFID", chip);

                    // Execute the INSERT statement
                    var rowInserted = insertDataCommand.ExecuteNonQuery();
                    }
                    connection.Close();
                }
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine(ex.Message);
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
