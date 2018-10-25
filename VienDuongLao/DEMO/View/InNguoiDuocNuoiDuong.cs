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
    public partial class InNguoiDuocNuoiDuong : DevExpress.XtraEditors.XtraForm
    {
        public InNguoiDuocNuoiDuong()
        {
            InitializeComponent();
        }
        E_NguoiDuocNuoi nguoinuoi = new E_NguoiDuocNuoi();
        String trangthai = "";
        private void InNguoiDuocNuoiDuong_Load(object sender, EventArgs e)
        {
            nhomTacVu.Enabled = false;
            trangthai = "";
        }

        private void btnInToanBo_Click(object sender, EventArgs e)
        {
            gridNguoiDuocNuoi.DataSource = nguoinuoi.TKNguoiDuocNuoiToanBoNam();
            if (gridViewNguoiDuocNuoi.RowCount > 0)
            {
                XtraReport rp = new XtraReport();
                rp.DataSource = gridNguoiDuocNuoi.DataSource;
                rp.LoadLayout(Application.StartupPath + @"\ReportInNguoiDuocNuoiToanBo.repx");
                //rp.ShowDesignerDialog();
                rp.ShowPreviewDialog();
            }
            else
            {
                XtraMessageBox.Show("Không có dữ liệu để thống kê!");
            }
            InNguoiDuocNuoiDuong_Load(sender, e);
        }

        private void btnInLoc_Click(object sender, EventArgs e)
        { 
            txtTuoi.Enabled = btnIn.Enabled = false;
            nhomTacVu.Enabled = txtTuoi.Enabled = true;
        }

        private void btnLonHon_Click(object sender, EventArgs e)
        {
            trangthai = "<";
            btnIn.Enabled = true;
            if (!txtTuoi.Text.Equals(""))
            {
                gridNguoiDuocNuoi.DataSource = nguoinuoi.InNguoiDuocNuoiTuoiNhoHon(txtTuoi.Text.Trim(), trangthai);
            }
            else {
                XtraMessageBox.Show("Bạn cần nhập tuổi!");
            }
        }

        private void btnBangTuoi_Click(object sender, EventArgs e)
        {
            trangthai = "=";
            btnIn.Enabled = true;
            if (!txtTuoi.Text.Equals(""))
            {
                gridNguoiDuocNuoi.DataSource = nguoinuoi.InNguoiDuocNuoiTuoiNhoHon(txtTuoi.Text.Trim(), trangthai);
            }
            else
            {
                XtraMessageBox.Show("Bạn cần nhập tuổi!");
            }
        }

        private void btnNhoHon_Click(object sender, EventArgs e)
        {
            trangthai = ">";
            btnIn.Enabled = true;
            if (!txtTuoi.Text.Equals(""))
            {
                gridNguoiDuocNuoi.DataSource = nguoinuoi.InNguoiDuocNuoiTuoiNhoHon(txtTuoi.Text.Trim(), trangthai);
            }
            else
            {
                XtraMessageBox.Show("Bạn cần nhập tuổi!");
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (gridViewNguoiDuocNuoi.RowCount > 0)
            {
                XtraReport rp = new XtraReport();
                rp.DataSource = gridNguoiDuocNuoi.DataSource;

                rp.LoadLayout(Application.StartupPath + @"\ReportInNguoiDuocNuoiTheoTuoi.repx");
                //rp.ShowDesignerDialog();
                rp.ShowPreviewDialog();
            }
            else
            {
                XtraMessageBox.Show("Không có dữ liệu để thống kê!");
            }
            InNguoiDuocNuoiDuong_Load(sender, e);
        } 

    }
}