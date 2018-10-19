using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DEMO.Model;
using DEMO.Execute;
using DevExpress.XtraReports.UI;

namespace DEMO.View
{
    public partial class ConTimPhong : DevExpress.XtraEditors.XtraForm
    {
        public ConTimPhong()
        {
            InitializeComponent();
        }
        E_ChiTietPhong ctPhong = new E_ChiTietPhong();
        private void ConTimPhong_Load(object sender, EventArgs e)
        {
            HienThi(false);
            gridPhongO.DataSource = ctPhong.SeachGetAllData();

            //Load cho lookupedit mã
            DataTable dtmaPhongSeach = ctPhong.SeachGetDataId_MaPhong();
            txtTenPhong.Properties.DataSource = dtmaPhongSeach;
            txtTenPhong.Properties.DisplayMember = "tenphong";
        }
        //Hiển thị
        public void HienThi(bool kt)
        {
            btnTim.Enabled = kt;
        }
        //kiểm tra check
        private void checkVa_Click(object sender, EventArgs e)
        {
            if (checkVa.Checked)
            {
                checkHoac.Visible = true;
                btnTim.Enabled = false;
            }
            else
            {
                checkHoac.Visible = false;
                btnTim.Enabled = true;
            }
        }

        private void checkHoac_Click(object sender, EventArgs e)
        {
            if (checkHoac.Checked)
            {
                checkVa.Visible = true;
                btnTim.Enabled = false;
            }
            else
            {
                checkVa.Visible = false;
                btnTim.Enabled = true;

            }
        }
        //Xử lý tìm kiếm 
        int nam = DateTime.Now.Year;
        String chuoidkNhieu = "";
        private void btnTim_Click(object sender, EventArgs e)
        {
            if (ttDieuKienTim == "nhieu")
            {
                gridPhongO.DataSource = ctPhong.SeachDataCoDieuKien(chuoidkNhieu);
                txtHoTen.Enabled = txtTuoi.Enabled = txtQueQuan.Enabled = true;
            }
            if (ttDieuKienTim == "mot")
            {
                String chuoidk = "";
                if (txtHoTen.Text.Equals("") && txtQueQuan.Equals("") && txtTuoi.Text.Equals(""))
                {
                    chuoidk = "";
                }
                else
                {
                    chuoidk = chuoidk + " WHERE ";
                    String chuoiTen = "", chuoiTuoi = "", chuoiQueQuan = "", chuoiTenPhong = "";
                    //Tìm kiếm void điều kiện là và
                    if (checkVa.Checked == true)
                    {
                        if (txtHoTen.Text != "")
                        {
                            chuoiTen += " NguoiDuocNuoi.hoten Like N'%" + txtHoTen.Text.Trim() + "%' ";
                        }
                        if (txtTuoi.Text != "")
                        {
                            chuoiTuoi += nam.ToString() + "-year(NguoiDuocNuoi.ngaysinh) = " + txtTuoi.Text + " ";
                        }
                        if (txtQueQuan.Text != "")
                        {
                            chuoiQueQuan = " NguoiDuocNuoi.quequan LIKE N'%" + txtQueQuan.Text + "%' ";
                        }
                        if (txtTenPhong.Text != "")
                        {
                            chuoiTenPhong = " PhongO.tenphong LIKE N'%" + txtTenPhong.Text.Trim() + "%' ";
                        }
                        String[] MangchuoiDK = new String[4];
                        MangchuoiDK[0] = chuoiTen;
                        MangchuoiDK[1] = chuoiTuoi;
                        MangchuoiDK[2] = chuoiQueQuan;
                        MangchuoiDK[3] = chuoiTenPhong;
                        for (int i = 0; i < 4; i++)
                        {
                            if (MangchuoiDK[i] != "")
                            {
                                if (chuoidk != " WHERE ")
                                {
                                    chuoidk = chuoidk + " AND " + MangchuoiDK[i];
                                }
                                else
                                {
                                    chuoidk = chuoidk + MangchuoiDK[i];
                                }
                            }
                        }
                        //Thực hiện tìm dữ liệu
                        if (chuoidk.Equals(" WHERE "))
                        {
                            gridPhongO.DataSource = ctPhong.SeachDataCoDieuKien("");
                        }
                        else
                        {
                            gridPhongO.DataSource = ctPhong.SeachDataCoDieuKien(chuoidk);
                        }
                    }
                    //Tìm kiếm void điều kiện là hoặc
                    if (checkHoac.Checked == true)
                    {
                        if (txtHoTen.Text != "")
                        {
                            chuoiTen += " NguoiDuocNuoi.hoten Like N'%" + txtHoTen.Text.Trim() + "%' ";
                        }
                        if (txtTuoi.Text != "")
                        {
                            chuoiTuoi += nam.ToString() + "-year(NguoiDuocNuoi.ngaysinh) = " + txtTuoi.Text + " ";
                        }
                        if (txtQueQuan.Text != "")
                        {
                            chuoiQueQuan = " NguoiDuocNuoi.quequan LIKE N'%" + txtQueQuan.Text + "%' ";
                        }
                        if (txtTenPhong.Text != "")
                        {
                            chuoiTenPhong = " PhongO.tenphong LIKE N'%" + txtTenPhong.Text.Trim() + "%' ";
                        }
                        String[] MangchuoiDK = new String[4];
                        MangchuoiDK[0] = chuoiTen;
                        MangchuoiDK[1] = chuoiTuoi;
                        MangchuoiDK[2] = chuoiQueQuan;
                        MangchuoiDK[3] = chuoiTenPhong;
                        for (int i = 0; i < 4; i++)
                        {
                            if (MangchuoiDK[i] != "")
                            {
                                if (chuoidk != " WHERE ")
                                {
                                    chuoidk = chuoidk + " OR " + MangchuoiDK[i];
                                }
                                else
                                {
                                    chuoidk = chuoidk + MangchuoiDK[i];
                                }
                            }
                        }
                        //Thực hiện tìm dữ liệu
                        if (chuoidk.Equals(" WHERE "))
                        {
                            gridPhongO.DataSource = ctPhong.SeachDataCoDieuKien("");
                        }
                        else
                        {
                            gridPhongO.DataSource = ctPhong.SeachDataCoDieuKien(chuoidk);
                        }
                    }
                }
            }

        }
        //Trạng thái chọn điều kiện và hoặc
        public void TrangThaiDieuKien(bool dk)
        {
            checkVa.Visible = checkHoac.Visible = dk;
            lbTruyVan.Visible = checkVaNhieu.Visible = checkHoacNhieu.Visible = checkBoQua.Visible = !dk;
        }
        String ttDieuKienTim = "";
        private void lbMotDK_Click(object sender, EventArgs e)
        {
            TrangThaiDieuKien(true);
            ttDieuKienTim = "mot";
            chuoidkNhieu = "";
        }

