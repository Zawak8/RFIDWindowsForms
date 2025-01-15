using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            dataGridView_read.DataSource = dbh.fillTable();
        }
    }
}
