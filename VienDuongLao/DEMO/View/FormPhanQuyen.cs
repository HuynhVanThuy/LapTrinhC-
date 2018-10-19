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
    public partial class FormPhanQuyen : DevExpress.XtraEditors.XtraForm
    {
        public FormPhanQuyen()
        {
            InitializeComponent();
        }

        private void FormPhanQuyen_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
        E_PhanQuyen phanquyen = new E_PhanQuyen();
        private void FormPhanQuyen_Load(object sender, EventArgs e)
        {
            //Hiển thị toàn bộ mã và tên phật tử
            DataTable dtId_phattu = phanquyen.LoadID_phattu();
            cbPhatTu.Properties.DataSource = dtId_phattu;
            cbPhatTu.Properties.DisplayMember = "id_phattu";
            btnThayDoi.Enabled = btnHuyBo.Enabled = false;
            //load dữ liệu cho grid view
            DataTable dtPhanQuyen = phanquyen.LoadDataQuyen();
            gridPhanQuyen.DataSource = dtPhanQuyen;
            //HIển thị lại text trống
            txtMaTaiKhoan.Text = txtNgaySinh.Text = txtQueQuan.Text = "";
            //hiển thị lại check trống
            CheckEdit[] listQuyen = new CheckEdit[4] { ckQuanLyPhong, ckChiTietPhong, ckNguoiNuoi, ckPhatTu };
            for (int i = 0; i < 4; i++)
            {
                listQuyen[i].Checked = false;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (!cbPhatTu.Text.Equals(""))
            {
                CheckEdit[] listQuyen = new CheckEdit[4] { ckQuanLyPhong, ckChiTietPhong, ckNguoiNuoi, ckPhatTu };
                
                DataTable dtListQuyen = phanquyen.LoadQuyen(cbPhatTu.Text.Trim());
                if (dtListQuyen.Rows.Count > 0)
                {
                    //Lấy dữ liệu gán cho mã
                    DataTable dtLayMaQuyen = phanquyen.LoadMaPhanQuyen(cbPhatTu.Text.Trim());
                    txtMaTaiKhoan.Text = dtLayMaQuyen.Rows[0]["id_phanquyen"].ToString();
                    //lấy dữ liệu gán cho 2 text thông tin tài khoản
                    DataTable dtLayThongTin = phanquyen.LoadThongTinTaiKhoan(cbPhatTu.Text.Trim());
                    txtNgaySinh.Text = dtLayThongTin.Rows[0]["ngaysinh"].ToString().Split(' ')[0];
                    txtQueQuan.Text = dtLayThongTin.Rows[0]["quequan"].ToString();
                    
                    //Hiển thị load quyền đang có trong dữ liệu
                    int[] quyendb = new int[4] { (int)dtListQuyen.Rows[0]["ql_phong"], (int)dtListQuyen.Rows[0]["ql_chitietphong"], (int)dtListQuyen.Rows[0]["ql_nguoinuoi"], (int)dtListQuyen.Rows[0]["ql_phattu"] };
                    for (int i = 0; i < 4; i++)
                    {
                        if (quyendb[i] == 0)
                        {
                            listQuyen[i].Checked = false;
                        }
                        else
                        {
                            listQuyen[i].Checked = true;
                        }
                    }
                    btnThayDoi.Enabled = btnHuyBo.Enabled = true;
                }
                else {
                    XtraMessageBox.Show("Tài khoản chưa được cấp quyền!");
                }
                
            }
            else {

                XtraMessageBox.Show("Bạn muốn xem quyền cho tài khoản nào?");
            }
            
        }
        //Khởi tạo 1 mảng lưu trữ quyền mới
        int[] maQuyenMoi = new int[4] { 0, 0, 0, 0 };
        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            //Lưu lại thay đổi quyền 
            CheckEdit[] listQuyen = new CheckEdit[4] { ckQuanLyPhong, ckChiTietPhong, ckNguoiNuoi, ckPhatTu };
            for (int i = 0; i < 4; i++)
            {
                if (listQuyen[i].Checked == true)
                {
                    maQuyenMoi[i] = 1;
                }
                else {
                    maQuyenMoi[i] = 0;
                }
            }
            if (phanquyen.UpdateQuyen(maQuyenMoi,txtMaTaiKhoan.Text.Trim()))
            {
                XtraMessageBox.Show("Đã cập nhật hệ thống phân quyền!");
                FormPhanQuyen_Load(sender, e);
            }

            else
            {
                XtraMessageBox.Show("Lỗi dữ liệu!");
            }
        }

        private void gridViewPhanQuyen_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            
        }


        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            FormPhanQuyen_Load(sender, e);
        }

        private void btnCapQuyen_Click(object sender, EventArgs e)
        {
            //Lấy dữ liệu gán cho mã
            DataTable dtLayMaQuyen = phanquyen.LoadID_taikhoan(cbPhatTu.Text.Trim());
            txtMaTaiKhoan.Text = dtLayMaQuyen.Rows[0]["id_taikhoan"].ToString();
            if (phanquyen.AddQuyen(txtMaTaiKhoan.Text.Trim()))
            {
                XtraMessageBox.Show("Cấp quyền thành công!");
            }
            else{
                XtraMessageBox.Show("Lỗi dữ liệu!");
            }
        }

    }
}