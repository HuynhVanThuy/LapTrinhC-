using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DEMO.Model;
using System.Data.SqlClient;
using System.Data;
using DevExpress.XtraEditors;

namespace DEMO.Execute
{
    class E_TienTuThien
    {
        KetNoi con = new KetNoi();
        SqlCommand cmd = new SqlCommand();
        //Phương thức lấy dữ liệu
        public DataTable AllDataTienTuThien()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT TaiTroTuThien.id_taitro, TaiTroTuThien.ngaytaitro, TaiTroTuThien.id_tochuc, TaiTroTuThien.sotien, TaiTroTuThien.taitrokhac, ToChucTuThien.tentochuc, ToChucTuThien.nguoidaidien FROM TaiTroTuThien INNER JOIN ToChucTuThien ON TaiTroTuThien.id_tochuc = ToChucTuThien.id_tochuc";
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
        public bool AddDataTienTuThien(String ngaytaitro, String id_tochuc, String sotien, String taitrokhac)
        {
            cmd.CommandText = string.Format("INSERT INTO [QuanLyDieuVien].[dbo].[TaiTroTuThien] ([ngaytaitro] ,[id_tochuc] ,[sotien] ,[taitrokhac]) VALUES ('" + ngaytaitro + "' ,'" + id_tochuc + "' ,'" + sotien + "' ,N'" + taitrokhac + "')");
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
        public bool UpdateDataTienTuThien(String id_taitro, String ngaytaitro, String id_tochuc, String sotien, String taitrokhac)
        {
            cmd.CommandText = string.Format("UPDATE [QuanLyDieuVien].[dbo].[TaiTroTuThien] SET [ngaytaitro] = '"+ngaytaitro+"' ,[id_tochuc] = '"+id_tochuc+"' ,[sotien] = '"+sotien+"', [taitrokhac] = N'"+taitrokhac+"' WHERE id_taitro = '"+id_taitro+"' ");
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
        public bool DeleteDataTienTuThien(String id_taitro)
        {
            cmd.CommandText = string.Format("DELETE FROM [QuanLyDieuVien].[dbo].[TaiTroTuThien] WHERE id_taitro = '" + id_taitro + "' ");
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
            cmd.CommandText = "SELECT id_tochuc, tentochuc, nguoidaidien FROM ToChucTuThien";
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

        //||||||||||||||||||//
        //PHẦN XỬ LÝ THỐNG KÊ
        //||||||||||||||||||//

        public DataTable TKTienTuThienToanBoNgay(String tungay, String denngay)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT TaiTroTuThien.*, ToChucTuThien.tentochuc, ToChucTuThien.nguoidaidien FROM TaiTroTuThien INNER JOIN ToChucTuThien ON TaiTroTuThien.id_tochuc = ToChucTuThien.id_tochuc WHERE TaiTroTuThien.ngaytaitro BETWEEN CONVERT(date, '" + tungay + "', 103) AND CONVERT(date, '" + denngay + "', 103)";
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
        //Thống kê theo tháng
        public DataTable TKTienTuThienToanBoThang(String nam)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT TaiTroTuThien.*, ToChucTuThien.tentochuc, ToChucTuThien.nguoidaidien FROM TaiTroTuThien INNER JOIN ToChucTuThien ON TaiTroTuThien.id_tochuc = ToChucTuThien.id_tochuc WHERE YEAR(TaiTroTuThien.ngaytaitro) = '" + nam + "'";
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
        public DataTable TKTienTuThienToanThang(String thang, String nam)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT TaiTroTuThien.*, ToChucTuThien.tentochuc, ToChucTuThien.nguoidaidien FROM TaiTroTuThien INNER JOIN ToChucTuThien ON TaiTroTuThien.id_tochuc = ToChucTuThien.id_tochuc WHERE MONTH(TaiTroTuThien.ngaytaitro) = '" + thang + "' AND YEAR(TaiTroTuThien.ngaytaitro) = '" + nam + "'";
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
        //Thống kê theo năm
        public DataTable TKTienTuThienTatCaNamToanBo()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT TaiTroTuThien.*, ToChucTuThien.tentochuc, ToChucTuThien.nguoidaidien, nam = YEAR(TaiTroTuThien.ngaytaitro) FROM TaiTroTuThien INNER JOIN ToChucTuThien ON TaiTroTuThien.id_tochuc = ToChucTuThien.id_tochuc";
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

        public DataTable TKTienTuThienTungNamTheoThang(String tunam)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT TaiTroTuThien.*, ToChucTuThien.tentochuc, ToChucTuThien.nguoidaidien, thang = MONTH(TaiTroTuThien.ngaytaitro) FROM TaiTroTuThien INNER JOIN ToChucTuThien ON TaiTroTuThien.id_tochuc = ToChucTuThien.id_tochuc WHERE YEAR(TaiTroTuThien.ngaytaitro) = '" + tunam + "'";
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

        public DataTable TKTienTuThienTungNam(String tunam, String dennam)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT TaiTroTuThien.*, ToChucTuThien.tentochuc, ToChucTuThien.nguoidaidien, nam = YEAR(TaiTroTuThien.ngaytaitro) FROM TaiTroTuThien INNER JOIN ToChucTuThien ON TaiTroTuThien.id_tochuc = ToChucTuThien.id_tochuc WHERE YEAR(TaiTroTuThien.ngaytaitro) BETWEEN '"+tunam+"' AND '"+dennam+"'";
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
        //  PHẦN XỬ LÝ IN ẤN
        //||||||||||||||||||//

        public DataTable InTienTuThienTheoTien(String tien, String trangthai)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT TaiTroTuThien.id_taitro, TaiTroTuThien.ngaytaitro, TaiTroTuThien.id_tochuc, TaiTroTuThien.sotien, TaiTroTuThien.taitrokhac, ToChucTuThien.tentochuc, ToChucTuThien.nguoidaidien FROM TaiTroTuThien INNER JOIN ToChucTuThien ON TaiTroTuThien.id_tochuc = ToChucTuThien.id_tochuc WHERE TaiTroTuThien.sotien "+trangthai+" '"+tien+"'";
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
        //Hết
    }
}
