using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DEMO.Model;
using System.Data;
using System.Data.SqlClient;

namespace DEMO.Execute
{
    class E_LichViengTham
    {
        KetNoi con = new KetNoi();
        SqlCommand cmd = new SqlCommand();
        //Phương thức lấy dữ liệu
        public DataTable AllDataNgayViengTham()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT * FROM [QuanLyDieuVien].[dbo].[LichViengTham] ORDER BY id_viengtham DESC";
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

        public DataTable AllDataChiTiet()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT BuoiViengTham.*, ToChucTuThien.tentochuc FROM BuoiViengTham INNER JOIN LichViengTham ON BuoiViengTham.id_viengtham = LichViengTham.id_viengtham INNER JOIN ToChucTuThien ON BuoiViengTham.id_tochuc = ToChucTuThien.id_tochuc ORDER BY id_buoi DESC";
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

        //Lấy toàn bộ dữ liệu khi nhấn chi tiết
        public DataTable AllDataChiTietTheoNgay(String id_viengtham)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT BuoiViengTham.*, ToChucTuThien.tentochuc FROM BuoiViengTham INNER JOIN LichViengTham ON BuoiViengTham.id_viengtham = LichViengTham.id_viengtham INNER JOIN ToChucTuThien ON BuoiViengTham.id_tochuc = ToChucTuThien.id_tochuc WHERE BuoiViengTham.id_viengtham = '" + id_viengtham + "' ";
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

        public DataTable GetDataNgayViengTham(String ngay)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT * From LichViengTham Where ngayden = '"+ngay+"'";
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
        
        //Thêm mới
        public bool AddDataNgayTuThien(String ngayden)
        {
            cmd.CommandText = string.Format("INSERT INTO [QuanLyDieuVien].[dbo].[LichViengTham] ([ngayden]) VALUES ('"+ngayden+"')");
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
        //Thêm mới một chi tiết
        public bool AddDataChiTietNgay(String thoigian ,String tenhoatdong ,String ghichu ,String id_tochuc ,String id_viengtham)
        {
            cmd.CommandText = string.Format("INSERT INTO [QuanLyDieuVien].[dbo].[BuoiViengTham] ([thoigian] ,[tenhoatdong] ,[ghichu] ,[id_tochuc] ,[id_viengtham]) VALUES (N'"+thoigian+"' ,N'"+tenhoatdong+"' ,N'"+ghichu+"' ,'"+id_tochuc+"' ,'"+id_viengtham+"')");
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
        
        //Cập nhật 
        public bool UpdateDataNgayViengTham(String id_viengtham, String ngayden)
        {
            cmd.CommandText = string.Format("UPDATE [QuanLyDieuVien].[dbo].[LichViengTham] SET [ngayden] = '"+ngayden+"' WHERE id_viengtham = '"+id_viengtham+"' ");
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
        //Cập nhật chi tiết theo ngày
        public bool UpdateDataChiTietNgay(String id_buoi, String thoigian, String tenhoatdong, String ghichu, String id_tochuc, String id_viengtham)
        {
            cmd.CommandText = string.Format("UPDATE [QuanLyDieuVien].[dbo].[BuoiViengTham] SET [thoigian] = N'" + thoigian + "' ,[tenhoatdong] = N'" + tenhoatdong + "' ,[ghichu] = N'" + ghichu + "' ,[id_tochuc] = '" + id_tochuc + "' ,[id_viengtham] = '" + id_viengtham + "' WHERE id_buoi = '" + id_buoi + "' ");
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
        //Xóa bỏ
        public bool DeleteDataLichChiTiet(String id_buoi)
        {
            cmd.CommandText = string.Format("DELETE FROM [QuanLyDieuVien].[dbo].[BuoiViengTham] WHERE id_buoi = '" + id_buoi + "' ");
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
        //Lấy dữ liệu cho lookedit
        public DataTable GetDataId_ToChuc()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT id_tochuc, tentochuc FROM ToChucTuThien";
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
        //||||||||||||||||||//
        //PHẦN XỬ LÝ TÌM KIẾM
        //||||||||||||||||||//
        //Hết
    }
}
