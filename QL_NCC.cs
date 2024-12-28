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
    public partial class QL_NCC : Form
    {
        public QL_NCC()
        {
            InitializeComponent();
        }
        public void LoadNCC()
        {
            String duongDan = "Data Source=DOANHHUY\\SQLEXPRESS;Initial Catalog=SINHVIEN;Integrated Security=True";
            SqlConnection conn = new SqlConnection(duongDan);
            String sqlHang = "select * from NHACUNGCAP";
            SqlDataAdapter da = new SqlDataAdapter(sqlHang, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_themncc_Click(object sender, EventArgs e)
        {
            String duongDan = "Data Source=DOANHHUY\\SQLEXPRESS;Initial Catalog=SINHVIEN;Integrated Security=True";
            SqlConnection conn = new SqlConnection(duongDan);

            String sqlThem = "INSERT INTO NHACUNGCAP VALUES (" +
                             "'" + txt_mancc.Text + "', " +
                             "N'" + txt_tenncc.Text + "', " +
                             "N'" + txt_diachincc.Text + "', " +
                             "'" + txt_sdtncc.Text + "')";

            SqlCommand comm = new SqlCommand(sqlThem, conn);

            try
            {
                conn.Open();
                int ketQua = comm.ExecuteNonQuery();
                if (ketQua >= 1)
                {
                    MessageBox.Show("Thêm nhà cung cấp thành công");
                    // Gọi hàm để tải lại danh sách nhà cung cấp nếu có
                    // LoadNhacungcap();
                }
                else
                {
                    MessageBox.Show("Không có nhà cung cấp nào được thêm");
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

        private void QL_NCC_Load(object sender, EventArgs e)
        {
            LoadNCC();
        }

        private void btn_suancc_Click(object sender, EventArgs e)
        {
            String duongDan = "Data Source=DOANHHUY\\SQLEXPRESS;Initial Catalog=SINHVIEN;Integrated Security=True";
            SqlConnection conn = new SqlConnection(duongDan);

            String sqlSua = "UPDATE NHACUNGCAP SET " +
                            "nhacungcap = N'" + txt_tenncc.Text + "', " +
                            "diachi = N'" + txt_diachincc.Text + "', " +
                            "sdt = '" + txt_sdtncc.Text + "' " +
                            "WHERE ma_ncc = '" + txt_mancc.Text + "'";

            SqlCommand comm = new SqlCommand(sqlSua, conn);

            try
            {
                conn.Open();
                int ketQua = comm.ExecuteNonQuery();
                if (ketQua >= 1)
                {
                    MessageBox.Show("Cập nhật nhà cung cấp thành công");
                    // Gọi hàm để tải lại danh sách nhà cung cấp nếu có
                    // LoadNhacungcap();
                }
                else
                {
                    MessageBox.Show("Không có nhà cung cấp nào được cập nhật");
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

        private void btn_xoancc_Click(object sender, EventArgs e)
        {
            String duongDan = "Data Source=DOANHHUY\\SQLEXPRESS;Initial Catalog=SINHVIEN;Integrated Security=True";
            SqlConnection conn = new SqlConnection(duongDan);

            String sqlXoa = "DELETE FROM NHACUNGCAP WHERE ma_ncc = '" + txt_mancc.Text + "'";

            SqlCommand comm = new SqlCommand(sqlXoa, conn);

            try
            {
                conn.Open();
                int ketQua = comm.ExecuteNonQuery();
                if (ketQua >= 1)
                {
                    MessageBox.Show("Xóa nhà cung cấp thành công");
                    // Gọi hàm để tải lại danh sách nhà cung cấp nếu có
                    // LoadNhacungcap();
                }
                else
                {
                    MessageBox.Show("Không có nhà cung cấp nào được xóa");
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

        private void btn_loadncc_Click(object sender, EventArgs e)
        {
            LoadNCC();
        }

        private void btn_timncc_Click(object sender, EventArgs e)
        {
            String duongDan = "Data Source=DOANHHUY\\SQLEXPRESS;Initial Catalog=SINHVIEN;Integrated Security=True";
            SqlConnection conn = new SqlConnection(duongDan);
            String sqlSV = "select * from NHACUNGCAP " +
                "where ma_ncc like '%" + txt_timncc.Text + "%' or nhacungcap like N'%" + txt_timncc.Text + "%' ";
            SqlDataAdapter da = new SqlDataAdapter(sqlSV, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_mancc.Text = dataGridView1.CurrentRow.Cells["ma_ncc"].Value.ToString();
            txt_tenncc.Text = dataGridView1.CurrentRow.Cells["nhacungcap"].Value.ToString();
            txt_diachincc.Text = dataGridView1.CurrentRow.Cells["dia chi"].Value.ToString();
            txt_sdtncc.Text = dataGridView1.CurrentRow.Cells["sdt"].Value.ToString();
           
        }
    }
}
