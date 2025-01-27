using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;


namespace RFIDWindowsForms
{
    public partial class UCUpdating : UserControl
    {
        public UCUpdating()
        {
            InitializeComponent();
        }

        private void btn_info_update_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"1 - Кликнете върху полето ( RFID ).\n" +
                            $"2 - Поставете чипа.\n" +
                            $"3 - Променете останалите полета ( Име / Презиме / Фамилия )\n" +
                            $"!!! НЕ ОСТАВЯЙТЕ ПРАЗНО ПОЛЕ !!!", "ИНФОРМАЦИЯ");
        }

        private void btn_showAll_update_Click(object sender, EventArgs e)
        {
            var dbh = new DatabaseHelper();
            dataGridView_updata.DataSource = dbh.fillTable();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            var dbh = new DatabaseHelper();
            dbh.update(txt_firstName_update.Text,
                        txt_secondName_update.Text,
                        txt_lastName_update.Text,
                        txt_rfid_update.Text);
            
            dataGridView_updata.DataSource = dbh.showDataChanges(txt_rfid_update.Text);

            txt_firstName_update.Text = "";
            txt_secondName_update.Text = "";
            txt_lastName_update.Text = "";
            txt_rfid_update.Text = "";
        }

        private void txt_rfid_update_TextChanged(object sender, EventArgs e)
        {
            if (txt_rfid_update.Text.Length >= 10)
            {
                var dbh = new DatabaseHelper();

                txt_firstName_update.Text = dbh.findFirstName(txt_rfid_update.Text);
                txt_secondName_update.Text = dbh.findSecondName(txt_rfid_update.Text);
                txt_lastName_update.Text = dbh.findLastName(txt_rfid_update.Text);
            }
        }

        private void btn_exportXls_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel file|*.xlsx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string path = sfd.FileName;
                DatabaseHelper dbh = new DatabaseHelper();
                dbh.export(path);
            }

            /*
            * string currentdatetime = DateTime.Now.ToString("yyyyMMddHHmmss");
            * string LogFolder = @"D:\Files\Logs";
            * string connectionString = @"Server=DESKTOP-EKJ1P64\SQL2019;Database=Test;Integrated Security=True;";
            * string queryString = "select * from email";
            * string filePath = @"D:\Files\Email.XLSX";
            * 
            * try
            * {
            *     if (File.Exists(filePath))
            *         File.Delete(filePath);
            * 
            *     // Connect to the SQL Server database and retrieve the data you want to export
            *     using (SqlConnection connection = new SqlConnection(connectionString))
            *     {
            *         connection.Open();
            *         using (SqlCommand command = new SqlCommand(queryString, connection))
            *         {
            *             using (SqlDataReader reader = command.ExecuteReader())
            *             {
            *                 // Create a new Excel application and workbook
            *                 Application excelApp = new Application();
            *                 Workbook excelWorkbook = excelApp.Workbooks.Add();
            *                 Worksheet excelWorksheet = excelWorkbook.Worksheets[1];
            * 
            *                 // Add the headers to the first row
            *                 int col = 1;
            *                 for (int i = 0; i < reader.FieldCount; i++)
            *                 {
            *                     excelWorksheet.Cells[1, col].Value2 = reader.GetName(i);
            *                     col++;
            *                 }
            * 
            *                 // Iterate through the rows of data and insert them into the worksheet, starting from the second row
            *                 int row = 2;
            *                 while (reader.Read())
            *                 {
            *                     col = 1;
            *                     for (int i = 0; i < reader.FieldCount; i++)
            *                     {
            *                         excelWorksheet.Cells[row, col].Value2 = reader[i];
            *                         col++;
            *                     }
            *                     row++;
            *                 }
            * 
            *                 // Save the workbook and close the Excel application
            *                 excelWorkbook.SaveAs(filePath);
            *                 excelWorkbook.Close();
            *                 excelApp.Quit();
            *             }
            *         }
            *     }
            * 
            * }
            * 
            * catch (Exception exception)
            * {
            *     using (StreamWriter sw = File.CreateText(LogFolder + "\\" + "ErrorLog_" + currentdatetime + ".log"))
            *     {
            *         sw.WriteLine(exception.ToString());
            *     }
            * 
            * }
            */
        }
    }
}
