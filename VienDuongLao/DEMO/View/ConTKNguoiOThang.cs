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
    public partial class ConTKNguoiOThang : DevExpress.XtraEditors.XtraForm
    {
        public ConTKNguoiOThang()
        {
            InitializeComponent();
        }

        private void ConTKNguoiOThang_Load(object sender, EventArgs e)
        {
            btnIn.Enabled=btnMoiNgay.Enabled = btnTungNgay.Enabled = false;
            btnMotThang.Enabled = btnNhieuThang.Enabled = true;
        }
        E_NguoiDuocNuoi nguoio = new E_NguoiDuocNuoi();
        String trangthai = "";
        private void btnNhieuThang_Click(object sender, EventArgs e)
        {
            btnIn.Enabled = true;
            gridTKNguoiThang.DataSource = nguoio.TKNguoiDuocNuoiNhieuThang(txtNam.Text.Trim());
            btnMotThang.Enabled = false;
            trangthai = "nhieuthang";
            
        }

        private void btnMotThang_Click(object sender, EventArgs e)
        {
            btnNhieuThang.Enabled = false;
            trangthai = "motthang";
            btnTungNgay.Enabled = btnMoiNgay.Enabled = true;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            ConTKNguoiOThang_Load(sender, e);
            if(trangthai.Equals("nhieuthang")){
                if (gridViewTKNguoiThang.RowCount > 0)
                {
                    XtraReport rp = new XtraReport();
                    rp.DataSource = gridTKNguoiThang.DataSource;
                    rp.LoadLayout(Application.StartupPath + @"\ReportTKNguoiNuoiTungThang.repx");
                    //rp.ShowDesignerDialog();
                    rp.ShowPreviewDialog();

                }
                else XtraMessageBox.Show("Không có dữ liệu để in", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (trangthai.Equals("nhieungay"))
            {
                if (gridViewTKNguoiThang.RowCount > 0)
                {
                    XtraReport rp = new XtraReport();
                    rp.DataSource = gridTKNguoiThang.DataSource;
                    rp.LoadLayout(Application.StartupPath + @"\ReportTKNguoiNuoiMotThangToanBo.repx");
                    //rp.ShowDesignerDialog();
                    rp.ShowPreviewDialog();

                }
                else XtraMessageBox.Show("Không có dữ liệu để in", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (trangthai.Equals("motngay"))
            {
                if (gridViewTKNguoiThang.RowCount > 0)
                {
                    XtraReport rp = new XtraReport();
                    rp.DataSource = gridTKNguoiThang.DataSource;
                    rp.LoadLayout(Application.StartupPath + @"\ReportTKNguoiNuoiMotThangMotNgay.repx");
                    //rp.ShowDesignerDialog();
                    rp.ShowPreviewDialog();
                }
                else XtraMessageBox.Show("Không có dữ liệu để in", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMoiNgay_Click(object sender, EventArgs e)
        {
            if (trangthai.Equals("motthang"))
            {
                trangthai = "nhieungay";
                btnIn.Enabled = true;
                gridTKNguoiThang.DataSource = nguoio.TKNguoiDuocNuoiThang(txtThang.Text.Trim(),txtNam.Text.Trim());
            }
        }

        private void btnTungNgay_Click(object sender, EventArgs e)
        {
            if (trangthai.Equals("motthang"))
            {
                trangthai = "motngay";
                btnIn.Enabled = true;
                gridTKNguoiThang.DataSource = nguoio.TKNguoiDuocNuoiThang(txtThang.Text.Trim(), txtNam.Text.Trim());
            }  
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            ConTKNguoiOThang_Load(sender, e);
        }
    }
}