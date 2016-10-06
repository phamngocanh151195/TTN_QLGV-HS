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
    public partial class Frm_HS : Form
    {
        ConnectDB CN = new ConnectDB();
        public Frm_HS()
        {
            InitializeComponent();
        }

        private void Frm_HS_Load(object sender, EventArgs e)
        {
            DTGV.DataSource = CN.Get("Select * from tblHocSinh");
        }
    }
}
