using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DEMO.View;

namespace DEMO.View
{
    public partial class FormHienThi : DevExpress.XtraEditors.XtraForm
    {
        public FormHienThi()
        {
            InitializeComponent();
        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
            FormDangNhap f = new FormDangNhap();
            f.ShowDialog();
        }

        private void FormHienThi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}