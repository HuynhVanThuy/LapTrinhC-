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
    public partial class ConTKNguoiNam : DevExpress.XtraEditors.XtraForm
    {
        public ConTKNguoiNam()
        {
            InitializeComponent();
        }

        private void ConTKNguoiNam_Load(object sender, EventArgs e)
        {
            btnTungNam.Enabled = btnTatCaNam.Enabled =btnNamToanBo.Enabled = btnNamTungNhom.Enabled = true;
            btnInKetQua.Enabled = btnNamToanBo.Enabled = btnNamTungNhom.Enabled = false;
            trangthai = "";
        }
        String trangthai = "";
        private void btnTatCaNam_Click(object sender, EventArgs e)
        {
            trangthai = "tatca";
            btnNamToanBo.Enabled = btnNamTungNhom.Enabled = true;
            btnTungNam.Enabled = false;
        }

        private void btnTungNam_Click(object sender, EventArgs e)
        {

            if (txtDenNam.Text.Equals(txtTuNam.Text))
            {
                trangthai = "motnam";
            }
            else {
                trangthai = "nhieunam";
            }
            btnNamToanBo.Enabled = btnNamTungNhom.Enabled = true;
            btnTatCaNam.Enabled = false;
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            ConTKNguoiNam_Load(sender, e);
        }
        E_NguoiDuocNuoi nguoinuoi = new E_NguoiDuocNuoi();
        private void btnNamToanBo_Click(object sender, EventArgs e)
        {
            btnNamTungNhom.Enabled = false;
            btnInKetQua.Enabled = true;
            if (trangthai.Equals("tatca")) {
                trangthai = "toanbo";
                gridTKNguoiO.DataSource = nguoinuoi.TKNguoiDuocNuoiToanBoNam();
            }
            //Nhiều năm
            if (trangthai.Equals("motnam"))
            {
                trangthai = "motnamtoanbo";
                gridTKNguoiO.DataSource = nguoinuoi.TKNguoiDuocNuoiMotNamToanBo(txtTuNam.Text.Trim());
            }
            if (trangthai.Equals("nhieunam"))
            {
                trangthai = "nhieunamtoanbo";
                gridTKNguoiO.DataSource = nguoinuoi.TKNguoiDuocNuoiNhieuNamToanBo(txtTuNam.Text.Trim(), txtDenNam.Text.Trim());
            }
        }

        private void btnNamTungNhom_Click(object sender, EventArgs e)
        {
            btnNamToanBo.Enabled = false;
            btnInKetQua.Enabled = true;
            if (trangthai.Equals("tatca"))
            {
                 trangthai = "tungnam";
                gridTKNguoiO.DataSource = nguoinuoi.TKNguoiDuocNuoiToanBoNamTheoNhom();
            }
            if (trangthai.Equals("motnam"))
            {
                trangthai = "motnamtungthang";
                gridTKNguoiO.DataSource = nguoinuoi.TKNguoiDuocNuoiMotNamTungThang(txtTuNam.Text.Trim());
            }
            if (trangthai.Equals("nhieunam"))
            {
                trangthai = "nhieunamtungnam";
                gridTKNguoiO.DataSource = nguoinuoi.TKNguoiDuocNuoiNhieuNamTungNam(txtTuNam.Text.Trim(), txtDenNam.Text.Trim());
            }
        }

        private void btnInKetQua_Click(object sender, EventArgs e)
        {
            if (trangthai.Equals("toanbo"))
            {
                XtraReport rp = new XtraReport();
                rp.DataSource = gridTKNguoiO.DataSource;
                rp.LoadLayout(Application.StartupPath + @"\ReportTKNguoiNuoiToanBoNam.repx");
                //rp.ShowDesignerDialog();
                rp.ShowPreviewDialog();
            }
            if (trangthai.Equals("tungnam"))
            {
                XtraReport rp = new XtraReport();
                rp.DataSource = gridTKNguoiO.DataSource;
                rp.LoadLayout(Application.StartupPath + @"\ReportTKNguoiNuoiToanBoNamTheoNhom.repx");
                //rp.ShowDesignerDialog();
                rp.ShowPreviewDialog();
            }

            //Thống kê theo nhiều năm
            if (trangthai.Equals("motnamtoanbo"))
            {
                XtraReport rp = new XtraReport();
                rp.DataSource = gridTKNguoiO.DataSource;
                rp.LoadLayout(Application.StartupPath + @"\ReportTKNguoiNuoiToanBoMotNam.repx");
                //rp.ShowDesignerDialog();
                rp.ShowPreviewDialog();
            }

            if (trangthai.Equals("motnamtungthang"))
            {
                XtraReport rp = new XtraReport();
                rp.DataSource = gridTKNguoiO.DataSource;
                rp.LoadLayout(Application.StartupPath + @"\ReportTKNguoiNuoiMotNamTheoThang.repx");
                //rp.ShowDesignerDialog();
                rp.ShowPreviewDialog();
            }

            if (trangthai.Equals("nhieunamtoanbo"))
            {
                XtraReport rp = new XtraReport();
                rp.DataSource = gridTKNguoiO.DataSource;
                rp.LoadLayout(Application.StartupPath + @"\ReportTKNguoiNuoiNhieuNamToanBo.repx");
                //rp.ShowDesignerDialog();
                rp.ShowPreviewDialog();
            }
            if (trangthai.Equals("nhieunamtungnam"))
            {
                XtraReport rp = new XtraReport();
                rp.DataSource = gridTKNguoiO.DataSource;
                rp.LoadLayout(Application.StartupPath + @"\ReportTKNguoiNuoiNhieuNamTungNam.repx");
                //rp.ShowDesignerDialog();
                rp.ShowPreviewDialog();
            }
            

            ConTKNguoiNam_Load(sender, e);
        }

    }
}