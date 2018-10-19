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
    public partial class ConTienTuThien : DevExpress.XtraEditors.XtraForm
    {
        public ConTienTuThien()
        {
            InitializeComponent();
        }

        private void ConTienTuThien_Load(object sender, EventArgs e)
        {
            ViewLoad(true);
            //Gôm thành 1 hàng bằng cách không cho giá trị chỉnh sửa từng ô
            gridViewTienTuThien.OptionsBehavior.Editable = false;
            //Xóa hết toàn bộ text
            XoaText();
        }
        public void ViewLoad(bool kt)
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = kt;
             txtMaTuThien.Enabled = txtNgayTang.Enabled = txtSoTien.Enabled = txtTaiTroKhac.Enabled = txtTenToChuc.Enabled = !kt;
            DataTable dtPhatTu = tienTuThien.AllDataTienTuThien();
            gridTienTuThien.DataSource = dtPhatTu;
        }
        public void XoaText()
        {
            txtMaTuThien.Text = txtNgayTang.Text = txtSoTien.Text = txtTaiTroKhac.Text = txtTenToChuc.Text = txtTenToChuc.Properties.NullText = "";
        }

        public Boolean KiemTraTextRong()
        {
            if (txtNgayTang.Text.Equals("") || txtSoTien.Text.Equals("") || txtTaiTroKhac.Text.Equals("") || txtTenToChuc.Text.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        E_TienTuThien tienTuThien = new E_TienTuThien();
        String trangthai = "";

        private void btnThem_Click(object sender, EventArgs e)
        {
            ViewLoad(false);
            txtMaTuThien.Enabled = false;
            trangthai = "them";
            txtTenToChuc.Properties.NullText = "";
            txtTenToChuc.Properties.DataSource = tienTuThien.GetDataId_ToChuc();
            txtTenToChuc.Properties.DisplayMember = "id_tochuc";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ViewLoad(false);
            trangthai = "sua";
            txtTenToChuc.Properties.NullText = "";
            txtTenToChuc.Properties.DataSource = tienTuThien.GetDataId_ToChuc();
            txtTenToChuc.Properties.DisplayMember = "id_tochuc";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaTuThien.Text.Equals(""))
            {
                XtraMessageBox.Show("Bạn cần chọn người cần xóa!");
            }
            else
            {
                if (XtraMessageBox.Show("Bạn chắc chắn muốn xóa?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (tienTuThien.DeleteDataTienTuThien(txtMaTuThien.Text.Trim()))
                    {
                        XtraMessageBox.Show("Đã xóa!");
                        ConTienTuThien_Load(sender, e);
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
                    if (tienTuThien.AddDataTienTuThien(txtNgayTang.Text.ToString().Split(' ')[0], txtTenToChuc.Text.Trim(), txtSoTien.Text.Trim(), txtTaiTroKhac.Text.Trim()))
                    {
                        XtraMessageBox.Show("Thêm dữ liệu thành công");
                        ConTienTuThien_Load(sender, e);
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
                    if (tienTuThien.UpdateDataTienTuThien(txtMaTuThien.Text.Trim(), txtNgayTang.Text.Trim(), txtTenToChuc.Text.Trim(), txtSoTien.Text.Trim(), txtTaiTroKhac.Text.Trim()))
                    {
                        XtraMessageBox.Show("Cập nhật dữ liệu thành công");
                        ConTienTuThien_Load(sender, e);
                    }
                    else
                    {
                        XtraMessageBox.Show("Cập nhật dữ liệu thất bại");
                    }
                }
            }
            txtTenToChuc.Properties.DataSource = null;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ConTienTuThien_Load(sender, e);
            txtTenToChuc.Properties.DataSource = null;
        }

        private void gridViewTienTuThien_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtMaTuThien.Text = gridViewTienTuThien.GetRowCellValue(gridViewTienTuThien.FocusedRowHandle, "id_taitro").ToString();
            txtNgayTang.Text = gridViewTienTuThien.GetRowCellValue(gridViewTienTuThien.FocusedRowHandle, "ngaytaitro").ToString().Split(' ')[0];
            txtSoTien.Text = gridViewTienTuThien.GetRowCellValue(gridViewTienTuThien.FocusedRowHandle, "sotien").ToString();
            txtTaiTroKhac.Text = gridViewTienTuThien.GetRowCellValue(gridViewTienTuThien.FocusedRowHandle, "taitrokhac").ToString();
            txtTenToChuc.Properties.NullText = gridViewTienTuThien.GetRowCellValue(gridViewTienTuThien.FocusedRowHandle, "tentochuc").ToString();
        }



    }
}