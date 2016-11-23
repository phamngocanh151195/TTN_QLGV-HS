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
        DataTable dt = new DataTable();
        ConnectDB CN = new ConnectDB();
        int dem = 0;
        public Frm_QLND()
        {
            InitializeComponent();
        }

        private void Frm_QLND_Load(object sender, EventArgs e)
        {
            dong();
            load();
        }

        void load()
        {
            dem = 0;
            DTGV.DataSource = CN.Get("Select * from tblLogin");
        }

        void dong()
        {
            txt_U.Enabled = txt_P.Enabled = btn_Luu.Enabled = txt_Quyen.Enabled = txt_Ten.Enabled = false;
        }
        void mo()
        {
            btn_Luu.Enabled = true;
            txt_P.Enabled = true;
            txt_U.Enabled = true;
            txt_Quyen.Enabled = true;
            txt_Ten.Enabled = true;
        }
        void themTK()
        {
            btn_Luu.Enabled = txt_P.Enabled = txt_U.Enabled = txt_Quyen.Enabled = true;
            string s = "insert into tblLogin values('" + txt_U.Text + "', '" + txt_P.Text + "', '" + txt_Quyen.Text + "', '" + txt_Ten.Text + "')";

            if (KT(txt_U.Text) == 0) dt = CN.Get(s);
            else MessageBox.Show("Tài khoản đã tồn tại!!");
            load();
        }

        void SuaTK()
        {
            btn_Luu.Enabled = txt_P.Enabled = txt_U.Enabled = txt_Quyen.Enabled = true;
            int r = DTGV.CurrentCell.RowIndex;
            string User = DTGV.Rows[r].Cells[0].Value.ToString();
            string s = "update tblLogin set Username = '" + txt_U.Text + "', Pass = '" + txt_P.Text + "', Uutien = '" + txt_Quyen.Text + "', name = N'" + txt_Ten.Text + "' where username = '" + User + "'";
            dt = CN.Get(s);
            load();
        }



        void TK_U()
        {
            dong();
            txt_P.Enabled = txt_U.Enabled = txt_Quyen.Enabled = txt_Ten.Enabled = true;
            string s = "Select * from tblLogin where username like N'%" + txt_U.Text + "%'";
            DTGV.DataSource = CN.Get(s);
            txt_U.Focus();
        }

        void TK_P()
        {
            dong();
            txt_P.Enabled = txt_U.Enabled = txt_Quyen.Enabled = txt_Ten.Enabled = true;
            string s = "Select * from tblLogin where pass like N'%" + txt_P.Text + "%'";

            DTGV.DataSource = CN.Get(s);
            txt_P.Focus();
        }

        void TK_Name()
        {
            dong();
            txt_P.Enabled = txt_U.Enabled = txt_Quyen.Enabled = txt_Ten.Enabled = true;
            string s = "Select * from tblLogin where name like N'%" + txt_Ten.Text + "%'";
            DTGV.DataSource = CN.Get(s);
            txt_Ten.Focus();
        }

        void TK_Q()
        {
            dong();
            txt_P.Enabled = txt_U.Enabled = txt_Quyen.Enabled = txt_Ten.Enabled = true;
            string s = "Select * from tblLogin where Uutien like N'%" + txt_Quyen.Text + "%'";
            DTGV.DataSource = CN.Get(s);
            txt_Quyen.Focus();
        }


        private void txt_Quyen_TextChanged(object sender, EventArgs e)
        {
            if (dem == 3) TK_Q();
        }

        int KT(string s)
        {
            dt = CN.Get("select count (*) from tblLogin where Username = '" + s + "'");
            return Convert.ToInt16(dt.Rows[0][0].ToString());
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            mo();
            dem = 1;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            mo();
            dem = 2;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dlrXoa;
            dlrXoa = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xóa Tài Liệu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlrXoa == DialogResult.OK)
            {
                int r = DTGV.CurrentCell.RowIndex;
                string User = DTGV.Rows[r].Cells[0].Value.ToString();
                string s = "delete tblLogin where username = '" + User + "'";
                dt = CN.Get(s);
                load();
            }
        }

        private void btn_RF_Click(object sender, EventArgs e)
        {
            txt_U.Text = txt_P.Text = txt_Ten.Text = txt_Quyen.Text = "";
            txt_U.Focus();
            load();
        }

        private void btn_Timkiem_Click(object sender, EventArgs e)
        {
            mo();
            txt_U.Text = txt_P.Text = txt_Ten.Text = txt_Quyen.Text = "";
            txt_U.Focus();
            dem = 3;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (dem == 1)
            {
                themTK();
            }
            if (dem == 2)
            {
                SuaTK();
            }
        }

        private void txt_U_TextChanged(object sender, EventArgs e)
        {
            if (dem == 3) TK_U();
        }

        private void txt_P_TextChanged(object sender, EventArgs e)
        {
            if (dem == 3) TK_P();
        }

        private void txt_Ten_TextChanged(object sender, EventArgs e)
        {
            if (dem == 3)
                TK_Name();
        }

        private void txt_Quyen_TextChanged_1(object sender, EventArgs e)
        {
            if (dem == 3) TK_Q();
        }

        private void DTGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_U.Text = DTGV.Rows[e.RowIndex].Cells["Username"].Value.ToString();
                txt_P.Text = DTGV.Rows[e.RowIndex].Cells["Pass"].Value.ToString();
                txt_Quyen.Text = DTGV.Rows[e.RowIndex].Cells["Uutien"].Value.ToString();
                txt_Ten.Text = DTGV.Rows[e.RowIndex].Cells["Column1"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex, "Thông báo");
            }
        }

        

    }
}
