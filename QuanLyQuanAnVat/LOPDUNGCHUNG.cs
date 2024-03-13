using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAnVat
{
    internal class LOPDUNGCHUNG
    {
        string chuoiketnoi = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\Learn - Practice\\CodeAppAtSchool\\QuanLyQuanAnVat\\QuanLyQuanAnVat\\Quanlyanvat_database.mdf\";Integrated Security=True";
        SqlConnection conn;

        public LOPDUNGCHUNG()
        {
            conn = new SqlConnection(chuoiketnoi);
        }

        public int ThemXoaSua(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            int kq = comm.ExecuteNonQuery();
            conn.Close();
            return kq;
        }

        public DataTable LoadDuLieu(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public object LayDulieu(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            object kq = comm.ExecuteScalar();
            conn.Close();
            return kq;
        }
    }
}
