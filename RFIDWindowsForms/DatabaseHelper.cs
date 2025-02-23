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
                        CREATE TABLE IF NOT EXISTS dates (
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
        //Inserting new RFID
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
        //GridView for new RFID
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
        //GridView for searched Name by RFID
        internal string findEmployeeNameByRfid(string chip)
        {
            string fullName = "";

            try
            {
                fullName = findFirstName(chip) + " " + findLastName(chip);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Не намерен потребител\n\n{e.Message}", "ERROR");
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
        //Changing data in DataBase 
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
        //Search RFID
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
                        try
                        {
                            rfid = command.ExecuteScalar().ToString();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Нов или погрешен чип бе използван.\nМоля опитайте с друг чип.",
                                "ГРЕШЕН ЧИП",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Hand);
                        }
                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return rfid;
        }
        //Inserting date for RFID in DataBase
        internal void timeRead(string rfid)
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            connection.Open();

            DateTime dateTime = DateTime.Now;

            string time = dateTime.ToString("yyyy-MM-dd");

            string query = @"INSERT INTO dates(Date, EmployeeRFID)
                                VALUES(@date, @rfid)";

            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@date", time);
            command.Parameters.AddWithValue("@rfid", rfid);

            command.ExecuteNonQuery();
            connection.Close();
        }
        //Creating Excel file on pc
        internal void export(string path, string start, string end)
        {
            string queryString = @"SELECT DISTINCT Date, concat(FirstName, ' ', SecondName, ' ', LastName) FullName, RFID
                                    FROM employees AS e
                                    JOIN dates AS d ON e.RFID = d.EmployeeRFID
                                    WHERE Date BETWEEN @start AND @end
                                    GROUP BY Date, FirstName, SecondName, LastName, RFID;";

            Application excelApp = null;
            Workbook excelWorkbook = null;

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(queryString, connection))
                    {
                        // Convert strings to proper date format for SQLite
                        DateTime startDate = DateTime.ParseExact(start, "dd.MM.yyyy", null);
                        DateTime endDate = DateTime.ParseExact(end, "dd.MM.yyyy", null);

                        command.Parameters.AddWithValue("@start", startDate.ToString("yyyy-MM-dd"));
                        command.Parameters.AddWithValue("@end", endDate.ToString("yyyy-MM-dd"));

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                MessageBox.Show("No data found for the specified date range.");
                                return;
                            }

                            excelApp = new Application();
                            excelWorkbook = excelApp.Workbooks.Add();
                            Worksheet excelWorksheet = excelWorkbook.Worksheets[1];

                            // Add headers
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                excelWorksheet.Cells[1, i + 1].Value2 = reader.GetName(i);
                            }

                            // Add data
                            int row = 2;
                            while (reader.Read())
                            {
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    var value = reader[i]?.ToString();
                                    // Convert dates back to readable format for Excel
                                    if (i == 0 && DateTime.TryParse(value, out DateTime date))
                                    {
                                        value = date.ToString("dd.MM.yyyy");
                                    }
                                    excelWorksheet.Cells[row, i + 1].Value2 = value;
                                }
                                row++;
                            }

                            excelWorkbook.SaveAs(path);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                if (excelWorkbook != null)
                {
                    excelWorkbook.Close(false);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(excelWorkbook);
                }
                if (excelApp != null)
                {
                    excelApp.Quit();
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
                }
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }

        }

    }
}
