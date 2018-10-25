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
    public partial class ConTKTienTuThienThang : DevExpress.XtraEditors.XtraForm
    {
        public ConTKTienTuThienThang()
        {
            InitializeComponent();
        }

        private void ConTKTienTuThienThang_Load(object sender, EventArgs e)
        {
            btnMoiNgay.Enabled = btnTungNgay.Enabled = btnNhieuThang.Enabled = btnIn.Enabled = false;
            btnMotThang.Enabled = btnNhieuThang.Enabled = true;
            trangthai = "";
        }
        E_TienTuThien phattu = new E_TienTuThien();
        String trangthai = "";
        private void btnIn_Click(object sender, EventArgs e)
        {
            if (trangthai.Equals("toanbo"))
            {
                if (gridViewTKTienTuThien.RowCount > 0)
                {
                    XtraReport rp = new XtraReport();
                    rp.DataSource = gridTKTienTuThien.DataSource;
                    rp.LoadLayout(Application.StartupPath + @"\ReportTKTienTuThienToanBoThang.repx");
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
                if (gridViewTKTienTuThien.RowCount > 0)
                {
                    XtraReport rp = new XtraReport();
                    rp.DataSource = gridTKTienTuThien.DataSource;
                    rp.LoadLayout(Application.StartupPath + @"\ReportTKTienTuThienToanBoMotThang.repx");
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
                if (gridViewTKTienTuThien.RowCount > 0)
                {
                    XtraReport rp = new XtraReport();
                    rp.DataSource = gridTKTienTuThien.DataSource;
                    rp.LoadLayout(Application.StartupPath + @"\ReportTKTienTuThienTungNgayMotThang.repx");
                    rp.ShowDesignerDialog();
                    rp.ShowPreviewDialog();
                }
                else
                {
                    XtraMessageBox.Show("Không có dữ liệu để in!");
                }
            }
            ConTKTienTuThienThang_Load(sender, e);
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
            gridTKTienTuThien.DataSource = phattu.TKTienTuThienToanThang(txtThang.Text.Trim(), txtNam.Text.Trim());
        }

        private void btnTungNgay_Click(object sender, EventArgs e)
        {
            trangthai = "tungngaymotthang";
            btnIn.Enabled = true;
            btnMoiNgay.Enabled = false;
            gridTKTienTuThien.DataSource = phattu.TKTienTuThienToanThang(txtThang.Text.Trim(), txtNam.Text.Trim());
        }

        private void btnNhieuThang_Click(object sender, EventArgs e)
        {
            btnIn.Enabled = true;
            btnTungNgay.Enabled = btnMotThang.Enabled = false;
            trangthai = "toanbo";
            gridTKTienTuThien.DataSource = phattu.TKTienTuThienToanBoThang(txtNam.Text.Trim());
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            ConTKTienTuThienThang_Load(sender, e);
        }
    }
}