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
            if (txt_reader.Text.Length >= 10)
            {

                var dbh = new DatabaseHelper();
                try
                {
                    var dt = new DataTable();
                    dt.Columns.Add("FULL NAME");
                    dt.Columns.Add("ACCEPTED RFID CHIP");
                    dt.Rows.Add(dbh.findSqlRfid(txt_reader.Text), "OKEY");
                    dataGridView_read.DataSource = dt;


                    //dataGridView_read.DataSource = dbh.fillTable();
                    //dataGridView_read.Rows.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Can not show data\n\n{ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
