﻿using System;
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
        public Frm_ThongTinHS()
        {
            InitializeComponent();
        }
        public Frm_ThongTinHS(string masv)
        {
            InitializeComponent();
            maHS = masv;
        }

        private void Frm_ThongTinHS_Load(object sender, EventArgs e)
        {
            cboLop.DataSource = _con.Get(@"select malop,tenlop from tblLop");
            cboLop.ValueMember = "malop";
            cboLop.DisplayMember = "tenlop";
            
            DataTable data= _con.Get(@"select *from tblhocsinh a,tblLop b where a.malop=b.malop and mahs='"+maHS+"'");
            txtMaHS.Text = maHS;
            txtHoTen.Text = data.Rows[0]["HovaTen"].ToString();
            cboLop.Text = data.Rows[0]["tenlop"].ToString();
            cboGT.Text = data.Rows[0]["GT"].ToString();
            txtDiaChi.Text = data.Rows[0]["diachi"].ToString();
            txtQueQuan.Text = data.Rows[0]["quequan"].ToString();
            txtPhuHuynh.Text = data.Rows[0]["Phuhuynh"].ToString();
            txtNgaySinh.Text = data.Rows[0]["ngaysinh"].ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            _con.Sua_TTHS(txtMaHS.Text, txtHoTen.Text, cboLop.Text, cboGT.Text, txtDiaChi.Text, txtPhuHuynh.Text, txtQueQuan.Text, txtNgaySinh.Text);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
