using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_HSGV
{
    public partial class Frm_DangNhap : Form
    {
        public Frm_DangNhap()
        {
            InitializeComponent();
        }

        private void Frm_DangNhap_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btn_DN;
        }

        private void btn_DN_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.QueriesTableAdapter q = new DataSet1TableAdapters.QueriesTableAdapter();
            if(txtU.Text==""||txtP.Text=="")
            {
                this.label.Text = "Thông tin đăng nhập sai!";
                txtU.Focus();
            }
            if (q.CheckLogin(this.txtU.Text, this.txtP.Text) == 1)
            {
                this.Hide();
                FrmMain M = new FrmMain();
                M.Show();
            }
            else
            {
                this.label.Text = "Thông tin đăng nhập sai!";
            }
        }

        private void btn_RF_Click(object sender, EventArgs e)
        {
            txtU.Clear();
            txtP.Clear();
            txtU.Focus();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
