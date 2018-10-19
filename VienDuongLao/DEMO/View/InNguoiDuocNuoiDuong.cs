using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DEMO.View
{
    public partial class InNguoiDuocNuoiDuong : DevExpress.XtraEditors.XtraForm
    {
        public InNguoiDuocNuoiDuong()
        {
            InitializeComponent();
        }

        private void InNguoiDuocNuoiDuong_Load(object sender, EventArgs e)
        {
            nhomTacVu.Enabled = false;
        }

        private void btnInLoc_Click(object sender, EventArgs e)
        {
            nhomTacVu.Enabled = true;
            btnInLoc.Enabled = btnInToanBo.Enabled = false;
            txtDenNgay.Enabled = txtNam.Enabled = txtThang.Enabled = txtTuNgay.Enabled = false;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            btnInLoc.Enabled = btnInToanBo.Enabled = true;
            nhomTacVu.Enabled = false;
        }

        private void btnNgay_Click(object sender, EventArgs e)
        {
            txtNam.Enabled = false;
            txtThang.Enabled = false;
            txtTuNgay.Enabled = txtDenNgay.Enabled = true;
        }

        private void btnThang_Click(object sender, EventArgs e)
        {
            txtThang.Enabled = true;
            txtNam.Enabled = false;
            txtTuNgay.Enabled = txtDenNgay.Enabled = false;
        }

        private void btnNam_Click(object sender, EventArgs e)
        {
            txtNam.Enabled = true;
            txtThang.Enabled = false;
            txtTuNgay.Enabled = txtDenNgay.Enabled = false;
        }
    }
}