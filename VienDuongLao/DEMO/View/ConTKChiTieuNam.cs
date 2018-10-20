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
    public partial class ConTKChiTieuNam : DevExpress.XtraEditors.XtraForm
    {
        public ConTKChiTieuNam()
        {
            InitializeComponent();
        }

        private void ConTKChiTieuNam_Load(object sender, EventArgs e)
        {
            btnNamToanBo.Enabled = btnNamTungNhom.Enabled = btnInKetQua.Enabled = false;
            btnTatCaNam.Enabled = btnTungNam.Enabled = true;
            trangthai = "";
        }
        E_NhapChiTieu phattu = new E_NhapChiTieu();
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

        private void btnNamToanBo_Click(object sender, EventArgs e)
        {
            btnInKetQua.Enabled = true;
            btnNamTungNhom.Enabled = false;
            if (trangthai.Equals("tatcanam"))
            {
                trangthai = "toanbotatcanam";
                gridTKChiTieu.DataSource = phattu.TKPhatTuTatCaNamToanBo();
            }
            if (trangthai.Equals("tungnam"))
            {
                trangthai = "toanbotungnam";
                gridTKChiTieu.DataSource = phattu.TKPhatTuTungNam(txtTuNam.Text.Trim(), txtDenNam.Text.Trim());
            }
        }

        private void btnInKetQua_Click(object sender, EventArgs e)
        {
            if (trangthai.Equals("toanbotatcanam"))
            {
                if (gridViewTKChiTieu.RowCount > 0)
                {
                    XtraReport rp = new XtraReport();
                    rp.DataSource = gridTKChiTieu.DataSource; 
                    rp.LoadLayout(Application.StartupPath + @"\ReportChiTieuToanBoNam.repx");
                    rp.ShowDesignerDialog();
                    rp.ShowPreviewDialog();
                }
                else
                {
                    XtraMessageBox.Show("Không có dữ liệu để thống kê!");
                }
            }
            if (trangthai.Equals("chianhomtatcanam"))
            {
                if (gridViewTKChiTieu.RowCount > 0)
                {
                    XtraReport rp = new XtraReport();
                    rp.DataSource = gridTKChiTieu.DataSource; 
                    rp.LoadLayout(Application.StartupPath + @"\ReportChiTieuToanBoNamTheoNhom.repx");
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
                if (gridViewTKChiTieu.RowCount > 0)
                {
                    XtraReport rp = new XtraReport();
                    rp.DataSource = gridTKChiTieu.DataSource; 
                    rp.LoadLayout(Application.StartupPath + @"\ReportChiTieuToanBoTungNam.repx");
                    rp.ShowDesignerDialog();
                    rp.ShowPreviewDialog();
                }
                else
                {
                    XtraMessageBox.Show("Không có dữ liệu để thống kê!");
                }
            }
            if (trangthai.Equals("chianhomtungnam"))
            {
                if (gridViewTKChiTieu.RowCount > 0)
                {
                    if (txtTuNam.Text.Equals(txtDenNam.Text))
                    {
                        XtraReport rp = new XtraReport();
                        rp.DataSource = phattu.TKPhatTuTungNamTheoThang(txtTuNam.Text.Trim()); 
                        rp.LoadLayout(Application.StartupPath + @"\ReportChiTieuMotNamTheoThang.repx");
                        rp.ShowDesignerDialog();
                        rp.ShowPreviewDialog();
                    }
                    else
                    {
                        XtraReport rp = new XtraReport();
                        rp.DataSource = gridTKChiTieu.DataSource; 
                        rp.LoadLayout(Application.StartupPath + @"\ReportChiTieuTungNamTheoNhom.repx");
                        rp.ShowDesignerDialog();
                        rp.ShowPreviewDialog();
                    }
                }
                else
                {
                    XtraMessageBox.Show("Không có dữ liệu để thống kê!");
                }
            }
            ConTKChiTieuNam_Load(sender, e);
        }

        private void btnNamTungNhom_Click(object sender, EventArgs e)
        {
            btnInKetQua.Enabled = true;
            btnNamToanBo.Enabled = false;
            if (trangthai.Equals("tatcanam"))
            {
                trangthai = "chianhomtatcanam";
                gridTKChiTieu.DataSource = phattu.TKPhatTuTatCaNamToanBo();
            }
            if (trangthai.Equals("tungnam"))
            {
                trangthai = "chianhomtungnam";
                gridTKChiTieu.DataSource = phattu.TKPhatTuTungNam(txtTuNam.Text.Trim(), txtDenNam.Text.Trim());
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            ConTKChiTieuNam_Load(sender, e);
        }
    }
}