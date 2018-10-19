using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DEMO.Execute;
using System.Data.SqlClient;
using System.Data;
using DEMO.Model;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DEMO.Execute
{
    class E_ChiTietPhong
    {
        KetNoi con = new KetNoi();
        SqlCommand cmd = new SqlCommand();
        //Phương thức lấy dữ liệu
        public DataTable AllDataChiTietPhongO()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT ChiTietPhongO.id_chitietphong, ChiTietPhongO.id_nguoinuoi, ChiTietPhongO.id_phongo, NguoiDuocNuoi.hoten, NguoiDuocNuoi.quequan, PhongO.hienco, NguoiDuocNuoi.ngaysinh, PhongO.tenphong FROM ChiTietPhongO INNER JOIN NguoiDuocNuoi ON ChiTietPhongO.id_nguoinuoi = NguoiDuocNuoi.id_nguoinuoi INNER JOIN PhongO ON ChiTietPhongO.id_phongo = PhongO.id_phongo";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.openCon();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.closeCon();
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                cmd.Dispose();
                con.closeCon();
            }
            return dt;
        }
        
        //Lấy dữ liệu cho lookedit người đc nuôi dưỡng
        public DataTable GetDataId_NguoiNuoi()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT id_nguoinuoi, hoten FROM NguoiDuocNuoi Where id_nguoinuoi NOT IN (Select id_nguoinuoi From ChiTietPhongO)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.openCon();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.closeCon();
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                cmd.Dispose();
                con.closeCon();
            }
            return dt;
        }
        //Lấy mã phòng trống
        public DataTable GetDataId_MaPhong()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT id_phongo, tenphong FROM PhongO Where hienco < 4";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.openCon();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.closeCon();
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                cmd.Dispose();
                con.closeCon();
            }
            return dt;
        }
        //Thêm một người mới vào phòng
        public bool AddDataPhongO(String id_nguoinuoi,String id_phongo)
        {
            cmd.CommandText = string.Format("INSERT INTO [QuanLyDieuVien].[dbo].[ChiTietPhongO] ([id_nguoinuoi] ,[id_phongo]) VALUES ('" + id_nguoinuoi + "','" + id_phongo + "')");
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.openCon();
                cmd.ExecuteNonQuery();
                con.closeCon();
                return true;
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                cmd.Dispose();
                con.closeCon();
            }
            return false;
        }
        //lấy dữ liệu số lượng người ở hiện có
        public string LaySoLuongHienCo(string id_phongo)
        {
            cmd.CommandText = string.Format("SELECT [hienco] FROM [QuanLyDieuVien].[dbo].[PhongO] where id_phongo = '" + id_phongo + "'");
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.openCon();
                return cmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                cmd.Dispose();
                con.closeCon();
            }
            return "";
        }
        //Cập nhật lại số lượng người trong phòng
        public bool UpdateQuantityPhong(String id_phongo, String hienco)
        {
            cmd.CommandText = string.Format("UPDATE [QuanLyDieuVien].[dbo].[PhongO] SET [hienco] = '"+hienco+"' WHERE id_phongo = '"+id_phongo+"'");
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.openCon();
                cmd.ExecuteNonQuery();
                con.closeCon();
                return true;
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                cmd.Dispose();
                con.closeCon();
            }
            return false;
        }
        //Lấy dữ liệu cho lookedit mã chi tiết phòng
        public DataTable GetDataId_Id_ChiTietPhong()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT id_chitietphong From ChiTietPhongO";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.openCon();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.closeCon();
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                cmd.Dispose();
                con.closeCon();
            }
            return dt;
        }
        //lấy một mã phòng tương ứng từ chi tiết phòng
        public string LaymaPhongTuongUng(string id_chitietphongo)
        {
            cmd.CommandText = string.Format("Select id_phongo From ChiTietPhongO where id_chitietphong = '"+id_chitietphongo+"' ");
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.openCon();
                return cmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                cmd.Dispose();
                con.closeCon();
            }
            return "";
        }
        //Xóa bỏ 1 trường dữ liệu
        public bool DeleteNguoiTrongPhong(String id_chitietphong)
        {
            cmd.CommandText = string.Format("DELETE FROM [QuanLyDieuVien].[dbo].[ChiTietPhongO] WHERE id_chitietphong = '" + id_chitietphong + "'");
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.openCon();
                cmd.ExecuteNonQuery();
                con.closeCon();
                return true;
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                cmd.Dispose();
                con.closeCon();
            }
            return false;
        }
        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
        //PHẦN XỬ LÝ NỘI DUNG CHO CHỨC NĂNG TÌM KIẾM LIÊN QUAN ĐẾN PHÒNG
        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
        int nam = DateTime.Now.Year;
        public DataTable SeachGetAllData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT ChiTietPhongO.id_chitietphong, PhongO.tenphong, PhongO.hienco,NguoiDuocNuoi.hoten, NguoiDuocNuoi.quequan, '"+nam.ToString()+"'-year(NguoiDuocNuoi.ngaysinh) AS ngaysinh FROM ChiTietPhongO INNER JOIN NguoiDuocNuoi ON ChiTietPhongO.id_nguoinuoi = NguoiDuocNuoi.id_nguoinuoi INNER JOIN PhongO ON ChiTietPhongO.id_phongo = PhongO.id_phongo";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.openCon();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.closeCon();
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                cmd.Dispose();
                con.closeCon();
            }
            return dt;
        }
        //Lấy toàn bộ mã phòng
        public DataTable SeachGetDataId_MaPhong()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT id_phongo, tenphong FROM PhongO";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.openCon();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.closeCon();
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                cmd.Dispose();
                con.closeCon();
            }
            return dt;
        }
        //Tìm theo những điều kiện ràng buộc
        public DataTable SeachDataCoDieuKien(String chuoiDK)
        {
            //XtraMessageBox.Show(chuoiDK);
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT ChiTietPhongO.id_chitietphong, PhongO.tenphong, PhongO.hienco,NguoiDuocNuoi.hoten, NguoiDuocNuoi.quequan, '" + nam.ToString() + "'-year(NguoiDuocNuoi.ngaysinh) AS ngaysinh FROM ChiTietPhongO INNER JOIN NguoiDuocNuoi ON ChiTietPhongO.id_nguoinuoi = NguoiDuocNuoi.id_nguoinuoi INNER JOIN PhongO ON ChiTietPhongO.id_phongo = PhongO.id_phongo" + chuoiDK;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.openCon();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.closeCon();
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                cmd.Dispose();
                con.closeCon();
            }
            return dt;
        }
        //Xem danh sách theo tên phòng tương ứng
        public DataTable DanhSachTheoTenPhong(String tenPhong)
        {
            //XtraMessageBox.Show(chuoiDK);
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT ChiTietPhongO.id_chitietphong, PhongO.tenphong, PhongO.hienco,NguoiDuocNuoi.hoten, NguoiDuocNuoi.quequan, '" + nam.ToString() + "'-year(NguoiDuocNuoi.ngaysinh) AS ngaysinh FROM ChiTietPhongO INNER JOIN NguoiDuocNuoi ON ChiTietPhongO.id_nguoinuoi = NguoiDuocNuoi.id_nguoinuoi INNER JOIN PhongO ON ChiTietPhongO.id_phongo = PhongO.id_phongo WHERE PhongO.tenphong = '" + tenPhong + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.openCon();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.closeCon();
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                cmd.Dispose();
                con.closeCon();
            }
            return dt;
        }

        //hết 
    }
}
