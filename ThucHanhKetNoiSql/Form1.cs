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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            string strCon = "Data Source=LCH;Initial Catalog=dbCovid;Integrated Security=True";
            SqlConnection sqlCon = new SqlConnection(strCon);
            try
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("select * from loaiPhong", sqlCon);
                SqlDataReader reader = sqlCmd.ExecuteReader();
                dataGridView1.Rows.Clear();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string id = reader.GetInt32(0).ToString();
                        string tenLoaiPhong = reader.GetString(1);
                        string moTa = reader["moTa"].ToString();
                        dataGridView1.Rows.Add(id, tenLoaiPhong, moTa);
                    }
                }
                else
                {
                    MessageBox.Show("Bảng không có dòng nào", "Thông báo");
                }
                reader.Close();
                sqlCon.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("lỗi kết nối");
            }
        }

        private void btnKetNoiAdapter_Click(object sender, EventArgs e)
        {
            string strCon = "Data Source=LCH;Initial Catalog=dbCovid;Integrated Security=True";
            SqlConnection sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            string sql = "select id as 'Mã', tenLoaiPhong as 'Tên', moTa as 'Mô tả' from LoaiPhong";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlCon);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = dataTable;
            sqlCon.Close();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string strCon = "Data Source=LCH;Initial Catalog=dbCovid;Integrated Security=True";
            SqlConnection sqlCon = new SqlConnection(strCon);
            sqlCon.Open();

            int id = Convert.ToInt32(txtID.Text.ToString());
            string tenLoaiPhong = txtTenLoaiPhong.Text.ToString();
            string moTa = txtMoTa.Text.ToString();

            string strSql = $"insert into LoaiPhong values ({id}, N'{tenLoaiPhong}', N'{moTa}')";
            SqlCommand sqlCmd = new SqlCommand(strSql, sqlCon);


            int res = sqlCmd.ExecuteNonQuery();
            if (res > 0)
                MessageBox.Show("insert thành công!");
            else
                MessageBox.Show("insert thất bại");
            sqlCon.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