        private void lbNhieuDK_Click(object sender, EventArgs e)
        {
            TrangThaiDieuKien(false);
            ttDieuKienTim = "nhieu";
            chuoidkNhieu = "";
        }

        private void lbNhieuDK_DoubleClick(object sender, EventArgs e)
        {
            lbTruyVan.Visible = checkBoQua.Visible = checkVa.Visible = checkHoac.Visible = checkVaNhieu.Visible = checkHoacNhieu.Visible = false;
        }

        private void lbMotDK_DoubleClick(object sender, EventArgs e)
        {
            checkBoQua.Visible = checkVa.Visible = checkHoac.Visible = checkVaNhieu.Visible = checkHoacNhieu.Visible = false;
        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                lbTruyVan.Text = lbTruyVan.Text + " họ và tên " + "'" + txtHoTen.Text + "'";
                CheckNhieuDK(false);
                checkVaNhieu.Enabled = checkHoacNhieu.Enabled = btnTim.Enabled = true;
                if (chuoidkNhieu == "")
                {
                    chuoidkNhieu = chuoidkNhieu + " WHERE " + "NguoiDuocNuoi.hoten Like N'%" + txtHoTen.Text.Trim() + "%' ";
                }
                else {
                    chuoidkNhieu = chuoidkNhieu + "NguoiDuocNuoi.hoten Like N'%" + txtHoTen.Text.Trim() + "%' ";
                }
            }
        }

