using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace ThucHanhKetNoiSql
{
    public class ConnectDatabase
    {
        string strCon = "Data Source=LCH;Initial Catalog=dbCovid;Integrated Security=True";
        SqlConnection sqlCon = null;
        SqlConnection getCon()
        {
            return new SqlConnection(strCon);
        }
        
        public DataTable getData(string strSql)
        {
            try
            {
                sqlCon = new SqlConnection(strCon);
                sqlCon.Open();
               
                SqlDataAdapter adapter = new SqlDataAdapter(strSql, sqlCon);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                sqlCon.Close();
                return dataTable;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi getData!");
                return null;
            }
        }

        public void updateData(string strsql)
        {
            try
            {
                sqlCon = new SqlConnection(strCon);
                sqlCon.Open();
           

                SqlCommand sqlCmd = new SqlCommand(strsql, sqlCon);

                int res = sqlCmd.ExecuteNonQuery();
                if (res > 0)
                {
                    MessageBox.Show("cập nhật thành công!");
                }
                else MessageBox.Show("cập nhật thất bại!");


                sqlCon.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi cập nhật trong class Connect database!");
            }
        }
    }
}
