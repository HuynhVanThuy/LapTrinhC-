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
    public partial class ConChiTietPhong : DevExpress.XtraEditors.XtraForm
    {
        public ConChiTietPhong()
        {
            InitializeComponent();
        }
        E_ChiTietPhong ctPhong = new E_ChiTietPhong();
        private void ConChiTietPhong_Load(object sender, EventArgs e)
        {
            DataTable dtChiTietPhong = new DataTable();
            dtChiTietPhong = ctPhong.AllDataChiTietPhongO();
            gridPhongOChiTiet.DataSource = dtChiTietPhong;
            lbMaNguoi.Visible = txtMaNguoi.Visible = lbTenPhong.Visible = txtTenPhong.Visible = txtNgaySinh.Visible = txtHoTen.Visible = lbHoTen.Visible = lbNgaySinh.Visible = txtSoNguoi.Visible = lbSoNguoi.Visible = true;
            HienThi(false);
            txtMaChiTiet.Visible = lbId_Chitiet.Visible = false;
            txtMaNguoi.Properties.NullText = txtMaPhong.Properties.NullText = "";
            txtHoTen.Text = txtMaNguoi.Text = txtMaPhong.Text = txtNgaySinh.Text = txtSoNguoi.Text = txtTenPhong.Text = "";
            gridVPhongOChiTiet.OptionsView.ShowAutoFilterRow = true;
        }

        //Xóa toàn bộ text
        public void XoaText()
        {
            txtHoTen.Text = txtMaPhong.Text = txtTenPhong.Text = txtMaNguoi.Text = txtNgaySinh.Text = txtSoNguoi.Text = "";
        }
        String trangthai = "";
        //Bắt sự kiện THÊM 1 phòng ở
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            trangthai = "them";
            HienThi(true);
            lbTenPhong.Visible = txtTenPhong.Visible = txtNgaySinh.Visible = txtHoTen.Visible = lbHoTen.Visible = lbNgaySinh.Visible = txtSoNguoi.Visible = lbSoNguoi.Visible = false;
            //Đỗ dữ liệu cho lookedit mã người nuôi
            DataTable dtNguoiNuoi = ctPhong.GetDataId_NguoiNuoi();
            txtMaNguoi.Properties.DataSource = dtNguoiNuoi;
            txtMaNguoi.Properties.DisplayMember = "id_nguoinuoi";
            //Đỗ dữ liệu cho lookedit mã phòng
            DataTable dtMaPhongTrong = ctPhong.GetDataId_MaPhong();
            txtMaPhong.Properties.DataSource = dtMaPhongTrong;
            txtMaPhong.Properties.DisplayMember = "id_phongo";
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
                    if (trangthai == "")
                    {
                        XtraMessageBox.Show("Đã xóa thành công dữ liệu!");
                        ConChiTietPhong_Load(sender, e);
                    }
                    else
                    {
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
                if (txtMaPhong.Text.Equals(""))
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
        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            //code khi THÊM dữ liệu
            if (trangthai.Equals("them"))
            {
                if (txtMaNguoi.Text.Equals("") || txtMaPhong.Text.Equals(""))
                {
                    XtraMessageBox.Show("Bạn cần điền đủ thông tin!");
                }
                else
                {
                    if (ctPhong.AddDataPhongO(txtMaNguoi.Text.Trim(), txtMaPhong.Text.Trim()))
                    {
                        String quantity = ctPhong.LaySoLuongHienCo(txtMaPhong.Text);
                        int updQuantity = Convert.ToInt32(quantity) + 1;
                        if (ctPhong.UpdateQuantityPhong(txtMaPhong.Text, updQuantity.ToString()))
                        {
                            ConChiTietPhong_Load(sender, e);
                            XtraMessageBox.Show("Đã thêm vào phòng thành viên mới!");
                        }
                        else
                        {
                            XtraMessageBox.Show("Chưa cập nhật số lượng người ở phòng " + txtMaPhong.Text.Trim());
                        }

                    }
                    else
                    {
                        XtraMessageBox.Show("Thêm thành viên thất bại!");
                    }
                }
            }
            if (trangthai.Equals("xoa"))
            {
                if (DialogResult.Yes == MessageBox.Show("Dữ liệu không được phục hồi! Bạn có chắc chắn muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (txtMaChiTiet.Text.Equals(""))
                    {
                        XtraMessageBox.Show("Bạn cần chọn chi tiết phòng cần xóa!");
                    }
                    else
                    {
                        String id_phongo = ctPhong.LaymaPhongTuongUng(txtMaChiTiet.Text.Trim());
                        String quantity = ctPhong.LaySoLuongHienCo(id_phongo);
                        int updQuantity = Convert.ToInt32(quantity) - 1;
                        if (ctPhong.DeleteNguoiTrongPhong(txtMaChiTiet.Text))
                        {
                            if (ctPhong.UpdateQuantityPhong(id_phongo, updQuantity.ToString()))
                            {
                                XtraMessageBox.Show("Đã xóa và cập nhật thành công dữ liệu!");
                                ConChiTietPhong_Load(sender, e);
                            }
                            else
                            {
                                XtraMessageBox.Show("Chưa cập nhật số lượng người ở phòng " + txtMaPhong.Text.Trim());
                            }
                        }
                        else
                        {
                            XtraMessageBox.Show("Xóa dữ liệu không thành công!");
                        }
                        ConChiTietPhong_Load(sender, e);
                    }

                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ConChiTietPhong_Load(sender, e);
        }


        private void HienThi(bool kt)
        {
            btnHuy.Enabled = btnLuu.Enabled = kt;
            btnThem.Enabled = btnXoa.Enabled = !kt;
            txtHoTen.Enabled = txtMaPhong.Enabled = txtTenPhong.Enabled = txtMaNguoi.Enabled = txtNgaySinh.Enabled = txtSoNguoi.Enabled = kt;

        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            txtMaChiTiet.Visible = lbId_Chitiet.Visible = true;
            HienThi(true);
            trangthai = "xoa";
            txtMaPhong.Properties.NullText = "";
            lbMaNguoi.Visible = txtMaNguoi.Visible = lbTenPhong.Visible = txtTenPhong.Visible = txtNgaySinh.Visible = txtHoTen.Visible = lbHoTen.Visible = lbNgaySinh.Visible = txtSoNguoi.Visible = lbSoNguoi.Visible = false;
            //Đỗ dữ liệu cho lookedit mã chi tiết phòng ở
            DataTable dtMaChiTiet = ctPhong.GetDataId_Id_ChiTietPhong();
            txtMaChiTiet.Properties.DataSource = dtMaChiTiet;
            txtMaChiTiet.Properties.DisplayMember = "id_chitietphong";
        }



        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            ConChiTietPhong_Load(sender, e);
        }

        private void gridVPhongO_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                //txtMaPhong.Text = gridVPhongO.GetRowCellValue(gridVPhongO.FocusedRowHandle, "id_phongo").ToString();
                txtHoTen.Text = gridVPhongOChiTiet.GetRowCellValue(gridVPhongOChiTiet.FocusedRowHandle, "hoten").ToString();
                txtMaNguoi.Properties.NullText = gridVPhongOChiTiet.GetRowCellValue(gridVPhongOChiTiet.FocusedRowHandle, "id_nguoinuoi").ToString();
                txtMaPhong.Properties.NullText = gridVPhongOChiTiet.GetRowCellValue(gridVPhongOChiTiet.FocusedRowHandle, "id_phongo").ToString();
                var giatringaysinh = gridVPhongOChiTiet.GetRowCellValue(gridVPhongOChiTiet.FocusedRowHandle, "ngaysinh").ToString().Split(' ');
                txtNgaySinh.Text = giatringaysinh[0];
                txtSoNguoi.Text = gridVPhongOChiTiet.GetRowCellValue(gridVPhongOChiTiet.FocusedRowHandle, "hienco").ToString();
                txtTenPhong.Text = gridVPhongOChiTiet.GetRowCellValue(gridVPhongOChiTiet.FocusedRowHandle, "tenphong").ToString();
                txtMaChiTiet.Properties.NullText = gridVPhongOChiTiet.GetRowCellValue(gridVPhongOChiTiet.FocusedRowHandle, "id_chitietphong").ToString();
            }
            catch { }

        }




        //hết
    }
}