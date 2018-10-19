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
    public partial class ConTKPhatTuNgay : DevExpress.XtraEditors.XtraForm
    {
        public ConTKPhatTuNgay()
        {
            InitializeComponent();
        }

        private void ConTKPhatTuNgay_Load(object sender, EventArgs e)
        {
            btnInKetQua.Enabled = false;
            btnMoiNgay.Enabled = btnTungNgay.Enabled = true;
            trangthai = "";
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            ConTKPhatTuNgay_Load(sender, e);
        }
        E_PhatTu phattu = new E_PhatTu();
        String trangthai = "";
        private void btnMoiNgay_Click(object sender, EventArgs e)
        {
            trangthai = "toanbo";
            btnInKetQua.Enabled = true;
            btnTungNgay.Enabled = false;
            gridTKPhatTu.DataSource = phattu.TKPhatTuToanBoNgay(txtTuNgay.Text.Trim(), txtDenNgay.Text.Trim());
        }

        private void btnTungNgay_Click(object sender, EventArgs e)
        {
            trangthai = "tungngay";
            btnInKetQua.Enabled = true;
            btnMoiNgay.Enabled = false;
            gridTKPhatTu.DataSource = phattu.TKPhatTuToanBoNgay(txtTuNgay.Text.Trim(), txtDenNgay.Text.Trim());
        }

        private void btnInKetQua_Click(object sender, EventArgs e)
        {
            if(trangthai.Equals("toanbo")){
                XtraReport rp = new XtraReport();
                rp.DataSource = gridTKPhatTu.DataSource;
                //rp.LoadLayout(Application.StartupPath + @"\ReportMauPhatTu.repx");
                rp.LoadLayout(Application.StartupPath + @"\ReportPhatTuTheoToanBoNgay.repx");
                //rp.ShowDesignerDialog();
                rp.ShowPreviewDialog();
            }
            if (trangthai.Equals("tungngay"))
            {
                XtraReport rp = new XtraReport();
                rp.DataSource = gridTKPhatTu.DataSource;
                //rp.LoadLayout(Application.StartupPath + @"\ReportMauPhatTu.repx");
                rp.LoadLayout(Application.StartupPath + @"\ReportMauPhatTuTheoTungNgay.repx");
                //rp.ShowDesignerDialog();
                rp.ShowPreviewDialog();
            }
            ConTKPhatTuNgay_Load(sender, e);
        }
    }
}