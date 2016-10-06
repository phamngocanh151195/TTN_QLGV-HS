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
    public partial class Frm_GV : Form
    {
        ConnectDB CN = new ConnectDB();
        public Frm_GV()
        {
            InitializeComponent();
        }

        private void Frm_GV_Load(object sender, EventArgs e)
        {
            DTGV_GV.DataSource = CN.Get("Select * from tblGiaovien");
        }
    }
}
