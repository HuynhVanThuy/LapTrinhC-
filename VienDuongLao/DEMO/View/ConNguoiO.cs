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

namespace DEMO.View
{
    public partial class ConNguoiO : DevExpress.XtraEditors.XtraForm
    {
        public ConNguoiO()
        {
            InitializeComponent();
        }

        private void ConNguoiO_Load(object sender, EventArgs e)
        {
            ViewLoad(true);
            //Gôm thành 1 hàng bằng cách không cho giá trị chỉnh sửa từng ô
            gridViewNguoiDuocNuoi.OptionsBehavior.Editable = false;
            //Xóa hết toàn bộ text
            XoaText();
        }
        E_NguoiDuocNuoi nguoiDuocNuoi = new E_NguoiDuocNuoi();
        //bắt sự kiện khi nháy vào 1 hàng trong grid
        private void gridViewNguoiDuocNuoi_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                txtGiayTo.Text = gridViewNguoiDuocNuoi.GetRowCellValue(gridViewNguoiDuocNuoi.FocusedRowHandle, "giayto").ToString();
                txtHoTen.Text = gridViewNguoiDuocNuoi.GetRowCellValue(gridViewNguoiDuocNuoi.FocusedRowHandle, "hoten").ToString();
                txtMa.Text = gridViewNguoiDuocNuoi.GetRowCellValue(gridViewNguoiDuocNuoi.FocusedRowHandle, "id_nguoinuoi").ToString();
                txtQueQuan.Text = gridViewNguoiDuocNuoi.GetRowCellValue(gridViewNguoiDuocNuoi.FocusedRowHandle, "quequan").ToString();
                var giatringay = gridViewNguoiDuocNuoi.GetRowCellValue(gridViewNguoiDuocNuoi.FocusedRowHandle, "ngaysinh").ToString().Split(' ');
                txtNgaySinh.Text = giatringay[0];
            }
            catch { }
        }

        //hiển thị ban đầu
        public void ViewLoad(bool kt)
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = kt;
            txtGiayTo.Enabled = txtHoTen.Enabled = txtMa.Enabled = txtNgaySinh.Enabled = txtQueQuan.Enabled = btnHuyBo.Enabled = btbLuuLai.Enabled = !kt;
            DataTable dtNguoiDuocNuoi = nguoiDuocNuoi.AllDataPhongO();
            gridNguoiDuocNuoi.DataSource = dtNguoiDuocNuoi;
        }
        //Xóa toàn bộ các text
        public void XoaText()
        {
            txtGiayTo.Text = txtHoTen.Text = txtMa.Text = txtNgaySinh.Text = txtQueQuan.Text = "";
        }
        //Hủy bỏ thao tác
        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            ConNguoiO_Load(sender, e);
            XoaText();
        }
        String trangthai = "";
        //Xử lý thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            ViewLoad(false);
            txtMa.Enabled = false;
            trangthai = "them";
        }
        //Xử lý cập nhật
        private void btnSua_Click(object sender, EventArgs e)
        {
            ViewLoad(false);
            txtMa.Enabled = false;
            trangthai = "sua";
        }
        //Xử lý xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMa.Text.Equals(""))
            {
                XtraMessageBox.Show("Bạn cần chọn người cần xóa!");
            }
            else
            {
                if(XtraMessageBox.Show("Bạn chắc chắn muốn xóa "+txtHoTen.Text+"?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes){
                    if (nguoiDuocNuoi.DeleteDataNguoiDuocNuoi(txtMa.Text.Trim()))
                    {
                        XtraMessageBox.Show("Đã xóa!");
                        ConNguoiO_Load(sender, e);
                    }
                    else {
                        XtraMessageBox.Show("Không thành công!");
                    }
                }
            }
        }
        //Phương thức kiểm tra giá trị trống
        public Boolean KiemTraTextRong()
        {
            if (txtGiayTo.Text.Equals("") || txtHoTen.Text.Equals("") || txtNgaySinh.Text.Equals("") || txtQueQuan.Text.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Xử lý khi nhấn nút lưu
        private void btbLuuLai_Click(object sender, EventArgs e)
        {
            if (trangthai.Equals("them"))
            {
                if (KiemTraTextRong())
                {
                    XtraMessageBox.Show("Bạn cần nhập đủ thông tin!");
                }
                else
                {
                    if(nguoiDuocNuoi.AddDataNguoiDuocNuoi(txtHoTen.Text.Trim(), txtNgaySinh.Text.Trim(), txtQueQuan.Text.Trim(), txtGiayTo.Text.Trim()))
                    {
                        XtraMessageBox.Show("Thêm dữ liệu thành công");
                        ConNguoiO_Load(sender, e);
                    }
                    else{
                        XtraMessageBox.Show("Thêm dữ liệu thất bại");
                        
                    }
                }
            }
            if (trangthai.Equals("sua"))
            {
                if (KiemTraTextRong())
                {
                    XtraMessageBox.Show("Bạn cần nhập đủ thông tin!");
                }
                else
                {
                    if (nguoiDuocNuoi.UpdateDataNguoiDuocNuoi(txtMa.Text,txtHoTen.Text.Trim(), txtNgaySinh.Text.Trim(), txtQueQuan.Text.Trim(), txtGiayTo.Text.Trim()))
                    {
                        XtraMessageBox.Show("Cập nhật dữ liệu thành công");
                        ConNguoiO_Load(sender, e);
                    }
                    else
                    {
                        XtraMessageBox.Show("Cập nhật dữ liệu thất bại");
                    }
                }
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {

        }

        





        //Hết
    }
}