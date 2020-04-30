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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            ketnoi();
        }
        string strConn = "Data Source=DESKTOP-GRFRNP2\\SQLEXPRESS;Initial Catalog=CNPM;Integrated Security=True";
        SqlConnection connect = null;
        SqlDataAdapter adapter = null;
        SqlCommand cmd = null;
        private void ketnoi()
        {

            connect = new SqlConnection(strConn);
            connect.Open();
            string query = "select *from SanPham";

            cmd = new SqlCommand(query, connect);
            adapter = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            adapter.Fill(data);
            dataGridView1.DataSource = data;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f = new Form3();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string them = "insert into DonHang values ('" + txtMaHang.Text + "',1,'user','" + txtDonGia + "')";
            cmd = new SqlCommand(them, connect);
            //cmd.ExecuteNonQuery();
            ketnoi();
            MessageBox.Show("Mua hàng thành công");
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            txtMaHang.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            txtTenHang.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txtKhoiLuong.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            txtXuatXu.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            txtDonGia.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();

        }

        private void txtKhoiLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenHang_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
