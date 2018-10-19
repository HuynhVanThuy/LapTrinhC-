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
    public partial class ConLichTham : DevExpress.XtraEditors.XtraForm
    {
        public ConLichTham()
        {
            InitializeComponent();
        }

        private void ConLichTham_Load(object sender, EventArgs e)
        {
            gridViewNgayViengTham.GroupPanelText = "Danh sách ngày có lịch thăm";
            gridViewChiTiet.GroupPanelText = "Chi tiết lịch viếng thăm";
            //Load dữ liệu cho DataGridView
            ViewLoad(true);
            //Gôm thành 1 hàng bằng cách không cho giá trị chỉnh sửa từng ô
            gridViewNgayViengTham.OptionsBehavior.Editable = false;
            gridViewChiTiet.OptionsBehavior.Editable = false;
            //Xóa hết toàn bộ text
            XoaText();
            //Load dữ liệu
            DataTable dtNgayViengTham = lichViengTham.AllDataNgayViengTham();
            gridNgayViengTham.DataSource = dtNgayViengTham;
            DataTable dtChiTiet = lichViengTham.AllDataChiTiet();
            gridChiTiet.DataSource = dtChiTiet;
            //Xét lại giá trị null cho looekupdit
            txtMaToChuc.Properties.DataSource = null;
            trangthai = "";
            txtTenToChuc.Visible = lbTenToChuc.Visible = true;
            btnXoaChiTiet.Visible = btnSuaChiTiet.Visible = btnThemChiTiet.Visible = false;
        }
        public void ViewLoad(bool kt)
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = kt;
            btnHuy.Enabled = btnLuu.Enabled = !kt;
            txtBuoi.Enabled = txtGhiChu.Enabled = txtHoatDong.Enabled = txtMaBuoi.Enabled = txtMaNgay.Enabled = txtMaToChuc.Enabled = txtNgay.Enabled = txtTenToChuc.Enabled = !kt;
            
        }
        public void XoaText()
        {
            txtBuoi.Text = txtGhiChu.Text = txtHoatDong.Text = txtMaBuoi.Text = txtMaNgay.Text = txtMaToChuc.Text = txtNgay.Text = txtTenToChuc.Text = "";
        }
        E_LichViengTham lichViengTham = new E_LichViengTham();
        String trangthai = "";
        //hiển thị cho thêm 1 ngày mới
        public void HienThiThemNgay(bool kt) {
            txtMaNgay.Enabled = kt;
            txtNgay.Enabled = !kt;
        }
        public void HienThiThemChiTiet(bool kt)
        {
            txtTenToChuc.Visible = lbTenToChuc.Visible = true;
            txtMaToChuc.Enabled =  txtBuoi.Enabled = txtGhiChu.Enabled = txtHoatDong.Enabled = true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            HienThiThemNgay(false);
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            txtNgay.Text = txtMaNgay.Text = "";
            btnHuy.Enabled = true;
            trangthai = "themngay";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            HienThiThemNgay(false);
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            trangthai = "suangay";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ConLichTham_Load(sender, e);
        }

        private void txtNgay_EditValueChanged(object sender, EventArgs e)
        {
            DataTable dtKTNgay = lichViengTham.GetDataNgayViengTham(txtNgay.Text.Split(' ')[0]);
            gridNgayViengTham.DataSource = dtKTNgay;
        }

        private void txtNgay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (trangthai.Equals("themngay"))
                {
                    if (txtNgay.Text.Equals(""))
                    {
                        XtraMessageBox.Show("Bạn cần chọn ngày cần lên lịch!", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        if (gridViewNgayViengTham.RowCount != 0)
                        {
                            XtraMessageBox.Show("Đã có lịch viếng thăm cho ngày này, mời xem chi tiết!");
                        }
                        else
                        {
                            if (lichViengTham.AddDataNgayTuThien(txtNgay.Text.Split(' ')[0]))
                            {
                                XtraMessageBox.Show("Thêm thành công!");
                                txtMaToChuc.Enabled = txtBuoi.Enabled = txtHoatDong.Enabled = txtGhiChu.Enabled = btnXoaChiTiet.Visible = btnSuaChiTiet.Visible = btnThemChiTiet.Visible = true;
                                txtNgay.Enabled = txtTenToChuc.Visible = lbTenToChuc.Visible = false;
                                DataTable dtKTNgay = lichViengTham.GetDataNgayViengTham(txtNgay.Text.Split(' ')[0]);
                                gridNgayViengTham.DataSource = dtKTNgay;
                            }
                            else
                            {
                                XtraMessageBox.Show("Thất bại!", "Thông báo", MessageBoxButtons.OK);
                            }
                        }
                    }
                }
                if(trangthai.Equals("suangay")){
                    if (txtMaNgay.Text.Equals("") || txtNgay.Text.Equals(""))
                    {
                        XtraMessageBox.Show("Bạn cần điền đủ thông tin!", "Thông báo", MessageBoxButtons.OK);
                    }
                    else {
                        if (lichViengTham.UpdateDataNgayViengTham(txtMaNgay.Text.Trim(), txtNgay.Text.Split(' ')[0]))
                        {
                            if (XtraMessageBox.Show("Đã cập nhật, bạn muốn thay đổi chi tiết không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                //Hiển thị để cập nhật 
                                txtMaToChuc.Enabled = txtBuoi.Enabled = txtHoatDong.Enabled = txtGhiChu.Enabled = btnXoaChiTiet.Visible = btnSuaChiTiet.Visible = btnThemChiTiet.Visible = true;
                                txtNgay.Enabled = txtTenToChuc.Visible = lbTenToChuc.Visible = false;
                                txtMaNgay.Enabled = txtNgay.Enabled = false;
                                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
                                btnHuy.Enabled = true;
                            }
                            else
                            {
                                ConLichTham_Load(sender, e);
                            }
                        }
                        else {
                            XtraMessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK);
                        }
                        
                    }
                }
                //hết
            }
        }

        private void gridViewNgayViengTham_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                txtMaNgay.Text = gridViewNgayViengTham.GetRowCellValue(gridViewNgayViengTham.FocusedRowHandle, "id_viengtham").ToString();
                txtNgay.Text = gridViewNgayViengTham.GetRowCellValue(gridViewNgayViengTham.FocusedRowHandle, "ngayden").ToString().Split(' ')[0];
            }
            catch { 
            
            }
        }

        private void gridViewChiTiet_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                txtMaBuoi.Text = gridViewChiTiet.GetRowCellValue(gridViewChiTiet.FocusedRowHandle, "id_buoi").ToString();
                txtBuoi.Text = gridViewChiTiet.GetRowCellValue(gridViewChiTiet.FocusedRowHandle, "thoigian").ToString();
                txtGhiChu.Text = gridViewChiTiet.GetRowCellValue(gridViewChiTiet.FocusedRowHandle, "ghichu").ToString();
                txtHoatDong.Text = gridViewChiTiet.GetRowCellValue(gridViewChiTiet.FocusedRowHandle, "tenhoatdong").ToString();
                txtMaToChuc.Properties.NullText = gridViewChiTiet.GetRowCellValue(gridViewChiTiet.FocusedRowHandle, "id_tochuc").ToString();
                txtMaNgay.Text = gridViewChiTiet.GetRowCellValue(gridViewChiTiet.FocusedRowHandle, "id_viengtham").ToString();
                txtTenToChuc.Text = gridViewChiTiet.GetRowCellValue(gridViewChiTiet.FocusedRowHandle, "tentochuc").ToString();
            }
            catch { 
            
            }
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (!txtMaNgay.Text.Equals(""))
            {
                //Hiển thị để cập nhật 
                txtMaToChuc.Enabled = txtBuoi.Enabled = txtHoatDong.Enabled = txtGhiChu.Enabled = btnXoaChiTiet.Visible = btnSuaChiTiet.Visible = btnThemChiTiet.Visible = true;
                txtNgay.Enabled = txtTenToChuc.Visible = lbTenToChuc.Visible = false;
                txtMaNgay.Enabled = txtNgay.Enabled = false;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
                btnHuy.Enabled = true;
                //Load dữ liệu
                DataTable dtChiTietTheoNgay = lichViengTham.AllDataChiTietTheoNgay(txtMaNgay.Text.Trim());
                gridChiTiet.DataSource = dtChiTietTheoNgay;
                txtMaBuoi.Text =txtBuoi.Text = txtGhiChu.Text = txtHoatDong.Text  = txtMaNgay.Text = "";
                txtMaToChuc.Properties.DataSource = null;
                txtMaToChuc.Properties.NullText = "";
                btnThemChiTiet.Enabled = btnSuaChiTiet.Enabled = btnXoaChiTiet.Enabled = true;
            }
            else {
                XtraMessageBox.Show("Bần cần cung cấp mã ngày cần xem chi tiết!");
            }
        }

        private void btnThemChiTiet_Click(object sender, EventArgs e)
        {
            btnSuaChiTiet.Enabled = btnXoaChiTiet.Enabled = false;
            btnLuu.Enabled = true;
            trangthai = "themchitiet";
            txtMaToChuc.Properties.NullText = "";
            txtMaToChuc.Properties.DataSource = lichViengTham.GetDataId_ToChuc();
            txtMaToChuc.Properties.DisplayMember = "id_tochuc";
        }

        private void btnSuaChiTiet_Click(object sender, EventArgs e)
        {
            btnThemChiTiet.Enabled = btnXoaChiTiet.Enabled = false;
            btnLuu.Enabled = true;
            trangthai = "suachitiet";
            txtMaToChuc.Properties.NullText = "";
            txtMaToChuc.Properties.DataSource = lichViengTham.GetDataId_ToChuc();
            txtMaToChuc.Properties.DisplayMember = "id_tochuc";
        }

        private void btnXoaChiTiet_Click(object sender, EventArgs e)
        {
            if (!txtMaBuoi.Text.Equals(""))
            {
                if (XtraMessageBox.Show("Dữ liệu sẽ không được phục hồi, bạn chắc chắn xóa??", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (lichViengTham.DeleteDataLichChiTiet(txtMaBuoi.Text.Trim()))
                    {
                        XtraMessageBox.Show("Đã xóa dữ liệu!");
                        ConLichTham_Load(sender,e);
                    }
                    else {
                        XtraMessageBox.Show("Xóa dữ liệu thất bại!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("Bạn cần chọn chi tiết cần xóa bỏ!");
            }
        }
        //Kiểm tra text có bị trống k
        public Boolean KiemTraTextRong()
        {
            if (txtMaNgay.Text.Equals("") || txtBuoi.Text.Equals("") || txtHoatDong.Text.Equals("") || txtGhiChu.Text.Equals("") || txtMaToChuc.Text.Equals("") || txtMaNgay.Text.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //thao tác lưu chi tiết
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(trangthai.Equals("themchitiet")){
                if (!KiemTraTextRong())
                {
                    if (lichViengTham.AddDataChiTietNgay(txtBuoi.Text.Trim(), txtHoatDong.Text.Trim(), txtGhiChu.Text.Trim(), txtMaToChuc.Text.Trim(), txtMaNgay.Text.Trim()))
                    {
                        XtraMessageBox.Show("Đã thêm dữ liệu!");
                        ConLichTham_Load(sender, e);
                    }
                    else {
                        XtraMessageBox.Show("Thêm dữ liệu thất bại!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                else {
                    XtraMessageBox.Show("Bạn cần điền đủ thông tin!");
                }
            }
            if (trangthai.Equals("suachitiet"))
            {
                if (!KiemTraTextRong() && !txtMaBuoi.Text.Equals(""))
                {
                    if (lichViengTham.UpdateDataChiTietNgay(txtMaBuoi.Text.Trim(),txtBuoi.Text.Trim(),txtHoatDong.Text.Trim(),txtGhiChu.Text.Trim(),txtMaToChuc.Text.Trim(),txtMaNgay.Text.Trim()))
                    {
                        XtraMessageBox.Show("Đã cập nhật dữ liệu!");
                        ConLichTham_Load(sender, e);
                    }
                    else
                    {
                        XtraMessageBox.Show("Cập nhật dữ liệu thất bại!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    XtraMessageBox.Show("Bạn cần điền đủ thông tin!");
                }
            }
        }

    }
}