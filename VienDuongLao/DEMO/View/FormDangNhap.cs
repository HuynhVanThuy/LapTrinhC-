using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Threading;
using DEMO.View;
using DevExpress.XtraSplashScreen;
using DEMO.Execute;

namespace DEMO.View
{
    public partial class FormDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }
        E_DangNhap dangNhap = new E_DangNhap();
        //gán tên này cho tên hiển thị trên chương trình, biết người đang dùng phần mềm
        public static string ten;
        public static string quyen;
        public static string taikhoan;
        public static string matkhau;
        public static string mataikhoan;
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DataTable dtTaiKhoan = dangNhap.AllDataTaiKhoan(txtTaiKhoan.Text.Trim(), txtMatKhau.Text.Trim(), txtQuyen.Text.Trim());
            if (dtTaiKhoan.Rows.Count > 0)
            {
                mataikhoan = dtTaiKhoan.Rows[0]["id_taikhoan"].ToString();
                //Xử lý tìm tên hiển tên, quyền thị tương ứng
                DataTable dtTenTaiKhoan = dangNhap.GetDataNamePhatTu(dtTaiKhoan.Rows[0]["id_phattu"].ToString());
                ten = dtTenTaiKhoan.Rows[0]["tenphattu"].ToString();
                quyen = txtQuyen.Text.Trim();
                taikhoan = txtTaiKhoan.Text.Trim();
                matkhau = txtMatKhau.Text.Trim();
                this.Hide();
                //Tạo hiệu ứng load
                SplashScreenManager.ShowForm(this, typeof(FormDoi), true, true, false);
                SplashScreenManager.Default.SetWaitFormCaption("Vui lòng đợi...");
                for (int i = 0; i < 50; i++)
                {
                    Thread.Sleep(100);
                }
                SplashScreenManager.CloseForm();
                FormMain f = new FormMain();
                f.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("Thông tin đăng nhập không hợp lệ!");
            }

        }

        private void FormDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMatKhau.Checked == true)
            {
                txtMatKhau.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.Properties.UseSystemPasswordChar = true;
            }
        }


    }
}