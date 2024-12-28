using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnhHuy_1376
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            String duongDan = "Data Source=DOANHHUY\\SQLEXPRESS;Initial Catalog=SINHVIEN;Integrated Security=True";
            SqlConnection conn = new SqlConnection(duongDan);
            String sqlDN = "select count (*) from TAIKHOAN " +
                "where TenDangNhap = N'" + txt_dangnhap.Text + "' " +
                "and MatKhau = '" + txt_matkhau.Text + "'";
            SqlCommand comm = new SqlCommand(sqlDN, conn);
            conn.Open();
            int ketQua = (int)comm.ExecuteScalar();
            conn.Close();
            if (ketQua >= 1)
            {
                //frm_SinhVien sv = new frm_SinhVien();
                // FormHome f1 = new FormHome();
                //f1.Show();
                //QuanLy ql = new QuanLy();
                //ql.Show();
                FormHome fh1 = new FormHome();
                fh1.Show();
            } 
            else MessageBox.Show("Sai tên ĐN hoặc MK"); 
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        int tat = 0;
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát ko", "Thông Báo",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                tat = 1;
                //Application.Exit();
                this.Close(); // dùng cho form tự đóng mở
            }
        }
    }
}
