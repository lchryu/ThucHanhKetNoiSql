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
namespace bai1
{
    public partial class Form1 : Form
    {
        //khởi tạo 2 biến cục bộ
        string strCon = @"Data Source=LCH;Initial Catalog=Test;Integrated Security=True";
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


                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "select * from QuanLyThuVien";
                sqlCmd.Connection = sqlCon;

                //thực thi
                SqlDataReader reader = sqlCmd.ExecuteReader();
                lsvDS.Items.Clear();
                while (reader.Read())
                {
                    string MaSach = reader.GetString(0);
                    string TieuDe = reader.GetString(1);
                    string Gia = reader.GetDouble(2).ToString();
                    double SoLuong = reader.GetInt32(3);

                    ListViewItem lvi = new ListViewItem(MaSach);
                    lvi.SubItems.Add(TieuDe);
                    lvi.SubItems.Add(Gia);
                    lvi.SubItems.Add(SoLuong.ToString());
                    lsvDS.Items.Add(lvi);
                }
                reader.Close();
                sqlCon.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Ko load đc danh sách", "Thông báo");
            }
        }

        private void lsvDS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDS.SelectedItems.Count > 0)
            {
                txtMaSach.Text = lsvDS.SelectedItems[0].SubItems[0].Text.Trim().ToString();
                txtTieuDe.Text = lsvDS.SelectedItems[0].SubItems[1].Text.Trim().ToString();
                txtGia.Text = lsvDS.SelectedItems[0].SubItems[2].Text.Trim().ToString();
                txtSoLuong.Text = lsvDS.SelectedItems[0].SubItems[3].Text.Trim().ToString();
                btnXoa.Enabled = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           DialogResult result = MessageBox.Show("Bạn có thực sự muốn xoá", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    //nếu null thì khởi tạo
                    if (sqlCon == null) sqlCon = new SqlConnection(strCon);
                    //nếu đóng thì mở
                    if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();

                    string maSach = lsvDS.SelectedItems[0].SubItems[0].Text.Trim().ToString();

                    string strSql = $"delete from QuanLyThuVien where maSach = '{maSach}'";
                    SqlCommand sqlCmd = new SqlCommand(strSql, sqlCon);

                    int res = sqlCmd.ExecuteNonQuery();
                    if (res > 0)
                        MessageBox.Show("xoá thành công!");
                    else
                        MessageBox.Show("xoá thất bại");
                    sqlCon.Close();
                    HienThiDanhSach();
                }
                catch (Exception)
                {

                    MessageBox.Show("Lỗi xảy ra");
                }
            }    
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaSach.Enabled = true;
            txtTieuDe.Enabled = true;
            txtSoLuong.Enabled = true;
            txtGia.Enabled = true;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //nếu null thì khởi tạo
            if (sqlCon == null) sqlCon = new SqlConnection(strCon);
            //nếu đóng thì mở
            if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();

            string maSach = txtGia.Text.Trim();
            string tieuDe = txtTieuDe.Text.Trim();
            int gia = Convert.ToInt32(txtGia.Text.Trim());
            int soLuong = Convert.ToInt32(txtSoLuong.Text.Trim());

            string strSql = $"insert into QuanLyThuVien values('{maSach}', N'{tieuDe}', N'{gia}', N'{soLuong}')";
            SqlCommand sqlCmd = new SqlCommand(strSql, sqlCon);

            int res = sqlCmd.ExecuteNonQuery();
            if (res > 0)
                MessageBox.Show("insert thành công!");
            else
                MessageBox.Show("insert thất bại");
            sqlCon.Close();

            btnThem.Enabled = true;
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            btnThem.Enabled=true;
            btnXoa.Enabled=true;

            txtGia.Enabled=false;
            txtMaSach.Enabled=false;
            txtSoLuong.Enabled=false;
            txtTieuDe.Enabled=false;
        }
    }
}
