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
    public partial class InchiTieuHangNgay : DevExpress.XtraEditors.XtraForm
    {
        public InchiTieuHangNgay()
        {
            InitializeComponent();
        }
        String trangthai = "";
        E_NhapChiTieu chitieu = new E_NhapChiTieu();
        private void InchiTieuHangNgay_Load(object sender, EventArgs e)
        {
            nhomTacVu.Enabled = false;
            trangthai = "";
        }

        private void btnInToanBo_Click(object sender, EventArgs e)
        {
            gridTienTuThien.DataSource = chitieu.AllDataChiTietNhapChiTieu();
            if (gridViewTienTuThien.RowCount > 0)
            {
                XtraReport rp = new XtraReport();
                rp.DataSource = gridTienTuThien.DataSource; 
                rp.LoadLayout(Application.StartupPath + @"\ReportInTienChiTieu.repx");
                //rp.ShowDesignerDialog();
                rp.ShowPreviewDialog();
            }
            else
            {
                XtraMessageBox.Show("Không có dữ liệu để in!");
            }
            InchiTieuHangNgay_Load(sender, e);
        }

        private void btnInLoc_Click(object sender, EventArgs e)
        {
            nhomTacVu.Enabled = true;
            btnIn.Enabled = false;
        }

        private void btnLonHon_Click(object sender, EventArgs e)
        {
            trangthai = ">"; 
            if (!txtTien.Text.Equals(""))
            {
                btnIn.Enabled = true;
                gridTienTuThien.DataSource = chitieu.InChiTieuTheoTien(txtTien.Text.Trim(), trangthai);
            }
            else
            {
                XtraMessageBox.Show("Bạn cần nhập tiền!");
            }
        }

        private void btnBangTien_Click(object sender, EventArgs e)
        {
            trangthai = "="; 
            if (!txtTien.Text.Equals(""))
            {
                btnIn.Enabled = true;
                gridTienTuThien.DataSource = chitieu.InChiTieuTheoTien(txtTien.Text.Trim(), trangthai);
            }
            else
            {
                XtraMessageBox.Show("Bạn cần nhập tiền!");
            }
        }

        private void btnNhoHon_Click(object sender, EventArgs e)
        {
            trangthai = "<"; 
            if (!txtTien.Text.Equals(""))
            {
                btnIn.Enabled = true;
                gridTienTuThien.DataSource = chitieu.InChiTieuTheoTien(txtTien.Text.Trim(), trangthai);
            }
            else
            {
                XtraMessageBox.Show("Bạn cần nhập tiền!");
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (gridViewTienTuThien.RowCount > 0)
            {
                XtraReport rp = new XtraReport();
                rp.DataSource = gridTienTuThien.DataSource;
                rp.LoadLayout(Application.StartupPath + @"\ReportInTienChiTieu.repx");
                //rp.ShowDesignerDialog();
                rp.ShowPreviewDialog();
            }
            else
            {
                XtraMessageBox.Show("Không có dữ liệu để in!");
            }
            InchiTieuHangNgay_Load(sender, e);
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            InchiTieuHangNgay_Load(sender, e);
        }
    }
}