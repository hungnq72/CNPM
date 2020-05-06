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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            ketnoi();
            ketnoi2();
        }
        string strConn = "Data Source=DESKTOP-GRFRNP2\\SQLEXPRESS;Initial Catalog=CNPM;Integrated Security=True";
        SqlConnection connect = null;
        SqlDataAdapter adapter = null;
        SqlCommand cmd = null;
        private void ketnoi()
        {

            connect = new SqlConnection(strConn);
            connect.Open();
            string query = "select sum(ThuNhap) from DoanhThu";
            cmd = new SqlCommand(query, connect);
            adapter = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            adapter.Fill(data);
            dataGridView1.DataSource = data;


        }
        private void ketnoi2()
        {
            connect = new SqlConnection(strConn);
            connect.Open();
            string query = "select *from DoanhThu";
            cmd = new SqlCommand(query, connect);
            adapter = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            adapter.Fill(data);
            dataGridView2.DataSource = data;


        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f = new Form6();
            f.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {

        }
    }
}
