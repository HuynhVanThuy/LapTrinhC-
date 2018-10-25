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
    public partial class InLichLamViec : DevExpress.XtraEditors.XtraForm
    {
        public InLichLamViec()
        {
            InitializeComponent();
        }
        E_LichLamViec lichlamviec = new E_LichLamViec();
        String trangthai = "";
        private void InLichLamViec_Load(object sender, EventArgs e)
        {
            nhomTacVu.Enabled = false;
            trangthai = "";
        }

        private void btnInToanBo_Click(object sender, EventArgs e)
        {
            gridLichLamViec.DataSource = lichlamviec.InToanBoLich();
            if (gridViewLichLamViec.RowCount > 0)
            {
                XtraReport rp = new XtraReport();
                rp.DataSource = gridLichLamViec.DataSource;
                rp.LoadLayout(Application.StartupPath + @"\ReportInLichLamViecToanBo.repx");
                //rp.ShowDesignerDialog();
                rp.ShowPreviewDialog();
            }
            else
            {
                XtraMessageBox.Show("Không có dữ liệu để in!");
            }
            InLichLamViec_Load(sender, e);
        }

        private void btnInLoc_Click(object sender, EventArgs e)
        {
            nhomTacVu.Enabled = true;
            btnIn.Enabled = false;
        }

        private void btnSang_Click(object sender, EventArgs e)
        {
            trangthai = "Buổi sáng";
            btnIn.Enabled = true;
            gridLichLamViec.DataSource = lichlamviec.InLichTheoBuoi(trangthai);
        }

        private void btnChieu_Click(object sender, EventArgs e)
        {
            trangthai = "Buổi chiều";
            btnIn.Enabled = true;
            gridLichLamViec.DataSource = lichlamviec.InLichTheoBuoi(trangthai);
        }

        private void btnToi_Click(object sender, EventArgs e)
        {
            trangthai = "Buổi tối";
            btnIn.Enabled = true;
            gridLichLamViec.DataSource = lichlamviec.InLichTheoBuoi(trangthai);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (gridViewLichLamViec.RowCount > 0)
            {
                XtraReport rp = new XtraReport();
                rp.DataSource = gridLichLamViec.DataSource; 
                rp.LoadLayout(Application.StartupPath + @"\ReportInLichLamViecTheoTieuChi.repx");
                //rp.ShowDesignerDialog();
                rp.ShowPreviewDialog();
            }
            else
            {
                XtraMessageBox.Show("Không có dữ liệu để in!");
            }
            InLichLamViec_Load(sender, e);
        }
    }
}