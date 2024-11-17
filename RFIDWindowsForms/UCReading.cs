using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            if (txt_reader.Text.Length == 10)
            {
                //TODO:
                //System.Threading.Thread.Sleep(3000);
                //txt_reader.Clear();
            }
            else
            {
                //System.Threading.Thread.Sleep(3000);
                //txt_reader.Clear();
            }
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {

        }
    }
}
