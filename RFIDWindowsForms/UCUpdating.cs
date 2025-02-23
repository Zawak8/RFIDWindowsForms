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
            try
            {
                if (txt_rfid_update.Text.Length >= 10)
                {
                    var dbh = new DatabaseHelper();

                    txt_firstName_update.Text = dbh.findFirstName(txt_rfid_update.Text);
                    txt_secondName_update.Text = dbh.findSecondName(txt_rfid_update.Text);
                    txt_lastName_update.Text = dbh.findLastName(txt_rfid_update.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No data found!\n{ex}", "ERROR");
            }
        }

        private void btn_exportXls_Click(object sender, EventArgs e)
        {
            DateForm dateForm = new DateForm();
            dateForm.Show();
        }
    }
}
