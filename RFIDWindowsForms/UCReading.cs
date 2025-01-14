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

                    /*var dt = new DataTable();
                    dt.Columns.Add("FULL NAME");
                    dt.Columns.Add("ACCEPTED RFID CHIP");
                    dt.Rows.Add(dbh.findSqlRfid(txt_reader.Text), "OKEY");
                    dataGridView_read.DataSource = dt;
*/

                    dataGridView_read.DataSource = dbh.fillTable();
                    //dataGridView_read.Rows.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Can not show data\n\n{ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }





            ////
            ///
            /*
            string conString = "Data Source=localhost;Initial Catalog=LoginScreen;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);

            string selectSql = "select * from Pending_Tasks";
            SqlCommand com = new SqlCommand(selectSql, con);

            try
            {
                con.Open();

                using (SqlDataReader read = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        CustID.Text = (read["Customer_ID"].ToString());
                        CustName.Text = (read["Customer_Name"].ToString());
                        Add1.Text = (read["Address_1"].ToString());
                        Add2.Text = (read["Address_2"].ToString());
                        PostBox.Text = (read["Postcode"].ToString());
                        PassBox.Text = (read["Password"].ToString());
                        DatBox.Text = (read["Data_Important"].ToString());
                        LanNumb.Text = (read["Landline"].ToString());
                        MobNumber.Text = (read["Mobile"].ToString());
                        FaultRep.Text = (read["Fault_Report"].ToString());
                    }
                }
            }
            finally
            {
                con.Close();
            }
            */
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            DatabaseHelper dbh = new DatabaseHelper();
            
        }
    }
}
