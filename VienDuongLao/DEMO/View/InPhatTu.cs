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
    public partial class InPhatTu : DevExpress.XtraEditors.XtraForm
    {
        public InPhatTu()
        {
            InitializeComponent();
        }
        E_PhatTu phattu = new E_PhatTu();
        String trangthai = "";
        private void InPhatTu_Load(object sender, EventArgs e)
        {
            nhomTacVu.Enabled = false;
            trangthai = "";
        }

        private void btnInToanBo_Click(object sender, EventArgs e)
        {
            gridPhatTu.DataSource = phattu.AllDataPhatTu();
            if (gridViewPhatTu.RowCount > 0)
            {
                XtraReport rp = new XtraReport();
                rp.DataSource = gridPhatTu.DataSource;
                rp.LoadLayout(Application.StartupPath + @"\ReportInPhatTuToanBo.repx");
                //rp.ShowDesignerDialog();
                rp.ShowPreviewDialog();
            }
            else
            {
                XtraMessageBox.Show("Không có dữ liệu để thống kê!");
            }
            InPhatTu_Load(sender, e);
        }

        private void btnInLoc_Click(object sender, EventArgs e)
        {
            nhomTacVu.Enabled = txtTuoi.Enabled = txtChucDanh.Enabled = true;
            btnIn.Enabled = false;
        }

        private void btnLonHon_Click(object sender, EventArgs e)
        {
            trangthai = ">";
            btnIn.Enabled = true;
            if (!txtTuoi.Text.Equals(""))
            {
                gridPhatTu.DataSource = phattu.InPhatTuTheoTuoi(txtTuoi.Text.Trim(), trangthai);
            }
            else
            {
                XtraMessageBox.Show("Bạn cần nhập tuổi!");
            }
        }

        private void btnBangTuoi_Click(object sender, EventArgs e)
        {
            trangthai = "=";
            btnIn.Enabled = true;
            if (!txtTuoi.Text.Equals(""))
            {
                gridPhatTu.DataSource = phattu.InPhatTuTheoTuoi(txtTuoi.Text.Trim(), trangthai);
            }
            else
            {
                XtraMessageBox.Show("Bạn cần nhập tuổi!");
            }
        }

        private void btnNhoHon_Click(object sender, EventArgs e)
        {
            trangthai = "<";
            btnIn.Enabled = true;
            if (!txtTuoi.Text.Equals(""))
            {
                gridPhatTu.DataSource = phattu.InPhatTuTheoTuoi(txtTuoi.Text.Trim(), trangthai);
            }
            else
            {
                XtraMessageBox.Show("Bạn cần nhập tuổi!");
            }
        }

        private void btnChucDanh_Click(object sender, EventArgs e)
        { 
            btnIn.Enabled = true;
            if (!txtChucDanh.Text.Equals(""))
            {
                gridPhatTu.DataSource = phattu.InPhatTuTheoChucDanh(txtChucDanh.Text.Trim());
            }
            else
            {
                XtraMessageBox.Show("Bạn cần chọn chức danh!");
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (gridViewPhatTu.RowCount > 0)
            {
                XtraReport rp = new XtraReport();
                rp.DataSource = gridPhatTu.DataSource;
                rp.LoadLayout(Application.StartupPath + @"\ReportInPhatTuTheoTieuChi.repx");
                //rp.ShowDesignerDialog();
                rp.ShowPreviewDialog();
            }
            else
            {
                XtraMessageBox.Show("Không có dữ liệu để thống kê!");
            }
            InPhatTu_Load(sender, e);
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            InPhatTu_Load(sender,e);
        }
    }
}