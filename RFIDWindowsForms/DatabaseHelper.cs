﻿using System;
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
                Console.WriteLine(ex.Message);
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
        
        internal DataTable showDataChanges(string chip)
        {
            string firstName = "";
            string secondName = "";
            string lastName = "";
            
            var dt = new DataTable();
            
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
        
        internal string findSqlRfid(string chip)
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

            DataTable dt = new DataTable();
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
        
        internal void timeRead()
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);

        }
    }
}
