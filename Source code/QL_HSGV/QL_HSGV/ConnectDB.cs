using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QL_HSGV
{
    class ConnectDB
    {
        public SqlConnection con = null;
        public void MoKN()
        {
            try
            {
                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=TruongTHPT;Integrated Security=True");
                con.Open();
            }
            catch
            {
                MessageBox.Show("Không khởi tạo được kết nối!");
            }
        }
        public void DongKN()
        {
            con.Close();
        }
        public DataTable Them(string HoTen, string TenMon, string TenLop)
        {
            string sql = "insert into tblTTGD(HoTen,TenMon,TenLop) values(N'" + HoTen + "',N'" + TenMon + "','" + TenLop + "')";
            MoKN();
            //if not exists(select HoTen,TenMon from tblTTGD where HoTen='" + HoTen + "' and TenMon='" + TenMon + "') 
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
            }
            catch
            {
                MessageBox.Show("Đã tồn tại nội dung!!!");
            }
            DongKN();
            return dt;
        }
        public DataTable Sua(string HoTen, string TenMon, string TenLop)
        {
            string sql = "update tblTTGD set TenLop=N'" + TenLop + "' where HoTen=N'" + HoTen + "' and TenMon=N'" + TenMon + "'";
            MoKN();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DongKN();
            return dt;
        }
        public DataTable Xoa(string HoTen, string TenMon, string TenLop)
        {
            string sql = "delete from tblTTGD where HoTen=N'" + HoTen + "' and TenMon=N'" + TenMon + "'";
            MoKN();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DongKN();
            return dt;
        }
        public DataTable Get(string sql)
        {
            MoKN();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DongKN();
            return dt;
        }
    }
}
