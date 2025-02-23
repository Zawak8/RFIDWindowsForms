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
            string startTime = start.ToString("dd.MM.yyyy");


            DateTime end = dateTimePicker2.Value;
            string endTime = end.ToString("dd.MM.yyyy");


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
