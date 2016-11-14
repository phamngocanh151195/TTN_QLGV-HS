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
namespace QL_HSGV
{
    public partial class Frm_ThongTinHS : Form
    {
        ConnectDB _con = new ConnectDB();
        string maHS;
        public int kt=0;
        public Frm_ThongTinHS()
        {
            InitializeComponent();
        }
        public Frm_ThongTinHS(string masv)
        {
            InitializeComponent();
            maHS = masv;
        }
        public Frm_ThongTinHS(int k)
        {
            InitializeComponent();
            kt = k;
            lbTittle.Text = "Thêm Học Sinh mới";
            btnLuu.Text = "Thêm Mới";
            txtMaHS.Enabled = true;
        }
       
        private void Frm_ThongTinHS_Load(object sender, EventArgs e)
        {
            if (kt <= 0)
            {
                cboLop.DataSource = _con.Get(@"select malop,tenlop from tblLop");
                cboLop.ValueMember = "malop";
                cboLop.DisplayMember = "tenlop";

                DataTable data = _con.Get(@"select *from tblhocsinh a,tblLop b where a.malop=b.malop and mahs='" + maHS + "'");
                txtMaHS.Text = maHS;
                txtHoTen.Text = data.Rows[0]["HovaTen"].ToString();
                cboLop.Text = data.Rows[0]["tenlop"].ToString();
                cboGT.Text = data.Rows[0]["GT"].ToString();
                txtDiaChi.Text = data.Rows[0]["diachi"].ToString();
                txtQueQuan.Text = data.Rows[0]["quequan"].ToString();
                txtPhuHuynh.Text = data.Rows[0]["Phuhuynh"].ToString();
                txtNgaySinh.Text = data.Rows[0]["ngaysinh"].ToString();
                if (kt == -2) btnLuu.Enabled = false;
            }
            else
            {
                txtMaHS.Text = Ma_TuDongTang();
            }
        }

        public string Ma_TuDongTang()
        {
            DataTable dt = new DataTable();
            dt = _con.Get(@"select * from tblHocSinh");
            string ma = "";
            int so = 0, i = 1000;
            for (int j = 1; j <= dt.Rows.Count - 1; j++)
            {
                ma = Convert.ToString(dt.Rows[j - 1][0].ToString());
                ma = ma.Remove(0, 2);
                so = Convert.ToInt32(ma);
                if (so != j) { so = j - 1; i = 0; break; }
            }
            if (i != 0)
            {
                ma = Convert.ToString(dt.Rows[dt.Rows.Count - 1][0].ToString());
                ma = ma.Remove(0, 2);
                so = Convert.ToInt32(ma);
            }

            ma = "HS";
            so += 1;
            if (so < 10)
                ma = ma + "0000000";
            else if (so < 100)
                ma = ma + "000000";
            else if (so < 1000)
                ma = ma + "00000";
            else if (so < 10000)
                ma = ma + "0000";
            else if (so < 100000)
                ma = ma + "000";
            else if (so < 1000000)
                ma = ma + "00";
            else if (so < 10000000)
                ma = ma + "0";
            ma = ma + so.ToString();
            return ma;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
           if(kt<=0) _con.Sua_TTHS(txtMaHS.Text, txtHoTen.Text, cboLop.Text, cboGT.Text, txtDiaChi.Text, txtPhuHuynh.Text, txtQueQuan.Text, txtNgaySinh.Text);
           else _con.ThemHS(txtMaHS.Text, txtHoTen.Text, cboLop.Text, cboGT.Text, txtDiaChi.Text, txtPhuHuynh.Text, txtQueQuan.Text, txtNgaySinh.Text);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
