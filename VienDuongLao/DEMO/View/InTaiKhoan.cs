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
    public partial class InTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public InTaiKhoan()
        {
            InitializeComponent();
        }

        private void InTaiKhoan_Load(object sender, EventArgs e)
        {
            nhomTacVu.Enabled = false;

        }
        E_DangNhap taikhoan = new E_DangNhap();
        String trangthai = "";
        private void btnInToanBo_Click(object sender, EventArgs e)
        {
            gridTaiKhoan.DataSource = taikhoan.InTaiKhoan();
            if (gridViewTaiKhoan.RowCount > 0)
            {
                XtraReport rp = new XtraReport();
                rp.DataSource = gridTaiKhoan.DataSource; 
                rp.LoadLayout(Application.StartupPath + @"\ReportTaiKhoanToanBo.repx");
                //rp.ShowDesignerDialog();
                rp.ShowPreviewDialog();
            }
            else
            {
                XtraMessageBox.Show("Không có dữ liệu để thống kê!");
            }
            InTaiKhoan_Load(sender, e);
        }

        private void btnInLoc_Click(object sender, EventArgs e)
        {
            nhomTacVu.Enabled = true;
            btnIn.Enabled = false;
        }

        private void btnQuyen_Click(object sender, EventArgs e)
        {
            if (!txtChucDanh.Text.Equals(""))
            {
                gridTaiKhoan.DataSource = taikhoan.InTaiKhoanTheoQuyen(txtChucDanh.Text.Trim());
                btnIn.Enabled = true;
            }
            else
            {
                XtraMessageBox.Show("Bạn cần nhập quyền!");
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (gridViewTaiKhoan.RowCount > 0)
            {
                XtraReport rp = new XtraReport();
                rp.DataSource = gridTaiKhoan.DataSource; 
                rp.LoadLayout(Application.StartupPath + @"\ReportTaiKhoanTheoQuyen.repx");
                //rp.ShowDesignerDialog();
                rp.ShowPreviewDialog();
            }
            else
            {
                XtraMessageBox.Show("Không có dữ liệu để thống kê!");
            }
            InTaiKhoan_Load(sender, e);
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            InTaiKhoan_Load(sender, e);
        }
    }
}