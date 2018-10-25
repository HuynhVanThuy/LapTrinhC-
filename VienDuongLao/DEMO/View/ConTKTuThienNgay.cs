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
    public partial class ConTKTuThienNgay : DevExpress.XtraEditors.XtraForm
    {
        public ConTKTuThienNgay()
        {
            InitializeComponent();
        }

        private void ConTKTuThienNgay_Load(object sender, EventArgs e)
        {
            btnInKetQua.Enabled = false;
            btnMoiNgay.Enabled = btnTungNgay.Enabled = true;
            trangthai = "";
        }
        String trangthai = "";
        E_TuThien tuthien = new E_TuThien();
        private void btnMoiNgay_Click(object sender, EventArgs e)
        {
            trangthai = "toanbo";
            btnInKetQua.Enabled = true;
            btnTungNgay.Enabled = false;
            gridTKDoanTuThien.DataSource = tuthien.TKTuThienToanBoNgay(txtTuNgay.Text.Trim(), txtDenNgay.Text.Trim());
        }

        private void btnTungNgay_Click(object sender, EventArgs e)
        {
            trangthai = "tungngay";
            btnInKetQua.Enabled = true;
            btnMoiNgay.Enabled = false;
            gridTKDoanTuThien.DataSource = tuthien.TKTuThienToanBoNgay(txtTuNgay.Text.Trim(), txtDenNgay.Text.Trim());
        }

        private void btnInKetQua_Click(object sender, EventArgs e)
        {
            if (trangthai.Equals("toanbo"))
            {
                XtraReport rp = new XtraReport();
                rp.DataSource = gridTKDoanTuThien.DataSource;
                //rp.LoadLayout(Application.StartupPath + @"\ReportMauToChucTuThien.repx");
                rp.LoadLayout(Application.StartupPath + @"\ReportTCTuThienTheoToanBoNgay.repx");
                //rp.ShowDesignerDialog();
                rp.ShowPreviewDialog();
            }
            if (trangthai.Equals("tungngay"))
            {
                XtraReport rp = new XtraReport();
                rp.DataSource = gridTKDoanTuThien.DataSource;
                rp.LoadLayout(Application.StartupPath + @"\ReportTCTuThienTheoTungNgay.repx");
                //rp.ShowDesignerDialog();
                rp.ShowPreviewDialog();
            }
            ConTKTuThienNgay_Load(sender, e);
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            ConTKTuThienNgay_Load(sender, e);
        }
    }
}