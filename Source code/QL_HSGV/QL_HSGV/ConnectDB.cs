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
        public void Sua_TTHS(string mahs,string ten,string lop, string gt,string diachi,string phuhuynh, string quequan,string ngaysinh)
        {
            MoKN();
            SqlCommand cmd = new SqlCommand("Sua_TTHS", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@mahs", mahs));
            cmd.Parameters.Add(new SqlParameter("@hodem", ten));
            cmd.Parameters.Add(new SqlParameter("@gt", gt));
            cmd.Parameters.Add(new SqlParameter("@ngaysinh", DateTime.Parse( ngaysinh)));
            cmd.Parameters.Add(new SqlParameter("@diachi", diachi));
            cmd.Parameters.Add(new SqlParameter("@quequan", quequan));
            cmd.Parameters.Add(new SqlParameter("@phuhuynh", phuhuynh));
            cmd.Parameters.Add(new SqlParameter("@lop", lop));
            try
            {
                int count = cmd.ExecuteNonQuery();
                if (count > 0) MessageBox.Show("Sửa thành công!", "Thông báo");
                else MessageBox.Show("Sửa không thành công!", "Thông báo");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Sửa không thành công!\n Lỗi: "+ex.ToString(), "Thông báo");
            }
            DongKN();
        }
        //hàm thực thi câu lệnh sql
        public void Excecute(string sql)
        {
            try
            {
                MoKN();
                SqlCommand cmd = new SqlCommand(sql, con);
                int count;
                count=cmd.ExecuteNonQuery();
                if(count>0)
                {
                    MessageBox.Show("Xóa Thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Xóa không Thành công", "Thông báo");
                }
                DongKN();
            }
            catch
            {
                MessageBox.Show("Xóa không thành công, Lỗi truy vấn!");
            }
            return;
        }
    }
}
