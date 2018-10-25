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
    public partial class InLichViengTham : DevExpress.XtraEditors.XtraForm
    {
        public InLichViengTham()
        {
            InitializeComponent();
        }
        String trangthai = "";
        E_LichViengTham viengtham = new E_LichViengTham();
        private void InLichViengTham_Load(object sender, EventArgs e)
        {
            nhomTacVu.Enabled = false;
            trangthai = "";
        }

        private void btnInToanBo_Click(object sender, EventArgs e)
        {
            gridLichViengTham.DataSource = viengtham.InToanBoLich();
            if (gridViewLichViengTham.RowCount > 0)
            {
                XtraReport rp = new XtraReport();
                rp.DataSource = gridLichViengTham.DataSource; ;
                rp.LoadLayout(Application.StartupPath + @"\ReportInLichViengThamToanBo.repx");
                //rp.ShowDesignerDialog();
                rp.ShowPreviewDialog();
            }
            else
            {
                XtraMessageBox.Show("Không có dữ liệu để thống kê!");
            }
            InLichViengTham_Load(sender, e);
        }

        private void btnSang_Click(object sender, EventArgs e)
        {
            trangthai = "Buổi sáng";
            btnIn.Enabled = true;
            gridLichViengTham.DataSource = viengtham.InLichTheoBuoi(trangthai);
        }

        private void btnChieu_Click(object sender, EventArgs e)
        {
            trangthai = "Buổi chiều";
            btnIn.Enabled = true;
            gridLichViengTham.DataSource = viengtham.InLichTheoBuoi(trangthai);
        }

        private void btnToi_Click(object sender, EventArgs e)
        {
            trangthai = "Buổi tối";
            btnIn.Enabled = true;
            gridLichViengTham.DataSource = viengtham.InLichTheoBuoi(trangthai);
        }

        private void btnInLoc_Click(object sender, EventArgs e)
        {
            nhomTacVu.Enabled = true;
            btnIn.Enabled = false;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (gridViewLichViengTham.RowCount > 0)
            {
                XtraReport rp = new XtraReport();
                rp.DataSource = gridLichViengTham.DataSource; ; 
                rp.LoadLayout(Application.StartupPath + @"\ReportInLichViengThamTheoTieuChi.repx");
                //rp.ShowDesignerDialog();
                rp.ShowPreviewDialog();
            }
            else
            {
                XtraMessageBox.Show("Không có dữ liệu để thống kê!");
            }
            InLichViengTham_Load(sender, e);
        }
    }
}