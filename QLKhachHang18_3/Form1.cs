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
namespace QLKhachHang18_3
{
    public partial class Form1 : Form
    {
        string strCon = @"Data Source=LCH;Initial Catalog=QLKhachHang;Integrated Security=True";

        SqlConnection sqlCon = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }

        void HienThiDanhSach()
        {
            try
            {
                //nếu null thì khởi tạo
                if (sqlCon == null) sqlCon = new SqlConnection(strCon);
                //nếu đóng thì mở
                if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();


                SqlCommand sqlCmd = new SqlCommand("select * from KhachHang", sqlCon);

                //thực thi
                SqlDataReader reader = sqlCmd.ExecuteReader();
                dgvDanhSach.Rows.Clear();
                int stt = 1;
                while (reader.Read())
                {
                    string ten = reader.GetString(1);
                    string gt = reader.GetString(2);
                    string loaiPhong = reader.GetString(3);
                    string soPhong = reader.GetInt32(4).ToString();

                    dgvDanhSach.Rows.Add(stt.ToString(), ten, gt, loaiPhong, soPhong);
                    stt++;
                }
                reader.Close();
                sqlCon.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ko load đc danh sách", "Thông báo");
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //try
            //{
                //nếu null thì khởi tạo
                if (sqlCon == null) sqlCon = new SqlConnection(strCon);
                //nếu đóng thì mở
                if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();
                string gt = rdNam.Checked ? "Nam" : "Nữ";
                //string strSql =
                //    $"update khachHang set Ten = N'{txtTenKhachHang.Text.Trim()}'" +
                //    $"GT = N'{gt}'," +
                //    $"LoaiPhong = N'{cbxLoaiPhong.Text}', " +
                //    $"SoPhongThue = {txtSoPhong.Text.Trim()}, " +
                //    $"where ten = N'{txtTenKhachHang.Text.Trim()}'";
                string ten = txtTenKhachHang.Text.Trim();
                string loaiPhong = cbxLoaiPhong.Text.Trim();
                string soPhongThue = txtSoPhong.Text.Trim();
                string strSql = $" update khachHang set Ten = N'{ten}',GT = N'{gt}',LoaiPhong = N'{loaiPhong}', SoPhongThue = {soPhongThue} where Ten = N'{ten}'";
                SqlCommand sqlCmd = new SqlCommand(strSql, sqlCon);
                int res = sqlCmd.ExecuteNonQuery();
                if (res > 0) MessageBox.Show("Update successful!");
                else MessageBox.Show("update failed!");
                HienThiDanhSach();
                sqlCon.Close();
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Lỗi update!");
            //}
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                //nếu null thì khởi tạo
                if (sqlCon == null) sqlCon = new SqlConnection(strCon);
                //nếu đóng thì mở
                if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand("select count(*) from khachhang", sqlCon);
                int soLuong = (int)sqlCmd.ExecuteScalar();
                //MessageBox.Show(soLuong.ToString());

                string gt = rdNam.Checked ? "Nam" : "Nữ";

                string makh = (soLuong + 1).ToString();
                string ten = txtTenKhachHang.Text.Trim();
                string loaiPhong = cbxLoaiPhong.Text;
                string soPhongThue = txtSoPhong.Text;
                string strSql = $"insert into KhachHang values('{makh}', N'{ten}', N'{gt}', N'{loaiPhong}', {soPhongThue})";
                sqlCmd = new SqlCommand(strSql, sqlCon);
                int res = sqlCmd.ExecuteNonQuery();
                {
                    if (res > 0) MessageBox.Show("insert thành công");
                    else MessageBox.Show("insert thất bại");
                }
                HienThiDanhSach();
                sqlCon.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi insert");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn xoá", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    //nếu null thì khởi tạo
                    if (sqlCon == null) sqlCon = new SqlConnection(strCon);
                    //nếu đóng thì mở
                    if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();

                    string tenKh = dgvDanhSach.CurrentRow.Cells[1].Value.ToString();

                    string strSql = $"delete from KhachHang where ten = N'{tenKh}'";
                    SqlCommand sqlCmd = new SqlCommand(strSql, sqlCon);

                    int res = sqlCmd.ExecuteNonQuery();
                    if (res > 0)
                        MessageBox.Show("xoá thành công!");
                    else
                        MessageBox.Show("xoá thất bại");
                    sqlCon.Close();
                    HienThiDanhSach();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Lỗi xảy ra: " + ex.ToString());
                }
            }
            txtTenKhachHang.Text = String.Empty;
            txtSoPhong.Text = String.Empty;
            txtSoPhong.Text = string.Empty;
            cbxLoaiPhong.Text = string.Empty;
        }

        private void txtTenKhachHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon == null) sqlCon = new SqlConnection(strCon);
                //nếu đóng thì mở
                if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();

                string strSql = $"Select count(*) from KhachHang where ten like N'%{txtTenTimKiem.Text.Trim()}%'";
                SqlCommand sqlCmd = new SqlCommand(strSql, sqlCon);
                int res = (int)sqlCmd.ExecuteScalar();
                if (res > 0) MessageBox.Show("Tìm thấy " + res + " bản ghi!");
                else MessageBox.Show("Không tìm thấy bản ghi nào!");
                sqlCon.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi tìm kiếm");
            }

        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvDanhSach.Rows[e.RowIndex];
                txtTenKhachHang.Text = row.Cells[1].Value.ToString();
                if (row.Cells[2].Value.ToString() == "Nam")
                    rdNam.Checked = true;
                else
                    rdNu.Checked = false;
                cbxLoaiPhong.Text = row.Cells[3].Value.ToString();
                txtSoPhong.Text = row.Cells[4].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng chọn ô có dữ liệu");
            }
        }
    }
}
