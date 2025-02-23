using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFIDWindowsForms
{
    public partial class UCReading : UserControl
    {
        //private string connectionString = @"Data Source=xsqlite.db;Version=3";
        public UCReading()
        {
            InitializeComponent();
        }

        private void txt_reader_TextChanged(object sender, EventArgs e)
        {
            
            var dbh = new DatabaseHelper();
           
            if (txt_reader.Text.Length >= 10)
            {
                if (txt_reader.Text == dbh.findRFID(txt_reader.Text))
                {

                    try
                    {
                        var dt = new DataTable();
                        dt.Columns.Add("FULL NAME");
                        dt.Columns.Add("ACCEPTED RFID CHIP");
                        dt.Rows.Add(dbh.findEmployeeNameByRfid(txt_reader.Text), "OKEY");

                        // Resize the master DataGridView columns to fit the newly loaded data.
                        dataGridView_read.AutoResizeColumns();

                        // Configure the details DataGridView so that its columns automatically
                        // adjust their widths when the data changes.
                        dataGridView_read.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                        dataGridView_read.DataSource = dt;

                        //dataGridView_read.DataSource = dbh.fillTable();
                        //dataGridView_read.Rows.Clear();
                        dbh.timeRead(txt_reader.Text);
                        label1.ForeColor = Color.GhostWhite;
                        label1.Text = "ЧЕТЕНЕ НА ЧИП\nУСПЕШНО";
                        txt_reader.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Can not show data\n\n{ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    label1.ForeColor = Color.Red;
                    label1.Text = "ГРЕШЕН / НЕПОЗНАТ ЧИП\nОПИТАЙ ПАК";
                    txt_reader.Text = "";
                }
            }
        }

        private void btn_info_read_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"1 - Кликнете върху текстовото поле.\n" +
                            $"2 - Поставете чипа.\n" +
                            $"Резултата излиза в таблицата",
                            "ИНФОРМАЦИЯ");
        }
    }
}
