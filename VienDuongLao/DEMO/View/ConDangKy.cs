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
    public partial class ConDangKy : DevExpress.XtraEditors.XtraForm
    {
        public ConDangKy()
        {
            InitializeComponent();
        }

        private void ConDangKy_Load(object sender, EventArgs e)
        {
            DataTable dthienthi = dn.Get_id_name_PhatTu();
            txtMaPhatTu.Properties.DataSource = dthienthi;
            txtMaPhatTu.Properties.DisplayMember = "id_phattu";
            txtMaPhatTu.Text = txtMatKhau.Text = txtQuyen.Text = txtTenTaiKhoan.Text = "";
        }
        E_DangNhap dn = new E_DangNhap();
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!txtMaPhatTu.Text.Equals("") && !txtMatKhau.Text.Equals("") && !txtQuyen.Text.Equals("") && !txtTenTaiKhoan.Text.Equals(""))
            {
                if (dn.AddNewAccout(txtTenTaiKhoan.Text.Trim(), txtMatKhau.Text.Trim(), txtQuyen.Text.Trim(), txtMaPhatTu.Text.Trim()))
                {

                    XtraMessageBox.Show("Đăng ký thành công tài khoản " + "'" + txtTenTaiKhoan.Text + "'");
                    ConDangKy_Load(sender, e);
                }
                else {
                    XtraMessageBox.Show("Lỗi dữ liệu");
                }
            }
            else{
            XtraMessageBox.Show("Bạn cần điền đủ thông tin!");
            }
        }

        private void btnXoaText_Click(object sender, EventArgs e)
        {
            txtMaPhatTu.Text = txtMatKhau.Text = txtQuyen.Text = txtTenTaiKhoan.Text = "";
        }
    }
}