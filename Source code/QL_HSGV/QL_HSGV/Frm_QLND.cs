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
    public partial class Frm_QLND : Form
    {
        ConnectDB CN = new ConnectDB();
        public Frm_QLND()
        {
            InitializeComponent();
        }

        private void Frm_QLND_Load(object sender, EventArgs e)
        {
            load();
        }

        void load()
        {
            DTGV.DataSource = CN.Get("Select * from tblLogin");
            dong();
        }

        void dong()
        {
            txt_U.Enabled = txt_P.Enabled = btn_Luu.Enabled = false;
        }
        void mo()
        {
            btn_Luu.Enabled = true;
            txt_P.Enabled = true;
            txt_U.Enabled = true;
        }
        void themTK()
        {
            btn_Luu.Enabled = txt_P.Enabled = txt_U.Enabled = true;
            string s = "insert into tblLogin values('" + txt_U.Text + "', '" + txt_P.Text + "')";
            DTGV.DataSource = CN.Get(s);
            load();
        }

        void SuaTK()
        {
            btn_Luu.Enabled = txt_P.Enabled = txt_U.Enabled = true;
            int r = DTGV.CurrentCell.RowIndex;
            string User = DTGV.Rows[r].Cells[0].Value.ToString();
            string s = "update tblLogin set Username = '" + txt_U.Text + "', Pass = '" + txt_P.Text + "' where username = '" + User + "'";
            DTGV.DataSource = CN.Get(s);
            load();
        }

        void XoaTK()
        {
            int r = DTGV.CurrentCell.RowIndex ;
            string User = DTGV.Rows[r].Cells[0].Value.ToString();
            string s = "delete tblLogin where username = '" + User + "'";
            DTGV.DataSource = CN.Get(s);
            load();
        }

        void TK()
        {
            txt_P.Enabled = txt_U.Enabled = true;
            string s = "Select * from tblLogin where username like N'%"+txt_U.Text+"%'";
            DTGV.DataSource = CN.Get(s);
        }
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if(RdB_Them.Checked == true)
            {
                themTK();
            }
            else
            {
                if(RdB_Sua.Checked == true)
                {
                    SuaTK();
                }
                else
                {
                    XoaTK();
                }
            }
        }

        private void txt_U_TextChanged(object sender, EventArgs e)
        {
            if (RdB_TK.Checked == true) TK();
        }

        private void RdB_TK_Click(object sender, EventArgs e)
        {
            btn_Luu.Enabled = false;
            txt_U.Enabled = txt_P.Enabled = true;
            txt_U.Text = txt_P.Text = "";
        }

        private void txt_P_TextChanged(object sender, EventArgs e)
        {
            if (RdB_TK.Checked == true) TK();
        }

        private void RdB_Them_Click(object sender, EventArgs e)
        {
            mo();
        }

        private void RdB_Sua_Click(object sender, EventArgs e)
        {
            mo();
        }

        private void RdB_Xoa_Click(object sender, EventArgs e)
        {
            mo();
        }


        private void DTGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_U.Text = DTGV.Rows[e.RowIndex].Cells["Username"].Value.ToString();
            txt_P.Text = DTGV.Rows[e.RowIndex].Cells["Pass"].Value.ToString();
        }



    }
}