        private void txtTuoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                lbTruyVan.Text = lbTruyVan.Text + " tuổi = " + "'" + txtTuoi.Text + "'";
                CheckNhieuDK(false);
                checkVaNhieu.Enabled = checkHoacNhieu.Enabled = btnTim.Enabled = true;
                if (chuoidkNhieu == "")
                {
                    chuoidkNhieu = chuoidkNhieu + " WHERE " + nam.ToString() + "-year(NguoiDuocNuoi.ngaysinh) = " + txtTuoi.Text + " ";
                }
                else
                {
                    chuoidkNhieu = chuoidkNhieu + nam.ToString() + "-year(NguoiDuocNuoi.ngaysinh) = " + txtTuoi.Text + " ";
                }
            }
        }

        private void txtQueQuan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                lbTruyVan.Text = lbTruyVan.Text + " quê quán = " + "'" + txtQueQuan.Text + "'";
                CheckNhieuDK(false);
                checkVaNhieu.Enabled = checkHoacNhieu.Enabled = btnTim.Enabled = true;
                if (chuoidkNhieu == "")
                {
                    chuoidkNhieu = chuoidkNhieu + " WHERE " + " NguoiDuocNuoi.quequan LIKE N'%" + txtQueQuan.Text + "%' ";
                }
                else
                {
                    chuoidkNhieu = chuoidkNhieu + " NguoiDuocNuoi.quequan LIKE N'%" + txtQueQuan.Text + "%' ";
                }
            }
        }

        private void txtTenPhong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                lbTruyVan.Text = lbTruyVan.Text + " tên phòng = " + "'" + txtTenPhong.Text + "'";
                CheckNhieuDK(false);
                checkVaNhieu.Enabled = checkHoacNhieu.Enabled = btnTim.Enabled = true;
                if (chuoidkNhieu == "")
                {
                    chuoidkNhieu = chuoidkNhieu + " WHERE " + " PhongO.tenphong LIKE N'%" + txtTenPhong.Text + "%' ";
                }
                else
                {
                    chuoidkNhieu = chuoidkNhieu + " PhongO.tenphong LIKE N'%" + txtTenPhong.Text + "%' ";
                }
            }
        }
        //Sự kiện ẩn hiện text box
        public void CheckNhieuDK(bool check)
        {
            txtQueQuan.Enabled = txtTuoi.Enabled = txtHoTen.Enabled = check;
        }
        //nút và
        private void checkVaNhieu_Click(object sender, EventArgs e)
        {
            if (lbTruyVan.Text.Equals("Tìm: "))
            {
                XtraMessageBox.Show("Bạn cần nhập thông tin trước khi chọn điều kiện!");
            }
            else
            {
                lbTruyVan.Text = lbTruyVan.Text + " VÀ ";
                CheckNhieuDK(true);
                checkVaNhieu.Enabled = checkHoacNhieu.Enabled = false;
                chuoidkNhieu = chuoidkNhieu + " AND ";
            }


        }
        //nút hoặc
        private void checkHoacNhieu_Click(object sender, EventArgs e)
        {
            if (lbTruyVan.Text.Equals("Tìm: "))
            {
                XtraMessageBox.Show("Bạn cần nhập thông tin trước khi chọn điều kiện!");
            }
            else
            {
                lbTruyVan.Text = lbTruyVan.Text + " HOẶC ";
                CheckNhieuDK(true);
                checkVaNhieu.Enabled = checkHoacNhieu.Enabled = false;
                chuoidkNhieu = chuoidkNhieu + " OR ";
            }


        }

        private void checkBoQua_Click(object sender, EventArgs e)
        {
            lbTruyVan.Text = "Tìm: ";
            chuoidkNhieu = "";
        }
        //bắt sự kiện thay đổi 1 giá trị trên look
        private void txtTenPhong_EditValueChanged(object sender, EventArgs e)
        {
            //DataTable dtDanhSachTheoTen = ctPhong.DanhSachTheoTenPhong(txtTenPhong.Text.Trim());
            //gridPhongO.DataSource = dtDanhSachTheoTen;
        }

        //---------------------------------------------------//
        //------------------ Xử lý in ấn --------------------//
        private void btnIn_Click(object sender, EventArgs e)
        {
            if (gridVPhongO.RowCount >0)
            {
                //XtraReport rp = new XtraReport();
                //rp.DataSource = gridVPhongO.DataSource;
                //rp.LoadLayout(Application.StartupPath + @"\ReportTimTheoPhong.repx");
                //rp.ShowDesignerDialog();
                //rp.ShowPreviewDialog();
                XtraReport rp = new XtraReport();
                rp.DataSource = gridVPhongO.DataSource;
                rp.LoadLayout(Application.StartupPath + @"\ReportGroupTimTheoPhong.repx");
                rp.ShowDesignerDialog();
                //rp.ShowPreviewDialog();

            }
            else XtraMessageBox.Show("Không có dữ liệu để in", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //Thay đổi nhập cho text họ tên


    }
}