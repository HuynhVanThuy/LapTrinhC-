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
    public partial class ConTKTienTuThienNam : DevExpress.XtraEditors.XtraForm
    {
        public ConTKTienTuThienNam()
        {
            InitializeComponent();
        }
        E_TienTuThien tuthien = new E_TienTuThien();
        String trangthai = "";
        private void ConTKTienTuThienNam_Load(object sender, EventArgs e)
        {
            btnNamToanBo.Enabled = btnNamTungNhom.Enabled = btnInKetQua.Enabled = false;
            btnTatCaNam.Enabled = btnTungNam.Enabled = true;
            trangthai = "";
        }

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
                gridTKTienTuThien.DataSource = tuthien.TKTienTuThienTatCaNamToanBo();
            }
            if (trangthai.Equals("tungnam"))
            {
                trangthai = "toanbotungnam";
                gridTKTienTuThien.DataSource = tuthien.TKTienTuThienTungNam(txtTuNam.Text.Trim(), txtDenNam.Text.Trim());
            }
        }

        private void btnNamTungNhom_Click(object sender, EventArgs e)
        {
            btnInKetQua.Enabled = true;
            btnNamToanBo.Enabled = false;
            if (trangthai.Equals("tatcanam"))
            {
                trangthai = "chianhomtatcanam";
                gridTKTienTuThien.DataSource = tuthien.TKTienTuThienTatCaNamToanBo();
            }
            if (trangthai.Equals("tungnam"))
            {
                trangthai = "chianhomtungnam";
                gridTKTienTuThien.DataSource = tuthien.TKTienTuThienTungNam(txtTuNam.Text.Trim(), txtDenNam.Text.Trim());
            }
        }

        private void btnInKetQua_Click(object sender, EventArgs e)
        {
            if (trangthai.Equals("toanbotatcanam"))
            {
                if (gridViewTKTienTuThien.RowCount > 0)
                {
                    XtraReport rp = new XtraReport();
                    rp.DataSource = gridTKTienTuThien.DataSource;
                    rp.LoadLayout(Application.StartupPath + @"\ReportTienTuThienToanBoNam.repx");
                    //rp.ShowDesignerDialog();
                    rp.ShowPreviewDialog();
                }
                else
                {
                    XtraMessageBox.Show("Không có dữ liệu để thống kê!");
                }
            }
            if (trangthai.Equals("chianhomtatcanam"))
            {
                if (gridViewTKTienTuThien.RowCount > 0)
                {
                    XtraReport rp = new XtraReport();
                    rp.DataSource = gridTKTienTuThien.DataSource;
                    rp.LoadLayout(Application.StartupPath + @"\ReportTienTuThienToanBoNamTheoNhom.repx");
                    rp.ShowDesignerDialog();
                    rp.ShowPreviewDialog();
                }
                else
                {
                    XtraMessageBox.Show("Không có dữ liệu để thống kê!");
                }
            }
            if (trangthai.Equals("toanbotungnam"))
            {
                if (gridViewTKTienTuThien.RowCount > 0)
                {
                    XtraReport rp = new XtraReport();
                    rp.DataSource = gridTKTienTuThien.DataSource;
                    rp.LoadLayout(Application.StartupPath + @"\ReportTienTuThienToanBoNamTheoNhom.repx");
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
                if (gridViewTKTienTuThien.RowCount > 0)
                {
                    if (txtTuNam.Text.Equals(txtDenNam.Text))
                    {
                        XtraReport rp = new XtraReport();
                        rp.DataSource = tuthien.TKTienTuThienTungNamTheoThang(txtTuNam.Text.Trim());
                        rp.LoadLayout(Application.StartupPath + @"\ReportTienTuThienMotNamTheoNhom.repx");
                        //rp.ShowDesignerDialog();
                        rp.ShowPreviewDialog();
                    }
                    else
                    {
                        XtraReport rp = new XtraReport();
                        rp.DataSource = gridTKTienTuThien.DataSource;
                        rp.LoadLayout(Application.StartupPath + @"\ReportTienTuThienNhieuNamTheoNhom.repx");
                        //rp.ShowDesignerDialog();
                        rp.ShowPreviewDialog();
                    }
                }
                else
                {
                    XtraMessageBox.Show("Không có dữ liệu để thống kê!");
                }
            }
            ConTKTienTuThienNam_Load(sender, e);
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            ConTKTienTuThienNam_Load(sender, e);
        }
    }
}