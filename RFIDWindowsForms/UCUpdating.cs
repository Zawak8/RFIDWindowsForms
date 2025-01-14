﻿using System;
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
    public partial class UCUpdating : UserControl
    {
        public UCUpdating()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseHelper dbh = new DatabaseHelper();
                dataGridView_read.DataSource = dbh.fillTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Can not show data\n\n{ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
