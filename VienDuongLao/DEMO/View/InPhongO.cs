using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DEMO.Model;
using DevExpress.XtraReports.UI;

namespace DEMO.View
{
    public partial class InPhongO : DevExpress.XtraEditors.XtraForm
    {
        public InPhongO()
        {
            InitializeComponent();
        }
        String trangthai = "";
        E_PhongO phongo = new E_PhongO();
        private void InPhongO_Load(object sender, EventArgs e)
        {
            nhomTacVu.Enabled = false;
            trangthai = "";
        }

        private void btnInToanBo_Click(object sender, EventArgs e)
        {
            gridNguoiO.DataSource = phongo.InToanBoPhong();
            if (gridViewNguoiO.RowCount > 0)
            {
                XtraReport rp = new XtraReport();
                rp.DataSource = gridNguoiO.DataSource; ; ;
                rp.LoadLayout(Application.StartupPath + @"\ReportInPhongOToanBo.repx");
                //rp.ShowDesignerDialog();
                rp.ShowPreviewDialog();
            }
            else
            {
                XtraMessageBox.Show("Không có dữ liệu để thống kê!");
            }
            InPhongO_Load(sender, e);
        }

        private void btnInLoc_Click(object sender, EventArgs e)
        {
            nhomTacVu.Enabled = true;
            btnIn.Enabled = false;
        }

        private void btnLonHon_Click(object sender, EventArgs e)
        {
            if (!txtTuoi.Text.Equals(""))
            {
                trangthai = ">";
                gridNguoiO.DataSource = phongo.InTheoTuoiPhong(txtTuoi.Text.Trim(), trangthai);
                btnIn.Enabled = true;
            }
            else {
                XtraMessageBox.Show("Bạn cần nhập số tuổi!");
            }
           
        }

        private void btnBangTuoi_Click(object sender, EventArgs e)
        {
            if (!txtTuoi.Text.Equals(""))
            {
                trangthai = "=";
                gridNguoiO.DataSource = phongo.InTheoTuoiPhong(txtTuoi.Text.Trim(), trangthai);
                btnIn.Enabled = true;
            }
            else
            {
                XtraMessageBox.Show("Bạn cần nhập số tuổi!");
            }
        }

        private void btnNhoHon_Click(object sender, EventArgs e)
        {
            if (!txtTuoi.Text.Equals(""))
            {
                trangthai = "<";
                gridNguoiO.DataSource = phongo.InTheoTuoiPhong(txtTuoi.Text.Trim(), trangthai);
                btnIn.Enabled = true;
            }
            else
            {
                XtraMessageBox.Show("Bạn cần nhập số tuổi!");
            }
        }

        private void btnSoNguoi_Click(object sender, EventArgs e)
        {
            if (!txtSoNguoi.Text.Equals(""))
            {
                gridNguoiO.DataSource = phongo.InTheoSoNguoiPhong(txtSoNguoi.Text.Trim());
                btnIn.Enabled = true;
            }
            else
            {
                XtraMessageBox.Show("Bạn cần chọn số người!");
            }
           
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (gridViewNguoiO.RowCount > 0)
            {
                XtraReport rp = new XtraReport();
                rp.DataSource = gridNguoiO.DataSource; ; ;
                rp.LoadLayout(Application.StartupPath + @"\ReportInPhongOToanBo.repx");
                //rp.ShowDesignerDialog();
                rp.ShowPreviewDialog();
            }
            else
            {
                XtraMessageBox.Show("Không có dữ liệu để thống kê!");
            }
            InPhongO_Load(sender, e);
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            InPhongO_Load(sender, e);
        }
        
    }
}