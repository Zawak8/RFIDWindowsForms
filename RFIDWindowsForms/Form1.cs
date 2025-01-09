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
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //textBox1.Clear();
            
        }

        private void btn_reading_Click(object sender, EventArgs e)
        {
            ucWrite1.Hide();
            ucReading1.Show();
            var dbh = new DatabaseHelper();

        }

        private void btn_writing_Click(object sender, EventArgs e)
        {
            ucWrite1.Show();
            ucReading1.Hide();
        }
    }
}
