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
    public partial class ConTuThien : DevExpress.XtraEditors.XtraForm
    {
        public ConTuThien()
        {
            InitializeComponent();
        }

        private void ConTuThien_Load(object sender, EventArgs e)
        {
            ViewLoad(true);
            //Gôm thành 1 hàng bằng cách không cho giá trị chỉnh sửa từng ô
            gridViewTuThien.OptionsBehavior.Editable = false;
            //Xóa hết toàn bộ text
            XoaText();
        }
        public void ViewLoad(bool kt) {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = kt;
            txtLienHe.Enabled = txtMa.Enabled = txtNgayDK.Enabled = txtNguoiDaiDien.Enabled = txtTenToChuc.Enabled = !kt;
            DataTable dtTuThien = tuThien.AllDataTuThien();
            gridTuThien.DataSource = dtTuThien;
        }
        public void XoaText()
        {
            txtLienHe.Text = txtMa.Text = txtNgayDK.Text = txtNguoiDaiDien.Text = txtTenToChuc.Text = "";
        }

        public Boolean KiemTraTextRong()
        {
            if (txtLienHe.Text.Equals("") || txtNguoiDaiDien.Text.Equals("") || txtTenToChuc.Text.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        E_TuThien tuThien = new E_TuThien();
        String trangthai = "";
        private void btnThem_Click(object sender, EventArgs e)
        {
            ViewLoad(false);
            txtMa.Enabled = false;
            trangthai = "them";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ViewLoad(false);
            trangthai = "sua";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMa.Text.Equals(""))
            {
                XtraMessageBox.Show("Bạn cần chọn người cần xóa!");
            }
            else
            {
                if (XtraMessageBox.Show("Bạn chắc chắn muốn xóa " + txtTenToChuc.Text + "?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (tuThien.DeleteDataTCTuThien(txtMa.Text.Trim()))
                    {
                        XtraMessageBox.Show("Đã xóa!");
                        ConTuThien_Load(sender, e);
                    }
                    else
                    {
                        XtraMessageBox.Show("Không thành công!");
                    }
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (trangthai.Equals("them"))
            {
                if (KiemTraTextRong())
                {
                    XtraMessageBox.Show("Bạn cần nhập đủ thông tin!");
                }
                else
                {
                    if (tuThien.AddDataTCTuThien(txtTenToChuc.Text.Trim(),txtNguoiDaiDien.Text.Trim(),txtLienHe.Text.Trim()))
                    {
                        XtraMessageBox.Show("Thêm dữ liệu thành công");
                        ConTuThien_Load(sender, e);
                    }
                    else
                    {
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
                    if (tuThien.UpdateDataTCTuThien(txtMa.Text.Trim(),txtTenToChuc.Text.Trim(), txtNguoiDaiDien.Text.Trim(), txtLienHe.Text.Trim()))
                    {
                        XtraMessageBox.Show("Cập nhật dữ liệu thành công");
                        ConTuThien_Load(sender, e);
                    }
                    else
                    {
                        XtraMessageBox.Show("Cập nhật dữ liệu thất bại");
                    }
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ConTuThien_Load(sender,e);
        }

        private void gridViewTuThien_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                var giatringay = gridViewTuThien.GetRowCellValue(gridViewTuThien.FocusedRowHandle, "ngaytaotochuc").ToString().Split(' ');
                txtNgayDK.Text = giatringay[0];
                txtLienHe.Text = gridViewTuThien.GetRowCellValue(gridViewTuThien.FocusedRowHandle, "lienhe").ToString();
                txtMa.Text = gridViewTuThien.GetRowCellValue(gridViewTuThien.FocusedRowHandle, "id_tochuc").ToString();
                txtNguoiDaiDien.Text = gridViewTuThien.GetRowCellValue(gridViewTuThien.FocusedRowHandle, "nguoidaidien").ToString();
                txtTenToChuc.Text = gridViewTuThien.GetRowCellValue(gridViewTuThien.FocusedRowHandle, "tentochuc").ToString();
            }
            catch { 
            
            }
        }
    }
}