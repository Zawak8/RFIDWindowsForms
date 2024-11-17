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
        public UCReading()
        {
            InitializeComponent();
        }

        private void txt_reader_TextChanged(object sender, EventArgs e)
        {
            //TODO:
            //System.Threading.Thread.Sleep(3000);
            //txt_reader.Clear();
            string connectionString = @"Data Source=C:\Users\ВикторАДиндев\source\repos\RFIDWindowsForms\xsqlite.db;Version=3;";

            SQLiteConnection conn = new SQLiteConnection(connectionString);

            conn.Open();
            
            string query = $"SELECT * FROM employes WHERE rfid = '{txt_reader.Text}'";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

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

        }
    }
}
