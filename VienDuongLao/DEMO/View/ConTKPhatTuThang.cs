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
    public partial class ConTKPhatTuThang : DevExpress.XtraEditors.XtraForm
    {
        public ConTKPhatTuThang()
        {
            InitializeComponent();
        }

        private void ConTKPhatTuThang_Load(object sender, EventArgs e)
        {
            btnMoiNgay.Enabled =btnTungNgay.Enabled= btnNhieuThang.Enabled = btnIn.Enabled = false;
            btnMotThang.Enabled = btnNhieuThang.Enabled = true;
            trangthai = "";
        }
        E_PhatTu phattu = new E_PhatTu();
        String trangthai = "";
        private void btnNhieuThang_Click(object sender, EventArgs e)
        {
            btnIn.Enabled = true;
            btnTungNgay.Enabled =btnMotThang.Enabled= false;
            trangthai = "toanbo";
            gridTKPhatTu.DataSource = phattu.TKPhatTuToanBoThang(txtNam.Text.Trim());
        }

        private void btnMotThang_Click(object sender, EventArgs e)
        {
            btnNhieuThang.Enabled = false;
            trangthai = "tungthang";
            btnTungNgay.Enabled = btnMoiNgay.Enabled = true;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (trangthai.Equals("toanbo"))
            {
                if (gridViewTKPhatTu.RowCount > 0)
                {
                    XtraReport rp = new XtraReport();
                    rp.DataSource = gridTKPhatTu.DataSource; 
                    rp.LoadLayout(Application.StartupPath + @"\ReportTKPhatTuToanBoThang.repx");
                    //rp.ShowDesignerDialog();
                    rp.ShowPreviewDialog();
                }
                else {
                    XtraMessageBox.Show("Không có dữ liệu để in!");
                }
            }
            if (trangthai.Equals("toanbomotthang"))
            {
                if (gridViewTKPhatTu.RowCount > 0)
                {
                    XtraReport rp = new XtraReport();
                    rp.DataSource = gridTKPhatTu.DataSource; 
                    rp.LoadLayout(Application.StartupPath + @"\ReportTKPhatTuToanBoThang.repx");
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
                if (gridViewTKPhatTu.RowCount > 0)
                {
                    XtraReport rp = new XtraReport();
                    rp.DataSource = gridTKPhatTu.DataSource; 
                    rp.LoadLayout(Application.StartupPath + @"\ReportTKPhatTuTungNgayMotThang.repx");
                    //rp.ShowDesignerDialog();
                    rp.ShowPreviewDialog();
                }
                else
                {
                    XtraMessageBox.Show("Không có dữ liệu để in!");
                }
            }
            ConTKPhatTuThang_Load(sender, e);
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            ConTKPhatTuThang_Load(sender, e);
        }
        
        private void btnMoiNgay_Click(object sender, EventArgs e)
        {
            trangthai = "toanbomotthang";
            btnIn.Enabled = true;
            btnTungNgay.Enabled = false;
            gridTKPhatTu.DataSource = phattu.TKPhatTuToanThang(txtThang.Text.Trim(), txtNam.Text.Trim());
        }

        private void btnTungNgay_Click(object sender, EventArgs e)
        {
            trangthai = "tungngaymotthang";
            btnIn.Enabled = true;
            btnMoiNgay.Enabled = false;
            gridTKPhatTu.DataSource = phattu.TKPhatTuToanThang(txtThang.Text.Trim(), txtNam.Text.Trim());
        }
    }
}