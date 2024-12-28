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
    public partial class QL_DanhMuc : Form
    {
        public QL_DanhMuc()
        {
            InitializeComponent();
        }
        public void LoadDanhmuc()
        {
            String duongDan = "Data Source=DOANHHUY\\SQLEXPRESS;Initial Catalog=SINHVIEN;Integrated Security=True";
            SqlConnection conn = new SqlConnection(duongDan);
            String sqlHang = "select * from DANHMUC";
            SqlDataAdapter da = new SqlDataAdapter(sqlHang, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

       
        private void QL_DanhMuc_Load(object sender, EventArgs e)
        {
            LoadDanhmuc();
        }

        private void them_dm_Click(object sender, EventArgs e)
        {
            String duongDan = "Data Source=DOANHHUY\\SQLEXPRESS;Initial Catalog=SINHVIEN;Integrated Security=True";
            SqlConnection conn = new SqlConnection(duongDan);

            try
            {
                String sqlThem = "INSERT INTO DANHMUC (madanhmuc, tendanhmuc) VALUES (@madm, @tendm)";
                SqlCommand comm = new SqlCommand(sqlThem, conn);

               
                comm.Parameters.AddWithValue("@madm", txt_madm.Text);
                comm.Parameters.AddWithValue("@tendm", txt_tendm.Text);

                conn.Open();
                int ketQua = comm.ExecuteNonQuery();

                if (ketQua >= 1)
                {
                    MessageBox.Show("Thêm danh mục thành công");
                    LoadDanhmuc();
                }
                else
                {
                    MessageBox.Show("Thêm danh mục không thành công");
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

        private void sua_dm_Click(object sender, EventArgs e)
        {
            String duongDan = "Data Source=DOANHHUY\\SQLEXPRESS;Initial Catalog=SINHVIEN;Integrated Security=True";
            SqlConnection conn = new SqlConnection(duongDan);
            try
            {
                String sqlUpdate = "UPDATE DANHMUC SET tendanhmuc = @tendm WHERE madanhmuc = @madm";
                SqlCommand comm = new SqlCommand(sqlUpdate, conn);

                // Thêm tham số
                comm.Parameters.AddWithValue("@madm", txt_madm.Text);
                comm.Parameters.AddWithValue("@tendm", txt_tendm.Text);

                conn.Open();
                int ketQua = comm.ExecuteNonQuery();

                if (ketQua >= 1)
                {
                    MessageBox.Show("Cập nhật danh mục thành công");
                    LoadDanhmuc(); // Giả sử đây là phương thức bạn dùng để tải lại danh sách danh mục
                }
                else
                {
                    MessageBox.Show("Cập nhật danh mục không thành công");
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

        private void xoa_dm_Click(object sender, EventArgs e)
        {
            String duongDan = "Data Source=DOANHHUY\\SQLEXPRESS;Initial Catalog=SINHVIEN;Integrated Security=True";
            SqlConnection conn = new SqlConnection(duongDan);

            try
            {
                String sqlDelete = "DELETE FROM DANHMUC WHERE madanhmuc = @madm";
                SqlCommand comm = new SqlCommand(sqlDelete, conn);

                // Thêm tham số
                comm.Parameters.AddWithValue("@madm", txt_madm.Text);

                conn.Open();
                int ketQua = comm.ExecuteNonQuery();

                if (ketQua >= 1)
                {
                    MessageBox.Show("Xóa danh mục thành công");
                    LoadDanhmuc(); // Giả sử đây là phương thức bạn dùng để tải lại danh sách danh mục
                }
                else
                {
                    MessageBox.Show("Xóa danh mục không thành công");
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_madm.Text = dataGridView1.CurrentRow.Cells["madanhmuc"].Value.ToString();
            txt_tendm.Text = dataGridView1.CurrentRow.Cells["tendanhmuc"].Value.ToString();
        }

        private void timkiem_dm_Click(object sender, EventArgs e)
        {
            String duongDan = "Data Source=DOANHHUY\\SQLEXPRESS;Initial Catalog=SINHVIEN;Integrated Security=True";
            SqlConnection conn = new SqlConnection(duongDan);
            String sqlSV = "select * from DANHMUC " +
                "where madanhmuc like '%" + txt_timkiemdm.Text + "%' or tendanhmuc like N'%" + txt_timkiemdm.Text + "%' ";
            SqlDataAdapter da = new SqlDataAdapter(sqlSV, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            LoadDanhmuc();
        }
    }
}
