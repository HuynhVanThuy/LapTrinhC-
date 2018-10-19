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
    public partial class ConNhapChi : DevExpress.XtraEditors.XtraForm
    {
        public ConNhapChi()
        {
            InitializeComponent();
        }

        private void ConNhapChi_Load(object sender, EventArgs e)
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = lbtenNguoiChi.Visible = txtTenNguoiChi.Visible = true;
            pnChiTiet.Enabled = false;
            ViewLoad(true);
            //Hiển thị toàn bộ dữ liệu
            DataTable dtnhapChi = nhapChiTieu.AllDataNgayNhapChiTieu();
            gridNhapChi.DataSource = dtnhapChi;

            DataTable dtChiTietNhapChi = nhapChiTieu.AllDataChiTietNhapChiTieu();
            gridChiTietChiTieu.DataSource = dtChiTietNhapChi;
            //gôm thành 1 hàng
            gridViewNhapChi.OptionsBehavior.Editable = false;
            gridViewChiTietChiTieu.OptionsBehavior.Editable = false;

            btnLuuNgayChi.Visible = btnHuyNgayChi.Visible = false;
            btnXemChiTiet.Visible = btnLamMoi.Visible = true;

            btnThemChiTiet.Visible = btnSuaChiTiet.Visible = btnXoaChiTiet.Visible = false;
            pnNgay.Enabled = true;

            //xét lại giá trị null cho mã người chi
            txtMaNguoiChi.Properties.DataSource = null;
            txtMaNguoiChi.Properties.NullText = txtTenNguoiChi.Text = "";
            txtmaChiTiet.Enabled = true;
           
        }
        public void ViewLoad(bool kt)
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = kt;
            txtNgayChiTieu.Enabled = txtMaNgayChi.Enabled = !kt;
            txtNgayChiTieu.Text = txtMaNgayChi.Text = txtKhoanChi.Text = txtmaChiTiet.Text = txtSoTien.Text = "";

        }
        E_NhapChiTieu nhapChiTieu = new E_NhapChiTieu();
        String trangthai = "";
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtNgayChiTieu.Enabled = true;
            //Hiển thị 2 nút lưu hủy
            btnLuuNgayChi.Visible = btnHuyNgayChi.Visible = true;
            btnXemChiTiet.Visible = btnLamMoi.Visible = false;
            trangthai = "luungaychi";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtNgayChiTieu.Enabled = true;
            //Hiển thị 2 nút lưu hủy
            btnLuuNgayChi.Visible = btnHuyNgayChi.Visible = true;
            btnXemChiTiet.Visible = btnLamMoi.Visible = false;
            trangthai = "suangaychi";
        }

        private void btnLuuNgayChi_Click(object sender, EventArgs e)
        {
            if (trangthai.Equals("luungaychi"))
            {
                if (!txtNgayChiTieu.Text.Equals(""))
                {
                    if (nhapChiTieu.AddDataNgayNhapChiTieu(txtNgayChiTieu.Text.Trim()))
                    {
                        XtraMessageBox.Show("Đã thêm dữ liệu");
                        ConNhapChi_Load(sender, e);
                    }
                    else
                    {
                        XtraMessageBox.Show("Thêm dữ liệu thất bại!");
                    }
                }
                else
                {
                    XtraMessageBox.Show("Bạn cần nhập đủ thông tin!");
                }
            }
           
            if (trangthai.Equals("suangaychi"))
            {
                if (!txtNgayChiTieu.Text.Equals("") || !txtMaNgayChi.Text.Equals(""))
                {
                    if (nhapChiTieu.UpdateDataNgayNhapChi(txtMaNgayChi.Text.Trim(), txtNgayChiTieu.Text.Trim()))
                    {
                        XtraMessageBox.Show("Đã cập nhật dữ liệu");
                        ConNhapChi_Load(sender, e);
                    }
                    else
                    {
                        XtraMessageBox.Show("Cập nhật dữ liệu thất bại!");
                    }
                }
                else
                {
                    XtraMessageBox.Show("Bạn cần cung cấp mã ngày cần cập nhật!");
                }
            }
            
        }

        private void gridViewNhapChi_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                txtMaNgayChi.Text = gridViewNhapChi.GetRowCellValue(gridViewNhapChi.FocusedRowHandle, "id_chi").ToString();
                txtNgayChiTieu.Text = gridViewNhapChi.GetRowCellValue(gridViewNhapChi.FocusedRowHandle, "ngaychi").ToString().Split(' ')[0];
            }
            catch { 
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNgayChi.Text.Equals(""))
            {
                XtraMessageBox.Show("Bạn cần chọn ngày cần xóa!");
            }
            else
            {
                if (XtraMessageBox.Show("Dữ liệu không được phục hồi! Bạn chắc chắn muốn xóa?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (nhapChiTieu.DeleteDataNgayNhapChi(txtMaNgayChi.Text.Trim()))
                    {
                        XtraMessageBox.Show("Đã xóa!");
                        ConNhapChi_Load(sender, e);
                    }
                    else
                    {
                        XtraMessageBox.Show("Không thành công!");
                    }
                }
            }
        }

        private void btnHuyNgayChi_Click(object sender, EventArgs e)
        {
            ConNhapChi_Load(sender, e);
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (!txtMaNgayChi.Text.Equals("") || !txtNgayChiTieu.Text.Equals(""))
            {
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
                btnThemChiTiet.Visible = btnSuaChiTiet.Visible = btnXoaChiTiet.Visible = true;
                btnThemChiTiet.Enabled = btnSuaChiTiet.Enabled = btnXoaChiTiet.Enabled = true;
                //Hiển thị lại tên người chi
                txtTenNguoiChi.Visible = lbtenNguoiChi.Visible = true;

                txtKhoanChi.Text = txtmaChiTiet.Text = txtMaNguoiChi.Properties.NullText = txtSoTien.Text = txtTenNguoiChi.Text = "";

                trangthai = "";
                pnNgay.Enabled = false;
                pnChiTiet.Enabled = true;
            }
            else {
                XtraMessageBox.Show("Bạn muốn xem chi tiết chi tiêu cho ngày nào?");
            }
        }

        private void txtMaNgayChi_EditValueChanged(object sender, EventArgs e)
        {
            DataTable dtnhapChi = nhapChiTieu.AllDataNhapChiTieuTheoNgay(txtMaNgayChi.Text);
            gridNhapChi.DataSource = dtnhapChi;

            DataTable dtChTietnhapChi = nhapChiTieu.AllDataNhapCTChiTieuTheoNgay(txtMaNgayChi.Text);
            gridChiTietChiTieu.DataSource = dtChTietnhapChi;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ConNhapChi_Load(sender,e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ConNhapChi_Load(sender, e);
        }

        private void btnThemChiTiet_Click(object sender, EventArgs e)
        {
            btnSuaChiTiet.Enabled = btnXoaChiTiet.Enabled = false;
            btnHuyChiTiet.Enabled = btnLuuChiTiet.Enabled = true;
            trangthai = "themchitiet";

            //ẩn tên
            txtTenNguoiChi.Visible = lbtenNguoiChi.Visible = false;
            txtmaChiTiet.Enabled = false;

            txtMaNguoiChi.Properties.DataSource = nhapChiTieu.GetDataId_nguoichi();
            txtMaNguoiChi.Properties.DisplayMember = "id_phattu";
        }

        private void btnSuaChiTiet_Click(object sender, EventArgs e)
        {
            btnThemChiTiet.Enabled = btnXoaChiTiet.Enabled = false;
            btnHuyChiTiet.Enabled = btnLuuChiTiet.Enabled = true;
            trangthai = "suachitiet";

            txtMaNguoiChi.Properties.DataSource = nhapChiTieu.GetDataId_nguoichi();
            txtMaNguoiChi.Properties.DisplayMember = "id_phattu";
        }

        private void btnLuuChiTiet_Click(object sender, EventArgs e)
        {

            if (trangthai.Equals("themchitiet"))
            {
                if (!txtKhoanChi.Text.Equals("") || !txtMaNguoiChi.Text.Equals("") || !txtSoTien.Text.Equals(""))
                {
                    if (nhapChiTieu.AddDataChiTietNhapChi(txtKhoanChi.Text.Trim(), txtSoTien.Text.Trim(), txtMaNgayChi.Text.Trim(), txtMaNguoiChi.Text.Trim()))
                    {
                        XtraMessageBox.Show("Đã thêm dữ liệu");
                        ConNhapChi_Load(sender, e);
                    }
                    else
                    {
                        XtraMessageBox.Show("Thêm dữ liệu thất bại!");
                    }
                }
                else
                {
                    XtraMessageBox.Show("Bạn cần nhập đủ thông tin!");
                }
            }

            if (trangthai.Equals("suachitiet"))
            {
                if (!txtmaChiTiet.Text.Equals("") || !txtKhoanChi.Text.Equals("") || !txtMaNguoiChi.Text.Equals("") || !txtSoTien.Text.Equals(""))
                {
                    if (nhapChiTieu.UpdateChiTietChi(txtmaChiTiet.Text.Trim(), txtKhoanChi.Text.Trim(), txtSoTien.Text.Trim(), txtMaNgayChi.Text.Trim(), txtMaNguoiChi.Text.Trim()))
                    {
                        XtraMessageBox.Show("Đã cập nhật dữ liệu");
                        ConNhapChi_Load(sender, e);
                    }
                    else
                    {
                        XtraMessageBox.Show("Cập nhật dữ liệu thất bại!");
                    }
                }
                else
                {
                    XtraMessageBox.Show("Bạn cần cung cấp mã ngày cần cập nhật!");
                }
            }

        }

        private void gridViewChiTietChiTieu_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                txtmaChiTiet.Text = gridViewChiTietChiTieu.GetRowCellValue(gridViewChiTietChiTieu.FocusedRowHandle, "id_chitietchi").ToString();
                txtTenNguoiChi.Text = gridViewChiTietChiTieu.GetRowCellValue(gridViewChiTietChiTieu.FocusedRowHandle, "tenphattu").ToString();
                txtSoTien.Text = gridViewChiTietChiTieu.GetRowCellValue(gridViewChiTietChiTieu.FocusedRowHandle, "sotien").ToString();
                txtMaNguoiChi.Properties.NullText = gridViewChiTietChiTieu.GetRowCellValue(gridViewChiTietChiTieu.FocusedRowHandle, "id_phattu").ToString();
                txtKhoanChi.Text = gridViewChiTietChiTieu.GetRowCellValue(gridViewChiTietChiTieu.FocusedRowHandle, "tenkhoanchi").ToString();
            }
            catch { 
            
            }
        }

        private void btnXoaChiTiet_Click(object sender, EventArgs e)
        {
            if (txtmaChiTiet.Text.Equals(""))
            {
                XtraMessageBox.Show("Bạn cần chọn chi tiết cần xóa!");
            }
            else
            {
                if (XtraMessageBox.Show("Dữ liệu không được phục hồi! Bạn chắc chắn muốn xóa?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (nhapChiTieu.DeleteDataChiTietChi(txtmaChiTiet.Text.Trim()))
                    {
                        XtraMessageBox.Show("Đã xóa!");
                        ConNhapChi_Load(sender, e);
                    }
                    else
                    {
                        XtraMessageBox.Show("Không thành công!");
                    }
                }
            }
        }
    }
}