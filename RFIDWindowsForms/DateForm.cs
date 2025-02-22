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
    public partial class DateForm : Form
    {
        public DateForm()
        {
            InitializeComponent();
        }

        private void btn_create_excel_Click(object sender, EventArgs e)
        {

            DateTime start = dateTimePicker1.Value;
            string startDay = start.Day.ToString();
            string startMonth = start.Month.ToString();
            string startYear = start.Year.ToString();
            string startTime = $"{startDay}.{startMonth}.{startYear}";


            DateTime end = dateTimePicker2.Value;
            string endDay = start.Day.ToString();
            string endMonth = start.Month.ToString();
            string endYear = start.Year.ToString();
            string endTime = $"{startDay}.{startMonth}.{startYear}";
/*
            using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.Open();

                string queryString = @"SELECT Date, FirstName, SecondName, LastName, RFID
                                    FROM employees AS e
                                    JOIN date AS d ON e.id = d.id
                                    WHERE Date BETWEEN @start AND @end";


            }
*/





            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel file|*.xlsx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string path = sfd.FileName;
                DatabaseHelper dbh = new DatabaseHelper();
                dbh.export(path, startTime, endTime);
            }
        }
    }
}
