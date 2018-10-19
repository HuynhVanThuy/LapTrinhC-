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
    public partial class ConTKNguoiONgay : DevExpress.XtraEditors.XtraForm
    {
        public ConTKNguoiONgay()
        {
            InitializeComponent();
        }

        private void btnInKetQua_Click(object sender, EventArgs e)
        {
            btnMoiNgay.Enabled = btnTungNgay.Enabled = true;
        }
        E_NguoiDuocNuoi nguoiduocnuoi = new E_NguoiDuocNuoi();
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            gridTKNguoiDuocNuoi.DataSource = nguoiduocnuoi.TKNguoiDuocNuoi(txtTuNgay.Text.Trim(), txtDenNgay.Text.Trim());
            btnInKetQua.Enabled = true;
        }

        private void btnMoiNgay_Click(object sender, EventArgs e)
        {
            if (gridViewTKNguoiDuocNuoi.RowCount > 0)
            {
                XtraReport rp = new XtraReport();
                rp.DataSource = gridTKNguoiDuocNuoi.DataSource;
                rp.LoadLayout(Application.StartupPath + @"\ReportTKNguoiNuoiAll.repx");
                //rp.ShowDesignerDialog();
                rp.ShowPreviewDialog();

            }
            else XtraMessageBox.Show("Không có dữ liệu để in", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            ConTKNguoiONgay_Load(sender, e);
        }

        private void btnTungNgay_Click(object sender, EventArgs e)
        {
            if (gridViewTKNguoiDuocNuoi.RowCount > 0)
            {
                XtraReport rp = new XtraReport();
                rp.DataSource = gridTKNguoiDuocNuoi.DataSource;
                rp.LoadLayout(Application.StartupPath + @"\ReportTKNguoiNuoiTungNgay.repx");
                //rp.ShowDesignerDialog();
                rp.ShowPreviewDialog();

            }
            else XtraMessageBox.Show("Không có dữ liệu để in", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            ConTKNguoiONgay_Load(sender, e);
        }

        private void ConTKNguoiONgay_Load(object sender, EventArgs e)
        {
            btnInKetQua.Enabled = btnMoiNgay.Enabled = btnTungNgay.Enabled = false;
        }
    }
}