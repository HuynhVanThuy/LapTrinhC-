using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DEMO.View;
using DevExpress.XtraEditors;
using System.Threading;
using DevExpress.XtraSplashScreen;
using DEMO.Execute;

namespace DEMO
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            var formcon = new FormTrangChinh();//tạo khai báo form cần show ra
            {
                foreach (var child in MdiChildren)// tìm kiếm 
                {
                    if (child.Name == formcon.Name)//kiểm tra tồn
                    {
                        child.Activate();//active
                        child.Activate();
                        return;//trả về
                    }
                }
            }
            formcon.MdiParent = this;//nếu chưa tồn thì gọi nó ra
            formcon.Show();//hiển thị lên﻿
            //Hiển thị tên hiển thị
            lbTenHienThi.Text = FormDangNhap.ten;
            //Phân quyền tỉnh
            if (FormDangNhap.quyen == "User")
            {
                btnDangKyTT.Enabled = btnCapQuyen.Enabled = false;
                DataTable dtDSquyen = dn.LoadDanhSachQuyen(FormDangNhap.mataikhoan);
                if (dtDSquyen.Rows.Count > 0)
                {
                    if ((int)dtDSquyen.Rows[0]["ql_phong"] == 1)
                    {
                        btnThemPhong.Enabled = true;
                    }
                    else
                    {
                        btnThemPhong.Enabled = false;
                    }

                    if ((int)dtDSquyen.Rows[0]["ql_chitietphong"] == 1)
                    {
                        btnChiTietPhong.Enabled = true;
                    }
                    else
                    {
                        btnChiTietPhong.Enabled = false;
                    }

                    if ((int)dtDSquyen.Rows[0]["ql_nguoinuoi"] == 1)
                    {
                        btnNguoiNuoiDuong.Enabled = true;
                    }
                    else
                    {
                        btnNguoiNuoiDuong.Enabled = false;
                    }

                    if ((int)dtDSquyen.Rows[0]["ql_phattu"] == 1)
                    {
                        btnPhatTu.Enabled = true;
                    }
                    else
                    {
                        btnPhatTu.Enabled = false;
                    }
                }
                else
                {
                    btnThemPhong.Enabled = btnChiTietPhong.Enabled = btnPhatTu.Enabled = btnNguoiNuoiDuong.Enabled = false;
                }
            }
            else { }
            //Hiển thị ngày hiện tại
            timer1.Enabled = true;
        }
        E_DangNhap dn = new E_DangNhap();
        private void btnThemPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formcon = new ConThemPhongO();//tạo khai báo form cần show ra
            {
                foreach (var child in MdiChildren)// tìm kiếm 
                {
                    if (child.Name == formcon.Name)//kiểm tra tồn
                    {
                        child.Activate();//active
                        child.Activate();
                        return;//trả về
                    }
                }
            }
            formcon.MdiParent = this;//nếu chưa tồn thì gọi nó ra
            formcon.Show();//hiển thị lên﻿
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formcon = new ConNguoiO();//tạo khai báo form cần show ra
            {
                foreach (var child in MdiChildren)// tìm kiếm 
                {
                    if (child.Name == formcon.Name)//kiểm tra tồn
                    {
                        child.Activate();//active
                        child.Activate();
                        return;//trả về
                    }
                }
            }
            formcon.MdiParent = this;//nếu chưa tồn thì gọi nó ra
            formcon.Show();//hiển thị lên﻿
        }

        private void btnPhatTu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formcon = new ConPhatTu();//tạo khai báo form cần show ra
            {
                foreach (var child in MdiChildren)// tìm kiếm 
                {
                    if (child.Name == formcon.Name)//kiểm tra tồn
                    {
                        child.Activate();//active
                        child.Activate();
                        return;//trả về
                    }
                }
            }
            formcon.MdiParent = this;//nếu chưa tồn thì gọi nó ra
            formcon.Show();//hiển thị lên﻿
        }

        private void btnTCTuThien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formcon = new ConTuThien();//tạo khai báo form cần show ra
            {
                foreach (var child in MdiChildren)// tìm kiếm 
                {
                    if (child.Name == formcon.Name)//kiểm tra tồn
                    {
                        child.Activate();//active
                        child.Activate();
                        return;//trả về
                    }
                }
            }
            formcon.MdiParent = this;//nếu chưa tồn thì gọi nó ra
            formcon.Show();//hiển thị lên﻿
        }

        private void btnTuThien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formcon = new ConTienTuThien();//tạo khai báo form cần show ra
            {
                foreach (var child in MdiChildren)// tìm kiếm 
                {
                    if (child.Name == formcon.Name)//kiểm tra tồn
                    {
                        child.Activate();//active
                        child.Activate();
                        return;//trả về
                    }
                }
            }
            formcon.MdiParent = this;//nếu chưa tồn thì gọi nó ra
            formcon.Show();//hiển thị lên﻿
        }

        private void btnLichTham_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formcon = new ConLichTham();//tạo khai báo form cần show ra
            {
                foreach (var child in MdiChildren)// tìm kiếm 
                {
                    if (child.Name == formcon.Name)//kiểm tra tồn
                    {
                        child.Activate();//active
                        child.Activate();
                        return;//trả về
                    }
                }
            }
            formcon.MdiParent = this;//nếu chưa tồn thì gọi nó ra
            formcon.Show();//hiển thị lên﻿
        }

        private void btnNhapChiTieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formcon = new ConNhapChi();//tạo khai báo form cần show ra
            {
                foreach (var child in MdiChildren)// tìm kiếm 
                {
                    if (child.Name == formcon.Name)//kiểm tra tồn
                    {
                        child.Activate();//active
                        child.Activate();
                        return;//trả về
                    }
                }
            }
            formcon.MdiParent = this;//nếu chưa tồn thì gọi nó ra
            formcon.Show();//hiển thị lên﻿
        }

        private void btnLenLich_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formcon = new ConLenLichViec();//tạo khai báo form cần show ra
            {
                foreach (var child in MdiChildren)// tìm kiếm 
                {
                    if (child.Name == formcon.Name)//kiểm tra tồn
                    {
                        child.Activate();//active
                        child.Activate();
                        return;//trả về
                    }
                }
            }
            formcon.MdiParent = this;//nếu chưa tồn thì gọi nó ra
            formcon.Show();//hiển thị lên﻿
        }

        private void btnSuCo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formcon = new ConSuCo();//tạo khai báo form cần show ra
            {
                foreach (var child in MdiChildren)// tìm kiếm 
                {
                    if (child.Name == formcon.Name)//kiểm tra tồn
                    {
                        child.Activate();//active
                        child.Activate();
                        return;//trả về
                    }
                }
            }
            formcon.MdiParent = this;//nếu chưa tồn thì gọi nó ra
            formcon.Show();//hiển thị lên﻿
        }

        private void btnTimPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formcon = new ConTimPhong();//tạo khai báo form cần show ra
            {
                foreach (var child in MdiChildren)// tìm kiếm 
                {
                    if (child.Name == formcon.Name)//kiểm tra tồn
                    {
                        child.Activate();//active
                        child.Activate();
                        return;//trả về
                    }
                }
            }
            formcon.MdiParent = this;//nếu chưa tồn thì gọi nó ra
            formcon.Show();//hiển thị lên﻿
        }

        private void btnTimNguoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formcon = new ConTimNguoi();//tạo khai báo form cần show ra
            {
                foreach (var child in MdiChildren)// tìm kiếm 
                {
                    if (child.Name == formcon.Name)//kiểm tra tồn
                    {
                        child.Activate();//active
                        child.Activate();
                        return;//trả về
                    }
                }
            }
            formcon.MdiParent = this;//nếu chưa tồn thì gọi nó ra
            formcon.Show();//hiển thị lên﻿
        }

        private void btnTimPhatTu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formcon = new ConTimPhatTu();//tạo khai báo form cần show ra
            {
                foreach (var child in MdiChildren)// tìm kiếm 
                {
                    if (child.Name == formcon.Name)//kiểm tra tồn
                    {
                        child.Activate();//active
                        child.Activate();
                        return;//trả về
                    }
                }
            }
            formcon.MdiParent = this;//nếu chưa tồn thì gọi nó ra
            formcon.Show();//hiển thị lên﻿
        }

        private void btnTimToChuc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formcon = new ConTimTCTuThien();//tạo khai báo form cần show ra
            {
                foreach (var child in MdiChildren)// tìm kiếm 
                {
                    if (child.Name == formcon.Name)//kiểm tra tồn
                    {
                        child.Activate();//active
                        child.Activate();
                        return;//trả về
                    }
                }
            }
            formcon.MdiParent = this;//nếu chưa tồn thì gọi nó ra
            formcon.Show();//hiển thị lên﻿
        }

        private void btnTimLichTham_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formcon = new ConTimLichTham();//tạo khai báo form cần show ra
            {
                foreach (var child in MdiChildren)// tìm kiếm 
                {
                    if (child.Name == formcon.Name)//kiểm tra tồn
                    {
                        child.Activate();//active
                        child.Activate();
                        return;//trả về
                    }
                }
            }
            formcon.MdiParent = this;//nếu chưa tồn thì gọi nó ra
            formcon.Show();//hiển thị lên﻿
        }

        private void btnBCNguoiNgay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formcon = new ConTKNguoiONgay();//tạo khai báo form cần show ra
            {
                foreach (var child in MdiChildren)// tìm kiếm 
                {
                    if (child.Name == formcon.Name)//kiểm tra tồn
                    {
                        child.Activate();//active
                        child.Activate();
                        return;//trả về
                    }
                }
            }
            formcon.MdiParent = this;//nếu chưa tồn thì gọi nó ra
            formcon.Show();//hiển thị lên﻿
        }

        private void btnBCNguoiThang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formcon = new ConTKNguoiOThang();//tạo khai báo form cần show ra
            {
                foreach (var child in MdiChildren)// tìm kiếm 
                {
                    if (child.Name == formcon.Name)//kiểm tra tồn
                    {
                        child.Activate();//active
                        child.Activate();
                        return;//trả về
                    }
                }
            }
            formcon.MdiParent = this;//nếu chưa tồn thì gọi nó ra
            formcon.Show();//hiển thị lên
        }

        private void btnBCNguoiNam_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formcon = new ConTKNguoiNam();//tạo khai báo form cần show ra
            {
                foreach (var child in MdiChildren)// tìm kiếm 
                {
                    if (child.Name == formcon.Name)//kiểm tra tồn
                    {
                        child.Activate();//active
                        child.Activate();
                        return;//trả về
                    }
                }
            }
            formcon.MdiParent = this;//nếu chưa tồn thì gọi nó ra
            formcon.Show();//hiển thị lên
        }

        private void btnBCPhatTuNgay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formcon = new ConTKPhatTuNgay();//tạo khai báo form cần show ra
            {
                foreach (var child in MdiChildren)// tìm kiếm 
                {
                    if (child.Name == formcon.Name)//kiểm tra tồn
                    {
                        child.Activate();//active
                        child.Activate();
                        return;//trả về
                    }
                }
            }
            formcon.MdiParent = this;//nếu chưa tồn thì gọi nó ra
            formcon.Show();//hiển thị lên
        }

        private void btnBCPhatTuThang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formcon = new ConTKPhatTuThang();//tạo khai báo form cần show ra
            {
                foreach (var child in MdiChildren)// tìm kiếm 
                {
                    if (child.Name == formcon.Name)//kiểm tra tồn
                    {
                        child.Activate();//active
                        child.Activate();
                        return;//trả về
                    }
                }
            }
            formcon.MdiParent = this;//nếu chưa tồn thì gọi nó ra
            formcon.Show();//hiển thị lên
        }

        private void btnBCPhatTuNam_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formcon = new ConTKPhatTuNam();//tạo khai báo form cần show ra
            {
                foreach (var child in MdiChildren)// tìm kiếm 
                {
                    if (child.Name == formcon.Name)//kiểm tra tồn
                    {
                        child.Activate();//active
                        child.Activate();
                        return;//trả về
                    }
                }
            }
            formcon.MdiParent = this;//nếu chưa tồn thì gọi nó ra
            formcon.Show();//hiển thị lên
        }

        private void btnBCTuThienNgay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formcon = new ConTKTuThienNgay();//tạo khai báo form cần show ra
            {
                foreach (var child in MdiChildren)// tìm kiếm 
                {
                    if (child.Name == formcon.Name)//kiểm tra tồn
                    {
                        child.Activate();//active
                        child.Activate();
                        return;//trả về
                    }
                }
            }
            formcon.MdiParent = this;//nếu chưa tồn thì gọi nó ra
            formcon.Show();//hiển thị lên
        }

        private void btnBCTuThienThang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formcon = new ConTKTuThienThang();//tạo khai báo form cần show ra
            {
                foreach (var child in MdiChildren)// tìm kiếm 
                {
                    if (child.Name == formcon.Name)//kiểm tra tồn
                    {
                        child.Activate();//active
                        child.Activate();
                        return;//trả về
                    }
                }
            }
            formcon.MdiParent = this;//nếu chưa tồn thì gọi nó ra
            formcon.Show();//hiển thị lên
        }

        private void btnBCTuThienNam_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formcon = new ConTKTuThienNam();//tạo khai báo form cần show ra
            {
                foreach (var child in MdiChildren)// tìm kiếm 
                {
                    if (child.Name == formcon.Name)//kiểm tra tồn
                    {
                        child.Activate();//active
                        child.Activate();
                        return;//trả về
                    }
                }
            }
            formcon.MdiParent = this;//nếu chưa tồn thì gọi nó ra
            formcon.Show();//hiển thị lên
        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
            FormDangNhap f = new FormDangNhap();
            f.ShowDialog();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnCapQuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormPhanQuyen f = new FormPhanQuyen();
            f.ShowDialog();
        }

        private void btnInNguoiNuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formcon = new InNguoiDuocNuoiDuong();//tạo khai báo form cần show ra
            {
                foreach (var child in MdiChildren)// tìm kiếm 
                {
                    if (child.Name == formcon.Name)//kiểm tra tồn
                    {
                        child.Activate();//active
                        child.Activate();
                        return;//trả về
                    }
                }
            }
            formcon.MdiParent = this;//nếu chưa tồn thì gọi nó ra
            formcon.Show();//hiển thị lên
        }

        private void btnChiTietPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formcon = new ConChiTietPhong();//tạo khai báo form cần show ra
            {
                foreach (var child in MdiChildren)// tìm kiếm 
                {
                    if (child.Name == formcon.Name)//kiểm tra tồn
                    {
                        child.Activate();//active
                        child.Activate();
                        return;//trả về
                    }
                }
            }
            formcon.MdiParent = this;//nếu chưa tồn thì gọi nó ra
            formcon.Show();//hiển thị lên
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }
        //Gán giá trị ngày theo thời gian thay đổi
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbNgayThang.Text = DateTime.Now.ToString();
        }

        private void btnXemThongTin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ConXemTaiKhoan c_taikhoan = new ConXemTaiKhoan();
            c_taikhoan.ShowDialog();
        }

        private void btnSuaTT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ConDangKy dk = new ConDangKy();
            dk.ShowDialog();
        }

        private void btnNhapChiNgay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formcon = new ConTKChiTieuNgay();//tạo khai báo form cần show ra
            {
                foreach (var child in MdiChildren)// tìm kiếm 
                {
                    if (child.Name == formcon.Name)//kiểm tra tồn
                    {
                        child.Activate();//active
                        child.Activate();
                        return;//trả về
                    }
                }
            }
            formcon.MdiParent = this;//nếu chưa tồn thì gọi nó ra
            formcon.Show();//hiển thị lên
        }

        private void btnNhapChiThang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formcon = new ConTKChiTieuThang();//tạo khai báo form cần show ra
            {
                foreach (var child in MdiChildren)// tìm kiếm 
                {
                    if (child.Name == formcon.Name)//kiểm tra tồn
                    {
                        child.Activate();//active
                        child.Activate();
                        return;//trả về
                    }
                }
            }
            formcon.MdiParent = this;//nếu chưa tồn thì gọi nó ra
            formcon.Show();//hiển thị lên
        }

        private void btnNhapChiNam_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formcon = new ConTKChiTieuNam();//tạo khai báo form cần show ra
            {
                foreach (var child in MdiChildren)// tìm kiếm 
                {
                    if (child.Name == formcon.Name)//kiểm tra tồn
                    {
                        child.Activate();//active
                        child.Activate();
                        return;//trả về
                    }
                }
            }
            formcon.MdiParent = this;//nếu chưa tồn thì gọi nó ra
            formcon.Show();//hiển thị lên
        }

        private void btnTienTuThienNgay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formcon = new ConTKTienTuThienNgay();//tạo khai báo form cần show ra
            {
                foreach (var child in MdiChildren)// tìm kiếm 
                {
                    if (child.Name == formcon.Name)//kiểm tra tồn
                    {
                        child.Activate();//active
                        child.Activate();
                        return;//trả về
                    }
                }
            }
            formcon.MdiParent = this;//nếu chưa tồn thì gọi nó ra
            formcon.Show();//hiển thị lên
        }

        private void btnTienTuThienThang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formcon = new ConTKTienTuThienThang();//tạo khai báo form cần show ra
            {
                foreach (var child in MdiChildren)// tìm kiếm 
                {
                    if (child.Name == formcon.Name)//kiểm tra tồn
                    {
                        child.Activate();//active
                        child.Activate();
                        return;//trả về
                    }
                }
            }
            formcon.MdiParent = this;//nếu chưa tồn thì gọi nó ra
            formcon.Show();//hiển thị lên
        }

        private void btnTienTuThienNam_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formcon = new ConTKTienTuThienNam();//tạo khai báo form cần show ra
            {
                foreach (var child in MdiChildren)// tìm kiếm 
                {
                    if (child.Name == formcon.Name)//kiểm tra tồn
                    {
                        child.Activate();//active
                        child.Activate();
                        return;//trả về
                    }
                }
            }
            formcon.MdiParent = this;//nếu chưa tồn thì gọi nó ra
            formcon.Show();//hiển thị lên
        }

        private void btnInPhatTu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formcon = new InPhatTu();//tạo khai báo form cần show ra
            {
                foreach (var child in MdiChildren)// tìm kiếm 
                {
                    if (child.Name == formcon.Name)//kiểm tra tồn
                    {
                        child.Activate();//active
                        child.Activate();
                        return;//trả về
                    }
                }
            }
            formcon.MdiParent = this;//nếu chưa tồn thì gọi nó ra
            formcon.Show();//hiển thị lên
        }

        private void btnInTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formcon = new InTaiKhoan();//tạo khai báo form cần show ra
            {
                foreach (var child in MdiChildren)// tìm kiếm 
                {
                    if (child.Name == formcon.Name)//kiểm tra tồn
                    {
                        child.Activate();//active
                        child.Activate();
                        return;//trả về
                    }
                }
            }
            formcon.MdiParent = this;//nếu chưa tồn thì gọi nó ra
            formcon.Show();//hiển thị lên
        }

        private void btnInLichlamViec_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formcon = new InLichLamViec();//tạo khai báo form cần show ra
            {
                foreach (var child in MdiChildren)// tìm kiếm 
                {
                    if (child.Name == formcon.Name)//kiểm tra tồn
                    {
                        child.Activate();//active
                        child.Activate();
                        return;//trả về
                    }
                }
            }
            formcon.MdiParent = this;//nếu chưa tồn thì gọi nó ra
            formcon.Show();//hiển thị lên
        }

        private void btnInLichViengTham_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formcon = new InLichViengTham();//tạo khai báo form cần show ra
            {
                foreach (var child in MdiChildren)// tìm kiếm 
                {
                    if (child.Name == formcon.Name)//kiểm tra tồn
                    {
                        child.Activate();//active
                        child.Activate();
                        return;//trả về
                    }
                }
            }
            formcon.MdiParent = this;//nếu chưa tồn thì gọi nó ra
            formcon.Show();//hiển thị lên
        }

        private void btnInPhongO_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formcon = new InPhongO();//tạo khai báo form cần show ra
            {
                foreach (var child in MdiChildren)// tìm kiếm 
                {
                    if (child.Name == formcon.Name)//kiểm tra tồn
                    {
                        child.Activate();//active
                        child.Activate();
                        return;//trả về
                    }
                }
            }
            formcon.MdiParent = this;//nếu chưa tồn thì gọi nó ra
            formcon.Show();//hiển thị lên
        }

        private void btnInTienTuThien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formcon = new InTienTuThien();//tạo khai báo form cần show ra
            {
                foreach (var child in MdiChildren)// tìm kiếm 
                {
                    if (child.Name == formcon.Name)//kiểm tra tồn
                    {
                        child.Activate();//active
                        child.Activate();
                        return;//trả về
                    }
                }
            }
            formcon.MdiParent = this;//nếu chưa tồn thì gọi nó ra
            formcon.Show();//hiển thị lên
        }

        private void btnInChiTieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formcon = new InchiTieuHangNgay();//tạo khai báo form cần show ra
            {
                foreach (var child in MdiChildren)// tìm kiếm 
                {
                    if (child.Name == formcon.Name)//kiểm tra tồn
                    {
                        child.Activate();//active
                        child.Activate();
                        return;//trả về
                    }
                }
            }
            formcon.MdiParent = this;//nếu chưa tồn thì gọi nó ra
            formcon.Show();//hiển thị lên
        }




    }
}
