using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DEMO.Model;
using DevExpress.XtraReports.UI;


namespace DEMO.View
{
    public partial class ConThemPhongO : DevExpress.XtraEditors.XtraForm
    {
        public ConThemPhongO()
        {
            InitializeComponent();
        }
        E_PhongO phong = new E_PhongO();
        private void ConThemPhongO_Load(object sender, EventArgs e)
        {
            DataTable dtThongPhongO = new DataTable();
            dtThongPhongO = phong.AllDataPhongO();
            gridPhongO.DataSource = dtThongPhongO;
            gridVPhongO.OptionsView.ShowAutoFilterRow = true;
            HienThi(false);
            XoaText();
        }

        private void gridVPhongO_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                //txtMaPhong.Text = gr.GetRowCellValue(gridView1.FocusedRowHandle, "TenHang").ToString();
                txtMaPhong.Text = gridVPhongO.GetRowCellValue(gridVPhongO.FocusedRowHandle, "id_phongo").ToString();
                txtTenPhong.Text = gridVPhongO.GetRowCellValue(gridVPhongO.FocusedRowHandle, "tenphong").ToString();
                txtMax.Text = gridVPhongO.GetRowCellValue(gridVPhongO.FocusedRowHandle, "toida").ToString();
                txtDangO.Text = gridVPhongO.GetRowCellValue(gridVPhongO.FocusedRowHandle, "hienco").ToString();
            }
            catch { }

        }

        //Hiển thị khi load
        public void HienThi(bool kt)
        {
            btnHuy.Enabled = btnLuu.Enabled = kt;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = !kt;
            txtDangO.Enabled = txtMaPhong.Enabled = txtTenPhong.Enabled = txtMax.Enabled = kt;
        }
        //Xóa toàn bộ text
        public void XoaText()
        {
            txtDangO.Text = txtMaPhong.Text = txtMax.Text = txtTenPhong.Text = "";
        }
        String trangthai = "";
        //Bắt sự kiện THÊM 1 phòng ở
        private void btnThem_Click(object sender, EventArgs e)
        {
            HienThi(true);
            XoaText();
            txtMaPhong.Enabled = txtMax.Enabled = txtDangO.Enabled = false;
            //Xử lý tự tăng biến phòng
            String bienPhong = gridVPhongO.GetRowCellValue(gridVPhongO.RowCount - 1, "tenphong").ToString();
            int bienTang = Convert.ToInt32(bienPhong.Substring(5)) + 1;
            bienPhong = bienPhong.Substring(0, 5) + " " + bienTang.ToString();
            txtTenPhong.Text = bienPhong;
            //Thêm giá trị cố định
            txtMax.Text = "4";
            txtDangO.Text = "0";
            trangthai = "them";
        }
        //Bắt sự kiện sửa 1 phòng ở
        private void btnSua_Click(object sender, EventArgs e)
        {
            trangthai = "sua";
            HienThi(true);
            txtTenPhong.Enabled = txtMaPhong.Enabled = txtMax.Enabled = false;
            txtDangO.Enabled = true;
        }
        //Bắt sự kiện xóa bỏ 1 phòng 
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text.Equals(""))
            {
                XtraMessageBox.Show("Chọn phòng muốn xóa bỏ!");
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("Dữ liệu không được phục hồi! Bạn có chắc chắn muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (phong.DeleteDataPhongO(txtMaPhong.Text.Trim()))
                    {
                        XtraMessageBox.Show("Đã xóa thành công dữ liệu!");
                        ConThemPhongO_Load(sender, e);
                    }
                    else {
                        XtraMessageBox.Show("Xóa dữ liệu không thành công!");
                    }
                }
            }
        }

        //Kiểm tra text đã đủ thông tin chưa
        public bool KiemTraTextTrong()
        {
            if (trangthai.Equals("them"))
            {
                if (txtTenPhong.Text.Equals(""))
                {
                    XtraMessageBox.Show("Bạn cần nhập tên cho phòng mới!");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            if (trangthai.Equals("sua"))
            {
                if (txtDangO.Text.Equals("") && txtMaPhong.Text.Equals(""))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }

        //Lưu lại 
        private void btnLuu_Click(object sender, EventArgs e)
        {
            //code khi THÊM dữ liệu
            if (trangthai.Equals("them"))
            {
                if (KiemTraTextTrong())
                {
                    if (phong.AddDataPhongO(txtTenPhong.Text.Trim()))
                    {
                        //Load lại để hiển thị dữ liệu mới
                        ConThemPhongO_Load(sender, e);
                    }
                    else
                        XtraMessageBox.Show("Thêm dữ liệu thất bại!");
                }
                else
                {
                    XtraMessageBox.Show("Bạn cần điền đủ thông tin");
                }

            }
            //code khi SỬA dữ liệu
            if (trangthai.Equals("sua"))
            {
                if (KiemTraTextTrong())
                {
                    if (phong.UpdateDataPhongO(txtDangO.Text.Trim(), txtMaPhong.Text.Trim()))
                    {
                        //Load lại để hiển thị dữ liệu mới
                        XtraMessageBox.Show("Cập nhật dữ liệu thành công!");
                        ConThemPhongO_Load(sender, e);
                    }
                    else
                        XtraMessageBox.Show("Cập nhật thông tin không thành công");
                }
                else
                {
                    XtraMessageBox.Show("Bạn cần điền đủ thông tin");
                }

            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ConThemPhongO_Load(sender, e);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (gridVPhongO.RowCount > 0)
            {
                XtraReport rp = new XtraReport();
                rp.DataSource = gridVPhongO.DataSource;
                rp.LoadLayout(Application.StartupPath + @"\ReportCapNhatPhong.repx");
                //rp.ShowDesignerDialog();
                rp.ShowPreviewDialog();
            }
            else {
                XtraMessageBox.Show("Không có dữ liệu để in", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        //Hết
    }
}