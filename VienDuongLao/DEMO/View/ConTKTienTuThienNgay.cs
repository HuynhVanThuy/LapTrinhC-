using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using DEMO.Execute;

namespace DEMO.View
{
    public partial class ConTKTienTuThienNgay : DevExpress.XtraEditors.XtraForm
    {
        public ConTKTienTuThienNgay()
        {
            InitializeComponent();
        }

        private void ConTKTienTuThienNgay_Load(object sender, EventArgs e)
        {
            btnInKetQua.Enabled = false;
            btnMoiNgay.Enabled = btnTungNgay.Enabled = true;
            trangthai = "";
        }

        private void btnInKetQua_Click(object sender, EventArgs e)
        {
            if (trangthai.Equals("toanbo"))
            {
                if (gridViewTienTuThien.RowCount > 0)
                {
                    XtraReport rp = new XtraReport();
                    rp.DataSource = gridTKTienTuThien.DataSource; 
                    rp.LoadLayout(Application.StartupPath + @"\ReportTienTuThienTheoToanBoNgay.repx");
                    //rp.ShowDesignerDialog();
                    rp.ShowPreviewDialog();
                }
                else
                {
                    XtraMessageBox.Show("Không có dữ liệu thống kê!");
                }
            }
            if (trangthai.Equals("tungngay"))
            {
                if (gridViewTienTuThien.RowCount > 0)
                {
                    XtraReport rp = new XtraReport();
                    rp.DataSource = gridTKTienTuThien.DataSource;
                    rp.LoadLayout(Application.StartupPath + @"\ReportMauPhatTuTheoTungNgay.repx");
                    //rp.ShowDesignerDialog();
                    rp.ShowPreviewDialog();
                }
                else
                {
                    XtraMessageBox.Show("Không có dữ liệu thống kê!");
                }
            }
            ConTKTienTuThienNgay_Load(sender, e);
        }
        E_TienTuThien phattu = new E_TienTuThien();
        String trangthai = "";
        private void btnMoiNgay_Click(object sender, EventArgs e)
        {
            trangthai = "toanbo";
            btnInKetQua.Enabled = true;
            btnTungNgay.Enabled = false;
            gridTKTienTuThien.DataSource = phattu.TKTienTuThienToanBoNgay(txtTuNgay.Text.Trim(), txtDenNgay.Text.Trim());
        }

        private void btnTungNgay_Click(object sender, EventArgs e)
        {
            trangthai = "tungngay";
            btnInKetQua.Enabled = true;
            btnMoiNgay.Enabled = false;
            gridTKTienTuThien.DataSource = phattu.TKTienTuThienToanBoNgay(txtTuNgay.Text.Trim(), txtDenNgay.Text.Trim());
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            ConTKTienTuThienNgay_Load(sender, e);
        }
    }
}