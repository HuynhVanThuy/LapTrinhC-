using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DEMO.Model;
using System.Data.SqlClient;
using System.Data;

namespace DEMO.Execute
{
    class E_LichLamViec
    {
        KetNoi con = new KetNoi();
        SqlCommand cmd = new SqlCommand();
        //Phương thức lấy dữ liệu
        public DataTable AllDataNgayLamViec()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT * FROM LichLamViec ORDER BY id_viec DESC";
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
        public DataTable AllDataChiTietViecLam()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT BuoiLamViec.*, PhatTu.tenphattu FROM BuoiLamViec INNER JOIN LichLamViec ON BuoiLamViec.id_viec = LichLamViec.id_viec INNER JOIN PhatTu ON BuoiLamViec.id_phattu = PhatTu.id_phattu ORDER BY id_buoi DESC";
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

        public DataTable AllDataChiTietViecLamTheoMa(String id_viec)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT BuoiLamViec.*, PhatTu.tenphattu FROM BuoiLamViec INNER JOIN LichLamViec ON BuoiLamViec.id_viec = LichLamViec.id_viec INNER JOIN PhatTu ON BuoiLamViec.id_phattu = PhatTu.id_phattu Where LichLamViec.id_viec = '"+id_viec+"' ORDER BY id_buoi DESC";
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

        public DataTable AllDataLichlamViecTheoNgay(String id_viec)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT * FROM LichLamViec WHERE id_viec = '"+id_viec+"' ";
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
        //lấy mã phật tử
        public DataTable AllDataMaPhatTu()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT id_phattu, tenphattu FROM PhatTu";
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
        public bool AddDataLichlamViec(String ngaylam)
        {
            cmd.CommandText = string.Format("INSERT INTO [QuanLyDieuVien].[dbo].[LichLamViec] ([ngaylamviec]) VALUES ('"+ngaylam+"')");
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
        //Thêm chi tiết
        public bool AddDataChiTietlamViec(String tenbuoi ,String id_viec  ,String noidung ,String id_phattu)
        {
            cmd.CommandText = string.Format("INSERT INTO [QuanLyDieuVien].[dbo].[BuoiLamViec] ([tenbuoi] ,[id_viec] ,[noidung] ,[id_phattu]) VALUES (N'"+tenbuoi+"' ,'"+id_viec+"',N'"+noidung+"' ,'"+id_phattu+"')");
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
        public bool UpdateDataNgayLamViec(String id_viec, String ngaylamviec)
        {
            cmd.CommandText = string.Format("UPDATE [QuanLyDieuVien].[dbo].[LichLamViec] SET [ngaylamviec] = '"+ngaylamviec.Split(' ')[0]+"' WHERE id_viec = '"+id_viec+"' ");
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

        public bool UpdateDataChiTietLamViec(String id_buoi, String tenbuoi, String id_viec, String noidung, String id_phattu)
        {
            cmd.CommandText = string.Format("UPDATE [QuanLyDieuVien].[dbo].[BuoiLamViec] SET [tenbuoi] = N'"+tenbuoi+"' ,[id_viec] = '"+id_viec+"' ,[noidung] = N'"+noidung+"' ,[id_phattu] = '"+id_phattu+"' WHERE id_buoi = '"+id_buoi+"' ");
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
        public bool DeleteDataNgayLamViec(String id_viec)
        {
            cmd.CommandText = string.Format("DELETE FROM [QuanLyDieuVien].[dbo].[LichLamViec] WHERE id_viec = '" + id_viec + "' ");
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

        public bool DeleteDataChiTietChi(String id_buoi)
        {
            cmd.CommandText = string.Format("DELETE FROM [QuanLyDieuVien].[dbo].[BuoiLamViec] WHERE id_buoi = '" + id_buoi + "' ");
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
        //||||||||||||||||||//
        //PHẦN XỬ LÝ TÌM KIẾM
        //||||||||||||||||||//
        //Hết
    }
}
