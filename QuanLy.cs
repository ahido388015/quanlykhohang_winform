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
    public partial class QuanLy : Form
    {
        public QuanLy()
        {
            InitializeComponent();
        }
        public void LoadHang()
        {
            String duongDan = "Data Source=DOANHHUY\\SQLEXPRESS;Initial Catalog=SINHVIEN;Integrated Security=True";
            SqlConnection conn = new SqlConnection(duongDan);
            String sqlHang = "select * from HANG";
            SqlDataAdapter da = new SqlDataAdapter(sqlHang, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void LoadNCC()
        {
            String duongDan = "Data Source=DOANHHUY\\SQLEXPRESS;Initial Catalog=SINHVIEN;Integrated Security=True";
            SqlConnection conn = new SqlConnection(duongDan);
            String sqlSV = "select * from NHACUNGCAP";
            SqlDataAdapter da = new SqlDataAdapter(sqlSV, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cb_ncc.DataSource = dt;
            cb_ncc.DisplayMember = "nhacungcap";
            cb_ncc.ValueMember = "nhacungcap";
            //dataGridView1.DataSource = dt;
        }
        public void LoadDanhMuc()
        {
            String duongDan = "Data Source=DOANHHUY\\SQLEXPRESS;Initial Catalog=SINHVIEN;Integrated Security=True";
            SqlConnection conn = new SqlConnection(duongDan);
            String sqlSV = "select * from DANHMUC";
            SqlDataAdapter da = new SqlDataAdapter(sqlSV, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cb_danhmuc.DataSource = dt;
            cb_danhmuc.DisplayMember = "tendanhmuc";
            cb_danhmuc.ValueMember = "tendanhmuc";
            //dataGridView1.DataSource = dt;
        }



        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void QuanLy_Load(object sender, EventArgs e)
        {
            LoadHang();
            LoadNCC();
            LoadDanhMuc();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            String duongDan = "Data Source=DOANHHUY\\SQLEXPRESS;Initial Catalog=SINHVIEN;Integrated Security=True";
            SqlConnection conn = new SqlConnection(duongDan);
            String sqlThem = "INSERT INTO HANG VALUES ('" + txt_mahang.Text + "', " +
               "N'" + txt_tenhang.Text + "', " +
               txt_soluong.Text + ", " +
               "'" + cb_ncc.SelectedValue + "', " +
               "'" + cb_danhmuc.SelectedValue + "', " +
               "Convert(DateTime, '" + dtp1.Value.ToString("dd/MM/yyyy HH:mm:ss") + "', 120))";
            SqlCommand comm = new SqlCommand(sqlThem, conn);
            conn.Open();
            int ketQua = comm.ExecuteNonQuery();
            conn.Close();
            if (ketQua >= 1)
            {
                MessageBox.Show("Thêm mặt hàng thành công");
                LoadHang();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            String duongDan = "Data Source=DOANHHUY\\SQLEXPRESS;Initial Catalog=SINHVIEN;Integrated Security=True";
            SqlConnection conn = new SqlConnection(duongDan);
            String sqlXoa = "DELETE FROM HANG WHERE mahang = '" + txt_mahang.Text + "'";
            SqlCommand comm = new SqlCommand(sqlXoa, conn);
            conn.Open();
            int ketQua = comm.ExecuteNonQuery();
            conn.Close();
            if (ketQua >= 1)
            {
                MessageBox.Show("Xoá mặt hàng thành công");
                LoadHang();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_mahang.Text = dataGridView1.CurrentRow.Cells["mahang"].Value.ToString();
            txt_tenhang.Text = dataGridView1.CurrentRow.Cells["tenhang"].Value.ToString();
            txt_soluong.Text = dataGridView1.CurrentRow.Cells["soluong"].Value.ToString();
           // dtp1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cb_ncc.SelectedValue = dataGridView1.CurrentRow.Cells["nhacungcap"].Value.ToString();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            String duongDan = "Data Source=DOANHHUY\\SQLEXPRESS;Initial Catalog=SINHVIEN;Integrated Security=True";
            SqlConnection conn = new SqlConnection(duongDan);
            String sqlSua = "UPDATE HANG SET " +
                     "tenhang = N'" + txt_tenhang.Text + "', " +
                     "soluong = " + txt_soluong.Text + ", " +
                     "nhacungcap = '" + cb_ncc.SelectedValue + "', " +
                     "tendanhmuc = '" + cb_danhmuc.SelectedValue +
                     "ngaynhap = Convert(DateTime, '" + dtp1.Value.ToString("dd/MM/yyyy HH:mm:ss") + "', 120) " +
                     "WHERE mahang = '" + txt_mahang.Text + "'";
            SqlCommand comm = new SqlCommand(sqlSua, conn);
            conn.Open();
            int ketQua = comm.ExecuteNonQuery();
            conn.Close();
            if (ketQua >= 1)
            {
                MessageBox.Show("Sửa thành công");
                LoadHang();
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            LoadHang();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            String duongDan = "Data Source=DOANHHUY\\SQLEXPRESS;Initial Catalog=SINHVIEN;Integrated Security=True";
            SqlConnection conn = new SqlConnection(duongDan);
            String sqlSV = "select * from HANG " +
                "where mahang like '%" + txt_timkiem.Text + "%' or tenhang like N'%" + txt_timkiem.Text + "%' ";
            SqlDataAdapter da = new SqlDataAdapter(sqlSV, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
