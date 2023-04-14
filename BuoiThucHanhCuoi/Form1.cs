﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuoiThucHanhCuoi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                DataRow row = testDataSet.QuanLySinhVien.NewRow();
                row["MaSV"] = txtMaSV.Text.Trim();
                row["HoTen"] = txtHoTen.Text.Trim();
                //rdNam.Checked == true ? row["DvTinh"] = "Nam" : row["DvTinh"] = "Nữ";
                if (rdNam.Checked == true)
                {
                    row["GioiTinh"] = "Nam";
                }
                else
                {
                    row["GioiTinh"] = "Nữ";
                }
                row["NoiSinh"] = cbxNoiSinh.Text.ToString();
                row["NgaySinh"] = dtpNgaySinh.Text.Trim();
                testDataSet.QuanLySinhVien.Rows.Add(row);

                int kq = quanLySinhVienTableAdapter.Update(testDataSet.QuanLySinhVien);
                if (kq > 0) MessageBox.Show("insert thành công!");
                else MessageBox.Show("insert thất bại!");
            }
            catch (Exception)
            {
                MessageBox.Show("Execption thêm dữ liệu!", "Thông báo!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDataSet.QuanLySinhVien' table. You can move, or remove it, as needed.
            this.quanLySinhVienTableAdapter.Fill(this.testDataSet.QuanLySinhVien);
            dgvQLSV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        int vt = -1;
        private void dgvQLSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt != -1)
            {
                txtMaSV.Text = dgvQLSV.Rows[vt].Cells[0].Value.ToString().Trim();
                txtHoTen.Text = dgvQLSV.Rows[vt].Cells[1].Value.ToString().Trim();
                cbxNoiSinh.Text = dgvQLSV.Rows[vt].Cells[3].Value.ToString().Trim();
                if (dgvQLSV.Rows[vt].Cells[4].Value.ToString() == "Nam")
                {
                    rdNam.Checked = true;
                }
                else
                    rdNu.Checked = true;
                dtpNgaySinh.Text = dgvQLSV.Rows[vt].Cells[2].Value.ToString().Trim();
            }
        }

        private void cbxNoiSinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            //đưa ra messagebox về 

        }

        private void button2_Click(object sender, EventArgs e)
        {

            DataRow row = testDataSet.QuanLySinhVien.Rows[vt];
            row.BeginEdit();

            row["MaSV"] = txtMaSV.Text.Trim();
            row["HoTen"] = txtHoTen.Text.Trim();

            if (rdNam.Checked == true)  row["GioiTinh"] = "Nam";
            else    row["GioiTinh"] = "Nữ";

            row["NoiSinh"] = cbxNoiSinh.Text.ToString();
            row["NgaySinh"] = dtpNgaySinh.Text;


            row.EndEdit();

            int kq = quanLySinhVienTableAdapter.Update(testDataSet.QuanLySinhVien);
            DialogResult dr = kq > 0 ? MessageBox.Show("Chỉnh sửa dữ liệu thành công!", "Thông báo") : MessageBox.Show("Chỉnh sửa dữ liệu thất bại!", "Thông báo!");

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void b_Click(object sender, EventArgs e)
        {

        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void a_Click(object sender, EventArgs e)
        {

        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dgvQLSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void rdNu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdNam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void quanLySinhVienBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
