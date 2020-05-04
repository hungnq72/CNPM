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
    public partial class Form6 : Form
    {
        public Form6()
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
            string query = "select *from DonHang";

            cmd = new SqlCommand(query, connect);
            adapter = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            adapter.Fill(data);
            dataGridView1.DataSource = data;
            connect.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fKhach f = new fKhach();
            f.Show();

        }

        private void qLNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f = new Form7();
            f.Show();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 f = new Form9();
            f.Show();

        }

        private void btnChotDon_Click(object sender, EventArgs e)
        {
            connect = new SqlConnection(strConn);
            connect.Open();
            string them = " insert into DoanhThu values('" + txtMaDonHang.Text + "', '" + txtDonGia.Text + "')";
            cmd = new SqlCommand(them, connect);
            cmd.ExecuteNonQuery();
            ketnoi();

            MessageBox.Show("Chốt đơn thành công");
        }

        private void btnHuyDon_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn hủy đơn", "WARNING!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (traloi == DialogResult.Yes)
            {
                string delete = "delete from DonHang where MaDonHang ='" + txtMaDonHang.Text + "'";

                cmd = new SqlCommand(delete, connect);
                cmd.ExecuteNonQuery();
                ketnoi();
            }

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            txtMaDonHang.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            txtDonGia.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();

        }
    }
}
