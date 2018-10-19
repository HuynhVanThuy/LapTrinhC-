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
    public partial class ConLenLichViec : DevExpress.XtraEditors.XtraForm
    {
        public ConLenLichViec()
        {
            InitializeComponent();
        }

        private void ConLenLichViec_Load(object sender, EventArgs e)
        {
            HienThi();
            gridViewNgayLam.OptionsBehavior.Editable = false;
            gridViewChiTietViecLam.OptionsBehavior.Editable = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = lbtenNguoiChi.Visible = txtTenPhatTu.Visible = true;
        }
        String trangthai = "";
        public void HienThi() {
           txtMaNgayLam.Enabled = txtNgayLamViec.Enabled = pnChiTiet.Enabled = false;
           btnSua.Enabled = btnThem.Enabled = btnXoa.Enabled = true;
           btnLuuNgayChi.Visible = btnHuyNgayChi.Visible = false;
           btnXemChiTiet.Visible = btnLamMoi.Visible = true;

           btnThemChiTiet.Visible = btnSuaChiTiet.Visible = btnXoaChiTiet.Visible = false;

           btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            //xét giá trị null cho mã phật tử
           txtMaPhatTu.Properties.DataSource = null;
           txtMaPhatTu.Properties.NullText = "";
           txtBuoi.Text = txtMaChiTiet.Text = txtMaNgayLam.Text = txtNgayLamViec.Text = txtNoiDung.Text = txtTenPhatTu.Text = "";
           //Load dữ liệu
           gridNgayLam.DataSource = lichLamViec.AllDataNgayLamViec();
           gridChiTietViecLam.DataSource = lichLamViec.AllDataChiTietViecLam();
           trangthai = "";
           btnLuuChiTiet.Enabled = btnHuyChiTiet.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = btnXoa.Enabled = false;
            btnLuuNgayChi.Visible = btnHuyNgayChi.Visible = true;
            btnXemChiTiet.Visible = btnLamMoi.Visible = false;
            txtNgayLamViec.Enabled = true;
            trangthai = "themngaylam";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = btnXoa.Enabled = false;
            btnLuuNgayChi.Visible = btnHuyNgayChi.Visible = true;
            btnXemChiTiet.Visible = btnLamMoi.Visible = false;
            txtNgayLamViec.Enabled = true;
            trangthai = "suangaylam";
        }
        E_LichLamViec lichLamViec = new E_LichLamViec();
        private void btnLuuNgayChi_Click(object sender, EventArgs e)
        {
            if (trangthai.Equals("themngaylam"))
            {
                if (!txtNgayLamViec.Text.Equals(""))
                {
                    if (lichLamViec.AddDataLichlamViec(txtNgayLamViec.Text.Trim()))
                    {
                        XtraMessageBox.Show("Đã thêm dữ liệu");
                        ConLenLichViec_Load(sender, e);
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

            if (trangthai.Equals("suangaylam"))
            {
                if (!txtMaNgayLam.Text.Equals("") || !txtNgayLamViec.Text.Equals(""))
                {
                    if (lichLamViec.UpdateDataNgayLamViec(txtMaNgayLam.Text.Trim(), txtNgayLamViec.Text.Trim()))
                    {
                        XtraMessageBox.Show("Đã cập nhật dữ liệu");
                        ConLenLichViec_Load(sender, e);
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

        private void btnHuyNgayChi_Click(object sender, EventArgs e)
        {
            ConLenLichViec_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNgayLam.Text.Equals(""))
            {
                XtraMessageBox.Show("Bạn cần chọn ngày cần xóa!");
            }
            else
            {
                if (XtraMessageBox.Show("Dữ liệu sẽ không được phục hồi. Bạn chắc chắn muốn xóa?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (lichLamViec.DeleteDataNgayLamViec(txtMaNgayLam.Text.Trim()))
                    {
                        XtraMessageBox.Show("Đã xóa!");
                        ConLenLichViec_Load(sender, e);
                    }
                    else
                    {
                        XtraMessageBox.Show("Không thành công!");
                    }
                }
            }
        }

        private void gridViewNgayLam_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                txtMaNgayLam.Text = gridViewNgayLam.GetRowCellValue(gridViewNgayLam.FocusedRowHandle, "id_viec").ToString();
                txtNgayLamViec.Text = gridViewNgayLam.GetRowCellValue(gridViewNgayLam.FocusedRowHandle, "ngaylamviec").ToString().Split(' ')[0];
            }
            catch{}
        }

        private void txtNgayLamViec_EditValueChanged(object sender, EventArgs e)
        {
            gridNgayLam.DataSource = lichLamViec.AllDataLichlamViecTheoNgay(txtMaNgayLam.Text.Trim());
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (!txtMaNgayLam.Text.Equals("") || !txtNgayLamViec.Text.Equals(""))
            {
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
                pnChiTiet.Enabled = true;
                btnThemChiTiet.Visible = btnSuaChiTiet.Visible = btnXoaChiTiet.Visible = btnThemChiTiet.Enabled = btnSuaChiTiet.Enabled = btnXoaChiTiet.Enabled = true;
                btnLuuChiTiet.Enabled = btnHuyChiTiet.Enabled = btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;

                //hiển thị tên với mã.
                txtTenPhatTu.Enabled = txtMaChiTiet.Enabled = true;

                //Load dữ liệu cho chi tiết theo mã ngày
                gridChiTietViecLam.DataSource = lichLamViec.AllDataChiTietViecLamTheoMa(txtMaNgayLam.Text.Trim());
            }
            else { 
                XtraMessageBox.Show("Bạn muốn xem chi tiết cho ngày nào?");
            }
           
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ConLenLichViec_Load(sender, e);
        }

        private void btnThemChiTiet_Click(object sender, EventArgs e)
        {
            lbtenNguoiChi.Visible=txtTenPhatTu.Visible = false;
            btnXoaChiTiet.Enabled = btnSuaChiTiet.Enabled = false;
            trangthai = "themchitiet";
            //đổ giá trị cho mã phật tử
            txtMaPhatTu.Properties.DataSource = lichLamViec.AllDataMaPhatTu();
            txtMaPhatTu.Properties.DisplayMember = "id_phattu";
            //Ẩn tên với mã.
            txtTenPhatTu.Enabled = txtMaChiTiet.Enabled = false;

            btnLuuChiTiet.Enabled = btnHuyChiTiet.Enabled = true;
        }

        private void btnSuaChiTiet_Click(object sender, EventArgs e)
        {
            lbtenNguoiChi.Visible = txtTenPhatTu.Visible = false;
            btnXoaChiTiet.Enabled = btnThemChiTiet.Enabled = false;
            trangthai = "suachitiet";
            //đổ giá trị cho mã phật tử
            txtMaPhatTu.Properties.DataSource = lichLamViec.AllDataMaPhatTu();
            txtMaPhatTu.Properties.DisplayMember = "id_phattu";
            //Ẩn tên với mã.
            txtTenPhatTu.Enabled = txtMaChiTiet.Enabled = false;

            btnLuuChiTiet.Enabled = btnHuyChiTiet.Enabled = true;
        }

        private void btnXoaChiTiet_Click(object sender, EventArgs e)
        {
            if (txtMaChiTiet.Text.Equals(""))
            {
                XtraMessageBox.Show("Bạn cần chọn chi tiết cần xóa!");
            }
            else
            {
                if (XtraMessageBox.Show("Dữ liệu không được phục hồi! Bạn chắc chắn muốn xóa?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (lichLamViec.DeleteDataChiTietChi(txtMaChiTiet.Text.Trim()))
                    {
                        XtraMessageBox.Show("Đã xóa!");
                        ConLenLichViec_Load(sender, e);
                    }
                    else
                    {
                        XtraMessageBox.Show("Không thành công!");
                    }
                }
            }
        }

        private void btnLuuChiTiet_Click(object sender, EventArgs e)
        {
            if (trangthai.Equals("themchitiet"))
            {
                if (!txtMaNgayLam.Text.Equals("") || txtBuoi.Text.Equals("") || txtNoiDung.Text.Equals("") || txtMaPhatTu.Text.Equals(""))
                {
                    if (lichLamViec.AddDataChiTietlamViec(txtBuoi.Text.Trim(),txtMaNgayLam.Text.Trim(), txtNoiDung.Text.Trim(), txtMaPhatTu.Text.Trim()))
                    {
                        XtraMessageBox.Show("Đã thêm dữ liệu");
                        ConLenLichViec_Load(sender, e);
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
                if (!txtMaChiTiet.Text.Equals("") || !txtMaNgayLam.Text.Equals("") || txtBuoi.Text.Equals("") || txtNoiDung.Text.Equals("") || txtMaPhatTu.Text.Equals(""))
                {
                    if (lichLamViec.UpdateDataChiTietLamViec(txtMaChiTiet.Text.Trim(),txtBuoi.Text.Trim(),txtMaNgayLam.Text.Trim(), txtNoiDung.Text.Trim(), txtMaPhatTu.Text.Trim()))
                    {
                        XtraMessageBox.Show("đã cập nhật dữ liệu");
                        ConLenLichViec_Load(sender, e);
                    }
                    else
                    {
                        XtraMessageBox.Show("cập nhật dữ liệu thất bại!");
                    }
                }
                else
                {
                    XtraMessageBox.Show("bạn cần cung cấp mã ngày cần cập nhật!");
                }
            }
        }

        private void btnHuyChiTiet_Click(object sender, EventArgs e)
        {
            ConLenLichViec_Load(sender, e);
        }

        private void gridViewChiTietViecLam_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtBuoi.Text = gridViewChiTietViecLam.GetRowCellValue(gridViewChiTietViecLam.FocusedRowHandle,"tenbuoi").ToString();
            txtMaChiTiet.Text = gridViewChiTietViecLam.GetRowCellValue(gridViewChiTietViecLam.FocusedRowHandle, "id_buoi").ToString();
            txtMaNgayLam.Text = gridViewChiTietViecLam.GetRowCellValue(gridViewChiTietViecLam.FocusedRowHandle,"id_viec").ToString();
            txtMaPhatTu.Properties.NullText = gridViewChiTietViecLam.GetRowCellValue(gridViewChiTietViecLam.FocusedRowHandle, "id_phattu").ToString();
            txtNgayLamViec.Text = "";
            txtNoiDung.Text = gridViewChiTietViecLam.GetRowCellValue(gridViewChiTietViecLam.FocusedRowHandle, "noidung").ToString();
            txtTenPhatTu.Text = gridViewChiTietViecLam.GetRowCellValue(gridViewChiTietViecLam.FocusedRowHandle, "tenphattu").ToString();
        }

    }
}