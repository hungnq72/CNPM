using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BTL_CNPM
{
    public partial class fAd3 : Form
    {
        public fAd3()
        {
            InitializeComponent();
            ketnoi();

        }
        string strConn = "Data Source=DESKTOP-GRFRNP2\\SQLEXPRESS;Initial Catalog=CNPM;Integrated Security=True";
        SqlConnection connect = null;

        SqlCommand cmd = null;
        private void ketnoi()
        {

            connect = new SqlConnection(strConn);
            connect.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect = new SqlConnection(strConn);
            connect.Open();
            string them = "insert into DonHang values ('0" + "', '" + txtTenHang.Text + "',1,'user','" + txtDonGia.Text + "')";
            cmd = new SqlCommand(them, connect);
            cmd.ExecuteNonQuery();
            ketnoi();
            MessageBox.Show("Mua hàng thành công");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f = new Form5();
            f.Show();

        }
    }
}
