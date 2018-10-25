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
    public partial class InTienTuThien : DevExpress.XtraEditors.XtraForm
    {
        public InTienTuThien()
        {
            InitializeComponent();
        }
        String trangthai = "";
        E_TienTuThien tientuthien = new E_TienTuThien();
        private void InTienTuThien_Load(object sender, EventArgs e)
        {
            nhomTacVu.Enabled = false;
            trangthai = "";
        }

        private void btnInToanBo_Click(object sender, EventArgs e)
        {
            gridTienTuThien.DataSource = tientuthien.AllDataTienTuThien();
            if (gridViewTienTuThien.RowCount > 0)
            {
                XtraReport rp = new XtraReport();
                rp.DataSource = gridTienTuThien.DataSource; 
                rp.LoadLayout(Application.StartupPath + @"\ReportInTienTuThien.repx");
                //rp.ShowDesignerDialog();
                rp.ShowPreviewDialog();
            }
            else
            {
                XtraMessageBox.Show("Không có dữ liệu để in!");
            }
            InTienTuThien_Load(sender, e);
        }

        private void btnInLoc_Click(object sender, EventArgs e)
        {
            nhomTacVu.Enabled = true;
            btnIn.Enabled = false;
        }

        private void btnLonHon_Click(object sender, EventArgs e)
        {
            trangthai = ">";
            btnIn.Enabled = true;
            if (!txtTien.Text.Equals(""))
            {
                gridTienTuThien.DataSource = tientuthien.InTienTuThienTheoTien(txtTien.Text.Trim(), trangthai);
            }
            else
            {
                XtraMessageBox.Show("Bạn cần nhập tiền!");
            }
        }

        private void btnBangTien_Click(object sender, EventArgs e)
        {
            trangthai = "=";
            btnIn.Enabled = true;
            if (!txtTien.Text.Equals(""))
            {
                gridTienTuThien.DataSource = tientuthien.InTienTuThienTheoTien(txtTien.Text.Trim(), trangthai);
            }
            else
            {
                XtraMessageBox.Show("Bạn cần nhập tiền!");
            }
        }

        private void btnNhoHon_Click(object sender, EventArgs e)
        {
            trangthai = "<";
            btnIn.Enabled = true;
            if (!txtTien.Text.Equals(""))
            {
                gridTienTuThien.DataSource = tientuthien.InTienTuThienTheoTien(txtTien.Text.Trim(), trangthai);
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
                rp.LoadLayout(Application.StartupPath + @"\ReportInTienTuThien.repx");
                //rp.ShowDesignerDialog();
                rp.ShowPreviewDialog();
            }
            else
            {
                XtraMessageBox.Show("Không có dữ liệu để in!");
            }
            InTienTuThien_Load(sender, e);
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            InTienTuThien_Load(sender, e);
        }
    }
}