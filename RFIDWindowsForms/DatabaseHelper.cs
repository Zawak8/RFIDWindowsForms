using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

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

        internal string findSqlRfid(string chip)
        {
            string fullName = "";
            
            try
            {
                //Create Connection to SQL Server
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string findFirstNameQuery = $"SELECT FirstName" +
                                           $"FROM Employes" +
                                           $"WHERE RFID = @rfid";

                    using(SQLiteCommand command = new SQLiteCommand(findFirstNameQuery, connection))
                    {
                        string firstName = command.ExecuteScalar().ToString();
                        fullName += firstName + " ";
                    }
                    
                    string findLastNameQuery = $"SELECT LastName" +
                                               $"FROM Employes" +
                                               $"WHERE RFID = @rfid";

                    using (SQLiteCommand command1 = new SQLiteCommand(findLastNameQuery, connection))
                    {
                        string lastName = command1.ExecuteScalar().ToString();
                        fullName += lastName;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Не намерен потребител\n\n{e.Message}","ERROR");
            }

            return fullName;
        }

        internal void fillTable()
        {
            SQLiteConnection conn = new SQLiteConnection(connectionString);

            conn.Open();

            string query = $"SELECT * FROM employees";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);
        }
    }
}
