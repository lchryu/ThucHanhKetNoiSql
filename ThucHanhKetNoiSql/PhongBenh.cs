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
namespace ThucHanhKetNoiSql
{
    public partial class PhongBenh : Form
    {

        ConnectDatabase connectDatabase = new ConnectDatabase();
        public PhongBenh()
        {
            InitializeComponent();
            loadCbx();
        }
        void loadCbx()
        {
            try
            {
                DataTable dataTable = connectDatabase.getData("select * from LoaiPhong");
                cbxLoaiPhongID.DataSource = dataTable;
                cbxLoaiPhongID.DisplayMember = "tenLoaiPhong";
                cbxLoaiPhongID.ValueMember = "ID";
            }
            catch (Exception)
            {
                MessageBox.Show("lỗi kết nối cbx");
            }
        }
        void showPhongBenh()
        {
            string sql = "select PhongBenh.ID, tenPhong,tenLoaiPhong, soGiuongToiDa, soGiuongHienTai,  moTa from phongBenh, LoaiPhong where LoaiPhong.ID = loaiPhongID";
            DataTable dataTable = connectDatabase.getData(sql);
            dgvPhongBenh.DataSource = dataTable;
            dgvPhongBenh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void PhongBenh_Load(object sender, EventArgs e)
        {
            showPhongBenh();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtId.Text;
                string tenPhong = txtTenPhong.Text;
                string soPhongHienTai = txtSoGiuongHienTai.Text;
                string soGiuongMax = txtSoGiuongMax.Text;
                string loaiPhongId = cbxLoaiPhongID.SelectedValue.ToString();
                string strsql = $"insert into PhongBenh values ({id}, '{tenPhong}', {soGiuongMax}, {soPhongHienTai}, 1, {loaiPhongId})";

                connectDatabase.updateData(strsql);
                showPhongBenh();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi insert!");
            }
        }

        private void dgvPhongBenh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string id = txtId.Text.Trim();
            string tenPhong = txtTenPhong.Text.Trim();
            string soPhongHienTai = txtSoGiuongHienTai.Text.Trim();
            string soGiuongMax = txtSoGiuongMax.Text.Trim();
            string loaiPhongId = cbxLoaiPhongID.SelectedValue.ToString().Trim();
            string strSql = $"update phongBenh set tenPhong = '{tenPhong}', soGiuongToiDa = { soGiuongMax },soGiuongHienTai = { soPhongHienTai }, benhVienID = 1, loaiPhongID = { loaiPhongId} where id = {id}";

            connectDatabase.updateData(strSql);
            showPhongBenh();

        }

        private void dgvPhongBenh_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtId.Text = dgvPhongBenh.CurrentRow.Cells[0].Value.ToString();
            txtTenPhong.Text = dgvPhongBenh.CurrentRow.Cells[1].Value.ToString();
            txtSoGiuongMax.Text = dgvPhongBenh.CurrentRow.Cells[3].Value.ToString();
            txtSoGiuongHienTai.Text = dgvPhongBenh.CurrentRow.Cells[4].Value.ToString();
            cbxLoaiPhongID.Text = dgvPhongBenh.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string id = txtId.Text.Trim();

            string strSql = $"delete from phongBenh where id = {id}";

            connectDatabase.updateData(strSql);
            showPhongBenh();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string id = txtId.Text.Trim();
            string tenPhong = txtTenPhong.Text.Trim();  
            string soGiuongMax = txtSoGiuongMax.Text.Trim();
            string soPhongHienTai = txtSoGiuongHienTai.Text.Trim();
            string loaiPhongID = cbxLoaiPhongID.SelectedValue.ToString();
            //MessageBox.Show(loaiPhongID);


        }

        private void btnLoadDGV_Click(object sender, EventArgs e)
        {
            showPhongBenh();
        }
    }

}
