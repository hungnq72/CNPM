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
    public partial class Form2 : Form
    {
        public Form2()
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
            private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fTroGiup f = new fTroGiup();
            f.Show();
        }

        private void liênHệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fLienHe f = new fLienHe();
            f.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connect = new SqlConnection(strConn);
            connect.Open();
            string them = "insert into NguoiDung values(" + "N'" + txtTaiKhoan.Text + "', N'" + txtMatKhau.Text + "')";
            cmd = new SqlCommand(them, connect);
            cmd.ExecuteNonQuery();
            ketnoi();

            MessageBox.Show("Đăng bán thành công");

        }
    }
}
