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

namespace RFIDWindowsForms
{
    public partial class UCWrite : UserControl
    {
        public UCWrite()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            var dbh = new DatabaseHelper();
            if (txt_rfid_write.Text.Length >= 10)
            {
                dbh.insertSqlRfid(txt_firstName_write.Text,
                                    txt_secondName_write.Text,
                                    txt_lastName_write.Text,
                                    txt_rfid_write.Text);

                dataGridView_write.DataSource = dbh.showDataChanges(txt_rfid_write.Text);

                txt_firstName_write.Text = "";
                txt_secondName_write.Text = "";
                txt_lastName_write.Text = "";
                txt_rfid_write.Text = "";
            }
            else
            {
                MessageBox.Show("Този чип съществува в базата, или е невалиден", "Информация!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_info_write_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"1 - Кликнете върху полето ( RFID ).\n" +
                            $"2 - Поставете новия чип.\n" +
                            $"3 - Попълнете останалите полета ( Име / Презиме / Фамилия )\n" +
                            $"!!! НЕ ОСТАВЯЙТЕ ПРАЗНО ПОЛЕ !!!", "ИНФОРМАЦИЯ");
        }
    }
}

