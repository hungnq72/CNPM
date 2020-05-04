using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace BTL_CNPM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbusername.Text == "admin" && tbpass.Text == "123")
            {
                this.Hide();
                Form6 f = new Form6();
                f.Show();
            }
            else if (tbusername.Text == "user" && tbpass.Text == "123")
            {
                this.Hide();
                Form3 f = new Form3();
                f.Show();
            }
            else if (tbusername.Text == "employee" && tbpass.Text == "123")
            {
                this.Hide();
                Form6 f = new Form6();
                f.Show();
            }
            else
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu, vui lòng nhập lại");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }

        private void tbpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //this.Hide();
            fTroGiup f = new fTroGiup();
            f.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //this.Hide();
            fLienHe f = new fLienHe();
            f.Show();
        }
    }
}
