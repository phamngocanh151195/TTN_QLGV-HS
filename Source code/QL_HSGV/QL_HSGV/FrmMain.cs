﻿using System;
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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void TStrip_HS_Click(object sender, EventArgs e)
        {
            Frm_HS HS = new Frm_HS();
            HS.ShowDialog();
        }

        private void TStrip_GV_Click(object sender, EventArgs e)
        {
            Frm_GV GV = new Frm_GV();
            GV.ShowDialog();
        }

        private void TStrip_TTGD_Click(object sender, EventArgs e)
        {
            Frm_TTGD TTGD = new Frm_TTGD();
            TTGD.ShowDialog();
        }

        private void TStrip_QLND_Click(object sender, EventArgs e)
        {
            Frm_QLND QLND = new Frm_QLND();
            QLND.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
