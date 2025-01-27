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
using System.Web;
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace RFIDWindowsForms
{
    internal class DatabaseHelper
    {
        private static string connectionString = @"Data Source=xsqlite.db;Version=3;";

        //Creating DB file if not exist
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
                            FirstName TEXT NOT NULL,
                            SecondName TEXT NOT NULL,
                            LastName TEXT NOT NULL,
                            RFID TEXT UNIQUE NOT NULL
                        );";
                    string createDateTableQuery = @"
                        CREATE TABLE IF NOT EXISTS date (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            Date TEXT NOT NULL, 
                            EmployeeRFID TEXT NOT NULL,
                            FOREIGN KEY(EmployeeRFID) REFERENCES employees(RFID)
                        );";
                    using (var command = new SQLiteCommand(connection))
                    {
                        command.CommandText = createEmployesTableQuery;
                        command.ExecuteNonQueryAsync();
                        
                        command.CommandText = createDateTableQuery;
                        command.ExecuteNonQueryAsync();
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
                        insertDataCommand.Parameters.AddWithValue("@FirstName", firstName);
                        insertDataCommand.Parameters.AddWithValue("@SecondName", secondName);
                        insertDataCommand.Parameters.AddWithValue("@LastName", lastName);
                        insertDataCommand.Parameters.AddWithValue("@RFID", chip);

                    // Execute the INSERT statement
                        var rowInserted = insertDataCommand.ExecuteNonQueryAsync();
                    }
                    connection.Close();
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        internal string findFirstName(string chip)
        {
            string firstName = "";
            try
            {
                //Create Connection to SQL Server
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string findFirstNameQuery = @"SELECT FirstName 
                                                FROM employees 
                                                WHERE RFID = @rfid";

                    using (SQLiteCommand command = new SQLiteCommand(findFirstNameQuery, connection))
                    {
                        command.Parameters.Add(new SQLiteParameter("@rfid", chip));
                        firstName = command.ExecuteScalar().ToString();
                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return firstName;
        }
        
        internal string findSecondName(string chip)
        {
            string secondName = "";
            try
            {
                //Create Connection to SQL Server
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string findSecondNameQuery = @"SELECT SecondName 
                                                FROM employees 
                                                WHERE RFID = @rfid";

                    using (SQLiteCommand command = new SQLiteCommand(findSecondNameQuery, connection))
                    {
                        command.Parameters.Add(new SQLiteParameter("@rfid", chip));
                        secondName = command.ExecuteScalar().ToString();
                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return secondName;
        }
        
        internal string findLastName(string chip)
        {
            string lastName = "";
            try
            {
                //Create Connection to SQL Server
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string findLastNameQuery = @"SELECT LastName 
                                                FROM employees 
                                                WHERE RFID = @rfid";

                    using (SQLiteCommand command = new SQLiteCommand(findLastNameQuery, connection))
                    {
                        command.Parameters.Add(new SQLiteParameter("@rfid", chip));
                        lastName = command.ExecuteScalar().ToString();
                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return lastName;
        }
        
        internal System.Data.DataTable showDataChanges(string chip)
        {
            string firstName = "";
            string secondName = "";
            string lastName = "";
            
            var dt = new System.Data.DataTable();
            
            try
            {
                firstName = findFirstName(chip);
                secondName = findSecondName(chip);
                lastName = findLastName(chip);

                dt.Columns.Add("FirstName");
                dt.Columns.Add("SecondName");
                dt.Columns.Add("LastName");
                dt.Columns.Add("RFID");
                dt.Rows.Add(firstName, secondName, lastName, chip);
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
        
        internal string findEmployeeNameByRfid(string chip)
        {
            string fullName = "";
            
            try
            {
                fullName = findFirstName(chip) + " " + findLastName(chip);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Не намерен потребител\n\n{e.Message}","ERROR");
            }

            return fullName;
        }

        internal object fillTable()
        {
            SQLiteConnection conn = new SQLiteConnection(connectionString);

            conn.Open();

            string query = $"SELECT * FROM employees";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            System.Data.DataTable dt = new System.Data.DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }

        internal void update(string firstName, string secondName, string lastName, string rfid)
        {
            SQLiteConnection conn = new SQLiteConnection(connectionString);
            string query = @"UPDATE employees
                            SET FirstName = @FirstName, 
                                SecondName = @SecondName, 
                                LastName = @LastName
                            WHERE RFID = @rfid";
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@FirstName", firstName);
            cmd.Parameters.AddWithValue("@SecondName", secondName);
            cmd.Parameters.AddWithValue("@LastName", lastName);
            cmd.Parameters.AddWithValue("@rfid", rfid);
            cmd.ExecuteNonQuery();
        }

        internal string findRFID(string chip)
        {
            string rfid = "";
            try
            {
                //Create Connection to SQL Server
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string findRFIDQuery = @"SELECT RFID 
                                                FROM employees 
                                                WHERE RFID = @rfid";

                    using (SQLiteCommand command = new SQLiteCommand(findRFIDQuery, connection))
                    {
                        command.Parameters.Add(new SQLiteParameter("@rfid", chip));
                        rfid = command.ExecuteScalar().ToString();
                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return rfid;
        }

        internal void timeRead(string rfid)
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();
            DateTime dateTime = DateTime.Now;

            /*
                    string day = dateTime.Day.ToString();
                    string month = dateTime.Month.ToString();
                    string year = dateTime.Year.ToString();
            */
            
            string time = dateTime.ToString();

            string query = @"INSERT INTO date(Date, EmployeeRFID)
                                VALUES(@date, @rfid)";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@date", time);
            command.Parameters.AddWithValue("@rfid", rfid);

            command.ExecuteNonQuery();
            connection.Close();
        }

        internal void export()
        {
            string currentdatetime = DateTime.Now.ToString("yyyyMMddHHmmss");
            string queryString = @"SELECT Date, FirstName, SecondName, LastName, RFID
                                    FROM employees AS e
                                    JOIN date AS d ON e.id = d.id";
            string filePath = @"Export.XLSX";

            try
            {
                // Connect to the SQL Server database and retrieve the data you want to export
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(queryString, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            // Create a new Excel application and workbook
                            Application excelApp = new Application();
                            Workbook excelWorkbook = excelApp.Workbooks.Add();
                            Worksheet excelWorksheet = excelWorkbook.Worksheets[1];

                            // Add the headers to the first row
                            int col = 1;
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                excelWorksheet.Cells[1, col].Value2 = reader.GetName(i);
                                col++;
                            }

                            // Iterate through the rows of data and insert them into the worksheet, starting from the second row
                            int row = 2;
                            while (reader.Read())
                            {
                                col = 1;
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    excelWorksheet.Cells[row, col].Value2 = reader[i];
                                    col++;
                                }
                                row++;
                            }

                            // Save the workbook and close the Excel application
                            excelWorkbook.SaveAs(filePath);
                            excelWorkbook.Close();
                            excelApp.Quit();
                        }
                    }
                }
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
