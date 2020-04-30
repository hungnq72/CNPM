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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            ketnoi();
        }
        string strConn = "Data Source=DESKTOP-GRFRNP2\\SQLEXPRESS;Initial Catalog=CNPM;Integrated Security=True";
        SqlConnection connect = null;
        SqlCommand cmd = null;
        public void ketnoi()
        {
            connect = new SqlConnection(strConn);
            connect.Open();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f = new Form3();
            f.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string them = " insert into SanPham values(" + "N'" + txtTenHang.Text + "', '" + txtKhoiLuong.Text + "', N'" + txtXuatxu.Text + "', '" + txtDonGia.Text + "')"; 
            cmd = new SqlCommand(them, connect);
            cmd.ExecuteNonQuery();
            ketnoi();

            MessageBox.Show("Đăng bán thành công");
        }
    }
}
