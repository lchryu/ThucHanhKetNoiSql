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
namespace QuanLySach
{

    public partial class Form1 : Form
    {
        string strCon = "Data Source=LCH;Initial Catalog=QLBANSACH;Integrated Security=True";
        SqlConnection sqlCon = null;
        double thanhTien = 0;
        public Form1()
        {
            InitializeComponent();
        }

        bool isSV()
        {
            return ckbSV.Checked;
        }
        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có thực sự muốn thoát không?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
                Application.Exit();
        }

        private void btnTongTien_Click(object sender, EventArgs e)
        {

            if (txtTenKH.Text.Trim() == "" || txtTenKH == null)
            {
                MessageBox.Show("Tên khách hàng không được phép rỗng", "Thông báo!");
                return;
            }
            if (txtSoLuongSach.Text.Trim() == "" || txtTenKH == null || Convert.ToInt32(txtSoLuongSach.Text.Trim()) < 0)
            {
                MessageBox.Show("Kiểm tra lại số lượng sách", "Thông báo!");
                return;
            }
            double tinhTien = Convert.ToDouble(txtSoLuongSach.Text) * 20000;
            thanhTien = ckbSV.Checked ? (tinhTien - (tinhTien * 5) / 100) : tinhTien;
            txtThanhTien.Text = thanhTien.ToString();


            try
            {
                if (sqlCon == null) sqlCon = new SqlConnection(strCon);
                if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();


                SqlCommand sqlCmd = new SqlCommand("select count(*) from kh", sqlCon);
                int stt = (int)sqlCmd.ExecuteScalar();
                string yesNo = ckbSV.Checked ? "YES" : "NO";
                string strSql = $"insert into KH values({stt + 1}, N'{txtTenKH.Text.Trim()}',{txtSoLuongSach.Text.Trim()}, '{yesNo}', {txtThanhTien.Text.Trim()})";

                SqlCommand sqlCmd2 = new SqlCommand(strSql, sqlCon);

                int res = sqlCmd2.ExecuteNonQuery();
                 if (res > 0) MessageBox.Show("insert thành công!");
                else
                {
                    MessageBox.Show("insert thất bại!");
                }
                sqlCon.Close();

            }
            catch (Exception )
            {
                MessageBox.Show("lỗi btn tính tổng tiền!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtTenKH.Text = "";
            txtThanhTien.Text = "";
            txtSoLuongSach.Text = "";
            ckbSV.Checked = false;
        }

        public void btnThongKe_Click(object sender, EventArgs e)
        {
            string strSql = "select COUNT(*) from KH";
            try
            {
                sqlCon = new SqlConnection(strCon);
                sqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand(strSql, sqlCon);
                int tongSoKH = (int)sqlCmd.ExecuteScalar();
              
                sqlCmd = new SqlCommand("select count(*) from KH where KhachHangLaSV = 'YES'", sqlCon);
                int tongSoKhLaSV = (int)sqlCmd.ExecuteScalar();

                sqlCmd = new SqlCommand("select SUM(ThanhTien) from KH", sqlCon);
                double tongDoanhThu = (double)sqlCmd.ExecuteScalar();


                txtTongSoKH.Text = tongSoKH.ToString();
                txtTongKhLaSV.Text = tongSoKhLaSV.ToString();
                txtTongDoanhThu.Text = tongDoanhThu.ToString();
                sqlCon.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi btnThongKe!");
            }
        }
    }
}
