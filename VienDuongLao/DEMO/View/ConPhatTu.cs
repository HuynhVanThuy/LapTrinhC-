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
    public partial class ConPhatTu : DevExpress.XtraEditors.XtraForm
    {
        public ConPhatTu()
        {
            InitializeComponent();
        }

        private void ConPhatTu_Load(object sender, EventArgs e)
        {
            ViewLoad(true);
            //Gôm thành 1 hàng bằng cách không cho giá trị chỉnh sửa từng ô
            gridViewPhatTu.OptionsBehavior.Editable = false;
            //Xóa hết toàn bộ text
            XoaText();
        }
        public void ViewLoad(bool kt)
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = kt;
            btnHuyBo.Enabled = btnLuuLai.Enabled = !kt;
            txtChucVu.Enabled = txtHoTen.Enabled = txtMa.Enabled = txtNgaySinh.Enabled = txtQueQuan.Enabled = !kt;
            DataTable dtPhatTu = phatTu.AllDataPhatTu();
            gridPhatTu.DataSource = dtPhatTu;
        }
        public void XoaText()
        {
            txtChucVu.Text = txtHoTen.Text = txtMa.Text = txtNgaySinh.Text = txtQueQuan.Text = "";
        }

        public Boolean KiemTraTextRong()
        {
            if (txtChucVu.Text.Equals("") || txtHoTen.Text.Equals("") || txtNgaySinh.Text.Equals("") || txtQueQuan.Text.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        E_PhatTu phatTu = new E_PhatTu();
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
                if (XtraMessageBox.Show("Bạn chắc chắn muốn xóa " + txtHoTen.Text.Trim() + "?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (phatTu.DeleteDataPhatTu(txtMa.Text.Trim()))
                    {
                        XtraMessageBox.Show("Đã xóa!");
                        ConPhatTu_Load(sender, e);
                    }
                    else
                    {
                        XtraMessageBox.Show("Không thành công!");
                    }
                }
            }
        }

        private void btnLuuLai_Click(object sender, EventArgs e)
        {
            if (trangthai.Equals("them"))
            {
                if (KiemTraTextRong())
                {
                    XtraMessageBox.Show("Bạn cần nhập đủ thông tin!");
                }
                else
                {
                    if (phatTu.AddDataPhatTu(txtHoTen.Text.Trim(), txtNgaySinh.Text.Trim(), txtQueQuan.Text.Trim(), txtChucVu.Text.Trim()))
                    {
                        XtraMessageBox.Show("Thêm dữ liệu thành công");
                        ConPhatTu_Load(sender, e);
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
                    if (phatTu.UpdateDataPhatTu(txtMa.Text.Trim(), txtHoTen.Text.Trim(), txtNgaySinh.Text.Trim(), txtQueQuan.Text.Trim(), txtChucVu.Text.Trim()))
                    {
                        XtraMessageBox.Show("Cập nhật dữ liệu thành công");
                        ConPhatTu_Load(sender, e);
                    }
                    else
                    {
                        XtraMessageBox.Show("Cập nhật dữ liệu thất bại");
                    }
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            ConPhatTu_Load(sender,e);
        }

        private void gridViewPhatTu_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtChucVu.Text = gridViewPhatTu.GetRowCellValue(gridViewPhatTu.FocusedRowHandle, "chucdanh").ToString();
            txtHoTen.Text = gridViewPhatTu.GetRowCellValue(gridViewPhatTu.FocusedRowHandle, "tenphattu").ToString();
            txtMa.Text = gridViewPhatTu.GetRowCellValue(gridViewPhatTu.FocusedRowHandle, "id_phattu").ToString();
            var mangNgaySinh = gridViewPhatTu.GetRowCellValue(gridViewPhatTu.FocusedRowHandle, "ngaysinh").ToString().Split(' ');
            txtNgaySinh.Text = mangNgaySinh[0];
            txtQueQuan.Text = gridViewPhatTu.GetRowCellValue(gridViewPhatTu.FocusedRowHandle, "quequan").ToString();
        }
    }
}