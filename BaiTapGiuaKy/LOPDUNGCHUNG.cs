using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BaiTapGiuaKy
{
    class LOPDUNGCHUNG
    {
        string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Winform\BaiTapGiuaKy\BaiTapGiuaKy\QLSACH.mdf;Integrated Security=True";
        SqlConnection conn;
        public LOPDUNGCHUNG()
        {
            conn = new SqlConnection(chuoiketnoi);
        }
        public void ThemXoaSua(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            int ketqua = comm.ExecuteNonQuery();
            conn.Close();
            if (ketqua >= 1) MessageBox.Show("Thành công");
            else MessageBox.Show("Thất bại");
        }
        public DataTable LoadDuLieu(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql,conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        } 
    }
}
