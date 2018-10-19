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
    public partial class ConTKPhatTuNam : DevExpress.XtraEditors.XtraForm
    {
        public ConTKPhatTuNam()
        {
            InitializeComponent();
        }

        private void ConTKPhatTuNam_Load(object sender, EventArgs e)
        {
            btnNamToanBo.Enabled = btnNamTungNhom.Enabled = btnInKetQua.Enabled = false;
            btnTatCaNam.Enabled = btnTungNam.Enabled = true;
            trangthai = "";
        }
        E_PhatTu phattu = new E_PhatTu();
        String trangthai = "";
        private void btnTatCaNam_Click(object sender, EventArgs e)
        {
            btnTungNam.Enabled = false;
            btnNamToanBo.Enabled = btnNamTungNhom.Enabled = true;
            trangthai = "tatcanam";
        }

        private void btnTungNam_Click(object sender, EventArgs e)
        {
            btnTatCaNam.Enabled = false;
            btnNamToanBo.Enabled = btnNamTungNhom.Enabled = true;
            trangthai = "tungnam";
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            ConTKPhatTuNam_Load(sender, e);
        }

        private void btnNamToanBo_Click(object sender, EventArgs e)
        {
            btnInKetQua.Enabled = true;
            btnNamTungNhom.Enabled = false;
            if (trangthai.Equals("tatcanam"))
            {
                trangthai = "toanbotatcanam";
                gridTKNguoiO.DataSource = phattu.TKPhatTuTatCaNamToanBo();
            }
            if (trangthai.Equals("tungnam"))
            {
                trangthai = "toanbotungnam";
                gridTKNguoiO.DataSource = phattu.TKPhatTuTungNam(txtTuNam.Text.Trim(), txtDenNam.Text.Trim());
            }
        }

        private void btnNamTungNhom_Click(object sender, EventArgs e)
        {
            btnInKetQua.Enabled = true;
            btnNamToanBo.Enabled = false;
            if (trangthai.Equals("tatcanam"))
            {
                trangthai = "chianhomtatcanam";
                gridTKNguoiO.DataSource = phattu.TKPhatTuTatCaNamToanBo();
            }
            if (trangthai.Equals("tungnam"))
            {
                trangthai = "chianhomtungnam";
                gridTKNguoiO.DataSource = phattu.TKPhatTuTungNam(txtTuNam.Text.Trim(), txtDenNam.Text.Trim());
            }
        }

        private void btnInKetQua_Click(object sender, EventArgs e)
        {
            if (trangthai.Equals("toanbotatcanam"))
            {
                if (gridViewTKNguoiO.RowCount > 0)
                {
                    XtraReport rp = new XtraReport();
                    rp.DataSource = gridTKNguoiO.DataSource;
                    //rp.LoadLayout(Application.StartupPath + @"\ReportMauPhatTu.repx");
                    rp.LoadLayout(Application.StartupPath + @"\ReportPhatTuToanBoNam.repx");
                    //rp.ShowDesignerDialog();
                    rp.ShowPreviewDialog();
                }
                else {
                    XtraMessageBox.Show("Không có dữ liệu để thống kê!");
                }
            }
            if (trangthai.Equals("chianhomtatcanam"))
            {
                if (gridViewTKNguoiO.RowCount > 0)
                {
                    XtraReport rp = new XtraReport();
                    rp.DataSource = gridTKNguoiO.DataSource;
                    //rp.LoadLayout(Application.StartupPath + @"\ReportMauPhatTu.repx");
                    rp.LoadLayout(Application.StartupPath + @"\ReportPhatTuToanBoNamTheoNhom.repx");
                    //rp.ShowDesignerDialog();
                    rp.ShowPreviewDialog();
                }
                else
                {
                    XtraMessageBox.Show("Không có dữ liệu để thống kê!");
                }
            }
            if (trangthai.Equals("toanbotungnam"))
            {
                if (gridViewTKNguoiO.RowCount > 0)
                {
                    XtraReport rp = new XtraReport();
                    rp.DataSource = gridTKNguoiO.DataSource;
                    //rp.LoadLayout(Application.StartupPath + @"\ReportMauPhatTu.repx");
                    rp.LoadLayout(Application.StartupPath + @"\ReportPhatTuToanBoTungNam.repx");
                    //rp.ShowDesignerDialog();
                    rp.ShowPreviewDialog();
                }
                else
                {
                    XtraMessageBox.Show("Không có dữ liệu để thống kê!");
                }
            }
            if (trangthai.Equals("chianhomtungnam"))
            {
                if (gridViewTKNguoiO.RowCount > 0)
                {
                    if (txtTuNam.Text.Equals(txtDenNam.Text))
                    {
                        XtraReport rp = new XtraReport();
                        rp.DataSource = phattu.TKPhatTuTungNamTheoThang(txtTuNam.Text.Trim());
                        //rp.LoadLayout(Application.StartupPath + @"\ReportMauPhatTu.repx");
                        rp.LoadLayout(Application.StartupPath + @"\ReportPhatTuMotNamTheoThang.repx");
                        //rp.ShowDesignerDialog();
                        rp.ShowPreviewDialog();
                    }
                    else {
                        XtraReport rp = new XtraReport();
                        rp.DataSource = gridTKNguoiO.DataSource;
                        //rp.LoadLayout(Application.StartupPath + @"\ReportMauPhatTu.repx");
                        rp.LoadLayout(Application.StartupPath + @"\ReportPhatTuTungNamTheoNhom.repx");
                        //rp.ShowDesignerDialog();
                        rp.ShowPreviewDialog();
                    }
                }
                else
                {
                    XtraMessageBox.Show("Không có dữ liệu để thống kê!");
                }
            }
        }


    }
}