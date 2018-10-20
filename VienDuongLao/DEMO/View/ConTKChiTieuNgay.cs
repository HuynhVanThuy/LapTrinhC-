using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DEMO.Execute;
using DevExpress.XtraReports.UI;

namespace DEMO.View
{
    public partial class ConTKChiTieuNgay : DevExpress.XtraEditors.XtraForm
    {
        public ConTKChiTieuNgay()
        {
            InitializeComponent();
        }
        E_NhapChiTieu phattu = new E_NhapChiTieu();
        String trangthai = "";
        private void ConTKChiTieuNgay_Load(object sender, EventArgs e)
        {
            btnInKetQua.Enabled = false;
            btnMoiNgay.Enabled = btnTungNgay.Enabled = true;
            trangthai = "";
        }

        private void btnMoiNgay_Click(object sender, EventArgs e)
        {
            trangthai = "toanbo";
            btnInKetQua.Enabled = true;
            btnTungNgay.Enabled = false;
            gridTKChiTieu.DataSource = phattu.TKChiTieuToanBoNgay(txtTuNgay.Text.Trim(), txtDenNgay.Text.Trim());
        }

        private void btnTungNgay_Click(object sender, EventArgs e)
        {
            trangthai = "tungngay";
            btnInKetQua.Enabled = true;
            btnMoiNgay.Enabled = false;
            gridTKChiTieu.DataSource = phattu.TKChiTieuToanBoNgay(txtTuNgay.Text.Trim(), txtDenNgay.Text.Trim());
        }

        private void btnInKetQua_Click(object sender, EventArgs e)
        {
            if (trangthai.Equals("toanbo"))
            {
                XtraReport rp = new XtraReport();
                rp.DataSource = gridTKChiTieu.DataSource;
                rp.LoadLayout(Application.StartupPath + @"\ReportChiTieuTheoToanBoNgay.repx");
                //rp.ShowDesignerDialog();
                rp.ShowPreviewDialog();
            }
            if (trangthai.Equals("tungngay"))
            {
                XtraReport rp = new XtraReport();
                rp.DataSource = gridTKChiTieu.DataSource;
                rp.LoadLayout(Application.StartupPath + @"\ReportChiTieuTheoTungNgay.repx");
                //rp.ShowDesignerDialog();
                rp.ShowPreviewDialog();
            }
            ConTKChiTieuNgay_Load(sender, e);
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            ConTKChiTieuNgay_Load(sender, e);
        }
    }
}