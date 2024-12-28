using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnhHuy_1376
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if(currentFormChild != null)
            {
                currentFormChild.Close();
            } 
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None; // bỏ menu trên form con
            childForm.Dock = DockStyle.Fill; // lấp đầy panel giữa bằng Fill form con
            panel_body.Controls.Add(childForm); //thêm form con vào panel giữa
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel_body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLy());
            label1.Text = btn1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        

        private void button2_Click(object sender, EventArgs e)
        {

        }
        int tat = 0;
        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn đăng xuất", "Thông Báo",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                tat = 1;
                this.Close(); 
            }
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            label1.Text = "TRANG CHỦ";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyDon());
            label1.Text = btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QL_DanhMuc());
            label1.Text = "Quản Lý Danh Mục";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QL_NCC());
            label1.Text = "Quản Lý Nhà Cung Cấp";
        }
    }
}
