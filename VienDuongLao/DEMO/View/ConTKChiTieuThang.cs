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
    public partial class ConTKChiTieuThang : DevExpress.XtraEditors.XtraForm
    {
        public ConTKChiTieuThang()
        {
            InitializeComponent();
        }

        private void ConTKChiTieuThang_Load(object sender, EventArgs e)
        {
            btnMoiNgay.Enabled = btnTungNgay.Enabled = btnNhieuThang.Enabled = btnIn.Enabled = false;
            btnMotThang.Enabled = btnNhieuThang.Enabled = true;
            trangthai = "";
        }
        E_NhapChiTieu phattu = new E_NhapChiTieu();
        String trangthai = "";
        private void btnNhieuThang_Click(object sender, EventArgs e)
        {
            btnIn.Enabled = true;
            btnTungNgay.Enabled = btnMotThang.Enabled = false;
            trangthai = "toanbo";
            gridTKChiTieu.DataSource = phattu.TKChiTieuToanBoThang(txtNam.Text.Trim());
        }

        private void btnMotThang_Click(object sender, EventArgs e)
        {
            btnNhieuThang.Enabled = false;
            trangthai = "tungthang";
            btnTungNgay.Enabled = btnMoiNgay.Enabled = true; 
        }

        private void btnMoiNgay_Click(object sender, EventArgs e)
        {
            trangthai = "toanbomotthang";
            btnIn.Enabled = true;
            btnTungNgay.Enabled = false;
            gridTKChiTieu.DataSource = phattu.TKChiTieuToanThang(txtThang.Text.Trim(), txtNam.Text.Trim());
        }

        private void btnTungNgay_Click(object sender, EventArgs e)
        {
            trangthai = "tungngaymotthang";
            btnIn.Enabled = true;
            btnMoiNgay.Enabled = false;
            gridTKChiTieu.DataSource = phattu.TKChiTieuToanThang(txtThang.Text.Trim(), txtNam.Text.Trim());
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (trangthai.Equals("toanbo"))
            {
                if (gridViewTKChiTieu.RowCount > 0)
                {
                    XtraReport rp = new XtraReport();
                    rp.DataSource = gridTKChiTieu.DataSource; 
                    rp.LoadLayout(Application.StartupPath + @"\ReportTKChiTietToanBoThang.repx");
                    //rp.ShowDesignerDialog();
                    rp.ShowPreviewDialog();
                }
                else
                {
                    XtraMessageBox.Show("Không có dữ liệu để in!");
                }
            }
            if (trangthai.Equals("toanbomotthang"))
            {
                if (gridViewTKChiTieu.RowCount > 0)
                {
                    XtraReport rp = new XtraReport();
                    rp.DataSource = gridTKChiTieu.DataSource;
                    rp.LoadLayout(Application.StartupPath + @"\ReportTKChiTieuToanBoMotThang.repx");
                    //rp.ShowDesignerDialog();
                    rp.ShowPreviewDialog();
                }
                else
                {
                    XtraMessageBox.Show("Không có dữ liệu để in!");
                }
            }
            if (trangthai.Equals("tungngaymotthang"))
            {
                if (gridViewTKChiTieu.RowCount > 0)
                {
                    XtraReport rp = new XtraReport();
                    rp.DataSource = gridTKChiTieu.DataSource;
                    rp.LoadLayout(Application.StartupPath + @"\ReportTKChiTietTungNgayMotThang.repx");
                    //rp.ShowDesignerDialog();
                    rp.ShowPreviewDialog();
                }
                else
                {
                    XtraMessageBox.Show("Không có dữ liệu để in!");
                }
            }
            ConTKChiTieuThang_Load(sender, e);
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            ConTKChiTieuThang_Load(sender, e);
        }
    }
}