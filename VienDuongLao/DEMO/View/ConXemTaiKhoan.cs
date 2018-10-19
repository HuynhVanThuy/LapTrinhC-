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
    public partial class ConXemTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public ConXemTaiKhoan()
        {
            InitializeComponent();
        }

        private void ConXemTaiKhoan_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void ConXemTaiKhoan_Load(object sender, EventArgs e)
        {
            txtXacNhan.Visible = lbxacnhan.Visible = btnHuy.Visible = btnLuu.Visible = false;
            DataTable dtTaiKhoanHienThi = tk.AllDataTaiKhoanMain(FormDangNhap.mataikhoan);
            txtTen.Text = dtTaiKhoanHienThi.Rows[0]["tentaikhoan"].ToString();
            txtMatKhau.Text = dtTaiKhoanHienThi.Rows[0]["matkhau"].ToString();
            lbLoi.Text = "";
            txtMatKhau.Properties.UseSystemPasswordChar = txtXacNhan.Properties.UseSystemPasswordChar = false;
        }

        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            txtXacNhan.Visible = lbxacnhan.Visible = btnHuy.Visible = btnLuu.Visible = true;
            lbmatkhau.Text = "Mật khẩu mới";
            txtMatKhau.Text = txtXacNhan.Text = "";
            lbLoi.Text = "";
            txtMatKhau.Properties.UseSystemPasswordChar = txtXacNhan.Properties.UseSystemPasswordChar = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ConXemTaiKhoan_Load(sender, e);
        }
        E_DangNhap tk = new E_DangNhap();
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!txtMatKhau.Text.Equals("") || !txtTen.Text.Equals("") || txtXacNhan.Text.Equals(""))
            {
                if (trangthai == 1)
                {
                    if (tk.UpdateTaiKhoan(FormDangNhap.mataikhoan, txtTen.Text.Trim(), txtMatKhau.Text.Trim()))
                    {
                        ConXemTaiKhoan_Load(sender, e);
                    }
                    else {
                        XtraMessageBox.Show("Lỗi cơ sở dữ liệu!");
                    }
                }
                else {
                    XtraMessageBox.Show("Kiểm tra lại mật khẩu!");
                }
            }
            else
            {
                XtraMessageBox.Show("bạn cần nhập đủ thông tin tài khoản!");
            }
        }


        int trangthai = 0;
        private void txtXacNhan_EditValueChanged_1(object sender, EventArgs e)
        {
            if (!txtMatKhau.Text.Equals(txtXacNhan.Text))
            {
                lbLoi.Text = "Chưa khớp mật khẩu";
            }
            else
            {
                trangthai = 1;
                lbLoi.Text = "Mật khẩu chấp nhận";
            }
        }

        private void txtMatKhau_EditValueChanged(object sender, EventArgs e)
        {
            if (!txtMatKhau.Text.Equals(txtXacNhan.Text))
            {
                lbLoi.Text = "Chưa khớp mật khẩu";
            }
            else
            {
                lbLoi.Text = "Mật khẩu chấp nhận";
            }
        }

    }
}