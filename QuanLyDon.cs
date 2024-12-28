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
    public partial class QuanLyDon : Form
    {
        public QuanLyDon()
        {
            InitializeComponent();
        }
        public void LoadDon()
        {
            String duongDan = "Data Source=DOANHHUY\\SQLEXPRESS;Initial Catalog=SINHVIEN;Integrated Security=True";
            SqlConnection conn = new SqlConnection(duongDan);
            String sqlHang = "select * from DONHANG";
            SqlDataAdapter da = new SqlDataAdapter(sqlHang, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void LoadMaHang()
        {
            String duongDan = "Data Source=DOANHHUY\\SQLEXPRESS;Initial Catalog=SINHVIEN;Integrated Security=True";
            SqlConnection conn = new SqlConnection(duongDan);
            String sqlSV = "select * from HANG";
            SqlDataAdapter da = new SqlDataAdapter(sqlSV, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cb_mahang.DataSource = dt;
            cb_mahang.DisplayMember = "mahang";
            cb_mahang.ValueMember = "mahang";
            //dataGridView1.DataSource = dt;
        }
        public void LoadTaiKhoan()
        {
            String duongDan = "Data Source=DOANHHUY\\SQLEXPRESS;Initial Catalog=SINHVIEN;Integrated Security=True";
            SqlConnection conn = new SqlConnection(duongDan);
            String sqlSV = "select * from TAIKHOAN";
            SqlDataAdapter da = new SqlDataAdapter(sqlSV, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cb_taikhoan.DataSource = dt;
            cb_taikhoan.DisplayMember = "tendangnhap";
            cb_taikhoan.ValueMember = "tendangnhap";
            //dataGridView1.DataSource = dt;
        }
        private void QuanLyDon_Load(object sender, EventArgs e)
        {
            LoadDon();
            LoadMaHang();
            LoadTaiKhoan();
        }

        private void thembtn__Click(object sender, EventArgs e)
        {
            String duongDan = "Data Source=DOANHHUY\\SQLEXPRESS;Initial Catalog=SINHVIEN;Integrated Security=True";
            SqlConnection conn = new SqlConnection(duongDan);
            String sqlThem = "INSERT INTO DONHANG VALUES ('" + txt_madon.Text + "', " +
               "'" + cb_mahang.SelectedValue + "', " +
               txt_soluong.Text + ", " +
               "Convert(DateTime, '" + dtp_don.Value.ToString("dd/MM/yyyy HH:mm:ss") + "', 120), " +
               txt_tongtien.Text + ")";
            SqlCommand comm = new SqlCommand(sqlThem, conn);
            conn.Open();
            int ketQua = comm.ExecuteNonQuery();
            conn.Close();
            if (ketQua >= 1)
            {
                MessageBox.Show("Thêm đơn hàng thành công");
                LoadDon();
            }
        }

        private void xoabtn__Click(object sender, EventArgs e)
        {
            String duongDan = "Data Source=DOANHHUY\\SQLEXPRESS;Initial Catalog=SINHVIEN;Integrated Security=True";
            SqlConnection conn = new SqlConnection(duongDan);
            String sqlXoa = "DELETE FROM DONHANG WHERE madon = '" + txt_madon.Text + "'";
            SqlCommand comm = new SqlCommand(sqlXoa, conn);
            conn.Open();
            int ketQua = comm.ExecuteNonQuery();
            conn.Close();
            if (ketQua >= 1)
            {
                MessageBox.Show("Xoá mặt hàng thành công");
                LoadDon();
            }
        }

        private void txt_demdon_TextChanged(object sender, EventArgs e)
        {
            /*String duongDan = "Data Source=DOANHHUY\\SQLEXPRESS;Initial Catalog=SINHVIEN;Integrated Security=True";
            SqlConnection conn = new SqlConnection(duongDan);
            String sqlDem = "select count (*) from DONHANG";
            SqlCommand comm = new SqlCommand(sqlDem, conn);
            conn.Open();
            int ketQua = (int)comm.ExecuteScalar();
            conn.Close();
            txt_demdon.Text = ketQua.ToString();*/

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_madon.Text = dataGridView1.CurrentRow.Cells["madon"].Value.ToString();
            cb_mahang.SelectedValue= dataGridView1.CurrentRow.Cells["mahang"].Value.ToString();
            txt_soluong.Text = dataGridView1.CurrentRow.Cells["soluong"].Value.ToString();
            txt_tongtien.Text = dataGridView1.CurrentRow.Cells["tongtien"].Value.ToString();
            // dtp1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
           // dtp_don.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //cb_taikhoan.SelectedValue = dataGridView1.CurrentRow.Cells["tendangnhap"].Value.ToString();
        }

        private void suabtn__Click(object sender, EventArgs e)
        {
            String duongDan = "Data Source=DOANHHUY\\SQLEXPRESS;Initial Catalog=SINHVIEN;Integrated Security=True";
            SqlConnection conn = new SqlConnection(duongDan);
            String sqlSua = "UPDATE DONHANG SET " +
                            "mahang = N'" + cb_mahang.SelectedValue + "', " +
                            "soluong = " + txt_soluong.Text + ", " +
                            "ngayxuat = Convert(DateTime, '" + dtp_don.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', 120), " +
                            "tongtien = '" + txt_tongtien.Text + "' " + // Thêm dấu nháy đơn và dấu phẩy
                            "WHERE madon = '" + txt_madon.Text + "'";
            SqlCommand comm = new SqlCommand(sqlSua, conn);

            try
            {
                conn.Open();
                int ketQua = comm.ExecuteNonQuery();
                if (ketQua >= 1)
                {
                    MessageBox.Show("Sửa đơn hàng thành công");
                    LoadDon();
                }
                else
                {
                    MessageBox.Show("Không có đơn hàng nào được sửa");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
