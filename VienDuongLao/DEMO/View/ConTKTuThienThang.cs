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
    public partial class ConTKTuThienThang : DevExpress.XtraEditors.XtraForm
    {
        public ConTKTuThienThang()
        {
            InitializeComponent();
        }
        E_TuThien phattu = new E_TuThien();
        String trangthai = "";
        private void ConTKTuThienThang_Load(object sender, EventArgs e)
        {
            btnMoiNgay.Enabled = btnTungNgay.Enabled = btnNhieuThang.Enabled = btnIn.Enabled = false;
            btnMotThang.Enabled = btnNhieuThang.Enabled = true;
            trangthai = "";
        }

        private void btnNhieuThang_Click(object sender, EventArgs e)
        {
            btnIn.Enabled = true;
            btnTungNgay.Enabled = btnMotThang.Enabled = false;
            trangthai = "toanbo";
            gridTKTuThien.DataSource = phattu.TKTuThienToanBoThang(txtNam.Text.Trim());
        }

        private void btnMotThang_Click(object sender, EventArgs e)
        {
            btnNhieuThang.Enabled = false;
            trangthai = "tungthang";
            btnTungNgay.Enabled = btnMoiNgay.Enabled = true;
            gridTKTuThien.DataSource = phattu.TKTuThienToanThang(txtThang.Text.Trim(), txtNam.Text.Trim());
        }

        private void btnMoiNgay_Click(object sender, EventArgs e)
        {
            trangthai = "toanbomotthang";
            btnIn.Enabled = true;
            btnTungNgay.Enabled = false;
        }

        private void btnTungNgay_Click(object sender, EventArgs e)
        {
            trangthai = "tungngaymotthang";
            btnIn.Enabled = true;
            btnMoiNgay.Enabled = false;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (trangthai.Equals("toanbo"))
            {
                if (gridViewTKTuThien.RowCount > 0)
                {
                    XtraReport rp = new XtraReport();
                    rp.DataSource = gridTKTuThien.DataSource;
                    rp.LoadLayout(Application.StartupPath + @"\ReportPhatTuTheoToanBoThang.repx");
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
                if (gridViewTKTuThien.RowCount > 0)
                {
                    XtraReport rp = new XtraReport();
                    rp.DataSource = gridTKTuThien.DataSource;
                    rp.LoadLayout(Application.StartupPath + @"\ReportTKTuThienToanBoMotThang.repx");
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
                if (gridViewTKTuThien.RowCount > 0)
                {
                    XtraReport rp = new XtraReport();
                    rp.DataSource = gridTKTuThien.DataSource;
                    rp.LoadLayout(Application.StartupPath + @"\ReportTKPhatTuTungNgayMotThang.repx");
                    //rp.ShowDesignerDialog();
                    rp.ShowPreviewDialog();
                }
                else
                {
                    XtraMessageBox.Show("Không có dữ liệu để in!");
                }
            }
            ConTKTuThienThang_Load(sender, e);
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            ConTKTuThienThang_Load(sender, e);
        }
    }
}