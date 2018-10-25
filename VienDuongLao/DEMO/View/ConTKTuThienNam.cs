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
    public partial class ConTKTuThienNam : DevExpress.XtraEditors.XtraForm
    {
        public ConTKTuThienNam()
        {
            InitializeComponent();
        }
        E_TuThien tuthien = new E_TuThien();
        String trangthai = "";
        private void ConTKTuThienNam_Load(object sender, EventArgs e)
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
                gridTKTuThien.DataSource = tuthien.TKTuThienTatCaNamToanBo();
            }
            if (trangthai.Equals("tungnam"))
            {
                trangthai = "toanbotungnam";
                gridTKTuThien.DataSource = tuthien.TKTuThienTungNam(txtTuNam.Text.Trim(), txtDenNam.Text.Trim());
            }
        }

        private void btnNamTungNhom_Click(object sender, EventArgs e)
        {
            btnInKetQua.Enabled = true;
            btnNamToanBo.Enabled = false;
            if (trangthai.Equals("tatcanam"))
            {
                trangthai = "chianhomtatcanam";
                gridTKTuThien.DataSource = tuthien.TKTuThienTatCaNamToanBo();
            }
            if (trangthai.Equals("tungnam"))
            {
                trangthai = "chianhomtungnam";
                gridTKTuThien.DataSource = tuthien.TKTuThienTungNam(txtTuNam.Text.Trim(), txtDenNam.Text.Trim());
            }
        }

        private void btnInKetQua_Click(object sender, EventArgs e)
        {
            if (trangthai.Equals("toanbotatcanam"))
            {
                if (gridViewTKTuThien.RowCount > 0)
                {
                    XtraReport rp = new XtraReport();
                    rp.DataSource = gridTKTuThien.DataSource;
                    rp.LoadLayout(Application.StartupPath + @"\ReportTuThienToanBoNam.repx");
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
                if (gridViewTKTuThien.RowCount > 0)
                {
                    XtraReport rp = new XtraReport();
                    rp.DataSource = gridTKTuThien.DataSource;
                    rp.LoadLayout(Application.StartupPath + @"\ReportTuThienToanBoNamTheoNhom.repx");
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
                if (gridViewTKTuThien.RowCount > 0)
                {
                    XtraReport rp = new XtraReport();
                    rp.DataSource = gridTKTuThien.DataSource;
                    rp.LoadLayout(Application.StartupPath + @"\ReportTuThienToanBoTungNam.repx");
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
                if (gridViewTKTuThien.RowCount > 0)
                {
                    if (txtTuNam.Text.Equals(txtDenNam.Text))
                    {
                        XtraReport rp = new XtraReport();
                        rp.DataSource = tuthien.TKTuThienTungNamTheoThang(txtTuNam.Text.Trim());
                        rp.LoadLayout(Application.StartupPath + @"\ReportTuThienMotNamTheoThang.repx");
                        //rp.ShowDesignerDialog();
                        rp.ShowPreviewDialog();
                    }
                    else
                    {
                        XtraReport rp = new XtraReport();
                        rp.DataSource = gridTKTuThien.DataSource;
                        rp.LoadLayout(Application.StartupPath + @"\ReportTuThienTungNamTheoNhom.repx");
                        //rp.ShowDesignerDialog();
                        rp.ShowPreviewDialog();
                    }
                }
                else
                {
                    XtraMessageBox.Show("Không có dữ liệu để thống kê!");
                }
            }
            ConTKTuThienNam_Load(sender, e);
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            ConTKTuThienNam_Load(sender, e);
        }
    }
}