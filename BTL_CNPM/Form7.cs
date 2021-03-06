﻿using System;
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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            ketnoi();

        }
        string strConn = "Data Source=DESKTOP-GRFRNP2\\SQLEXPRESS;Initial Catalog=CNPM;Integrated Security=True";
        SqlConnection connect = null;
        SqlDataAdapter adapter = null;
        SqlCommand cmd = null;
        public void ketnoi()
        {

            connect = new SqlConnection(strConn);
            connect.Open();
            string query = "select *from NhanVien";

            cmd = new SqlCommand(query, connect);
            adapter = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            adapter.Fill(data);
            dataGridView1.DataSource = data;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f = new Form6();
            f.Show();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string them = " insert into NhanVien values(" + "N'" + txtHoTen.Text + "', '" + txtSDT.Text + "', N'" + txtDiaChi.Text + "', '" + txtTuoi.Text + "')";
            cmd = new SqlCommand(them, connect);
            cmd.ExecuteNonQuery();
            ketnoi();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Are you sure to delete?", "WARNING!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (traloi == DialogResult.Yes)
            {
                connect = new SqlConnection(strConn);
                connect.Open();
                string delete = "delete from NhanVien where MaNV ='" + txtID.Text + "'";
                cmd = new SqlCommand(delete, connect);
                cmd.ExecuteNonQuery();
                ketnoi();
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string update = "update NhanVien set TenNV =N'" + txtHoTen.Text + "',SoDienThoai ='" + txtSDT.Text + "',DiaChi = N'" + txtDiaChi.Text + "',Tuoi ='" + txtTuoi.Text + "' where MaNV ='" + txtID.Text + "' ";
            SqlCommand cmdupdate = new SqlCommand(update, connect);
            cmdupdate.ExecuteNonQuery();
            ketnoi();

            MessageBox.Show("Sửa thành công");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            txtID.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            txtHoTen.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txtSDT.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            txtDiaChi.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            txtTuoi.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();

        }
    }
}
