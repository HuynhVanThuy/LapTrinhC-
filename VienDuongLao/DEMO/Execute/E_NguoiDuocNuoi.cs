using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DEMO.Model;
using System.Data;
using DevExpress.XtraEditors;

namespace DEMO.Execute
{
    class E_NguoiDuocNuoi
    {
        //||||||||||||||||||//
        //PHẦN XỬ LÝ CẬP NHẬT
        //||||||||||||||||||//
        //Lấy toàn bộ dữ liệu
        KetNoi con = new KetNoi();
        SqlCommand cmd = new SqlCommand();
        //Phương thức lấy dữ liệu
        public DataTable AllDataPhongO()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT * FROM NguoiDuocNuoi";
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
        //Thêm một người được nhân nuôi dưỡng mới
        public bool AddDataNguoiDuocNuoi(String hoten, String ngaysinh, String quequan, String giayto)
        {
            String ngaytao = DateTime.Now.ToShortDateString();
            cmd.CommandText = string.Format("INSERT INTO [QuanLyDieuVien].[dbo].[NguoiDuocNuoi] ([hoten] ,[ngaysinh] ,[quequan] ,[giayto] ,[ngaytaonguoinuoi]) VALUES (N'" + hoten + "',CONVERT(date, '" + ngaysinh + "', 103),N'" + quequan + "',N'" + giayto + "',CONVERT(date, '" + ngaytao + "', 103))");
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
        //Cập nhật một người được nhận nuôi dưỡng mới
        public bool UpdateDataNguoiDuocNuoi(String id_nguoinuoi, String hoten, String ngaysinh, String quequan, String giayto)
        {
            cmd.CommandText = string.Format("UPDATE [QuanLyDieuVien].[dbo].[NguoiDuocNuoi] SET [hoten] = N'" + hoten + "' ,[ngaysinh] = CONVERT(date, '" + ngaysinh + "', 103)' ,[quequan] = N'" + quequan + "' ,[giayto] = N'" + giayto + "' WHERE id_nguoinuoi = '" + id_nguoinuoi + "' ");
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
        //Xóa bỏ một người được nuôi dưỡng
        public bool DeleteDataNguoiDuocNuoi(String id_nguoinuoi)
        {
            cmd.CommandText = string.Format("DELETE FROM [QuanLyDieuVien].[dbo].[NguoiDuocNuoi] WHERE id_nguoinuoi ='" + id_nguoinuoi + "'");
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



        //||||||||||||||||||//
        //PHẦN XỬ LÝ THỐNG KÊ
        //||||||||||||||||||//
        public DataTable TKNguoiDuocNuoi(String ngaytruoc, String ngaysau)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = " SELECT * FROM NguoiDuocNuoi WHERE ngaytaonguoinuoi BETWEEN CONVERT(date, '" + ngaytruoc + "', 103) AND CONVERT(date, '" + ngaysau + "', 103)";
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

        public DataTable TKNguoiDuocNuoiThang(String thang, String nam)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT *, thangtao = MONTH(ngaytaonguoinuoi) FROM NguoiDuocNuoi WHERE (MONTH(ngaytaonguoinuoi) = '" + thang + "') AND (YEAR(ngaytaonguoinuoi) = '" + nam + "')";
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
        public DataTable TKNguoiDuocNuoiNhieuThang(String nam)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT *, thangtao = MONTH(ngaytaonguoinuoi) FROM NguoiDuocNuoi WHERE YEAR(ngaytaonguoinuoi) = '" + nam + "' ";
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
        public DataTable TKNguoiDuocNuoiToanBoNam()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT * FROM NguoiDuocNuoi";
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

        public DataTable TKNguoiDuocNuoiToanBoNamTheoNhom()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT *, nam=YEAR(ngaytaonguoinuoi)  FROM NguoiDuocNuoi";
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
        public DataTable TKNguoiDuocNuoiMotNamToanBo(String nam)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT *, nam=YEAR(ngaytaonguoinuoi)  FROM NguoiDuocNuoi WHERE YEAR(ngaytaonguoinuoi) = '"+nam+"'";
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

        public DataTable TKNguoiDuocNuoiMotNamTungThang(String nam)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT *, nam=MONTH(ngaytaonguoinuoi)  FROM NguoiDuocNuoi WHERE YEAR(ngaytaonguoinuoi) = '"+nam+"'";
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
        public DataTable TKNguoiDuocNuoiNhieuNamToanBo(String tunam, String dennam)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT *,nam = year(ngaytaonguoinuoi)  FROM NguoiDuocNuoi Where year(ngaytaonguoinuoi) BETWEEN '"+tunam+"' and '"+dennam+"'";
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
        public DataTable TKNguoiDuocNuoiNhieuNamTungNam(String tunam, String dennam)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT *,nam = year(ngaytaonguoinuoi)  FROM NguoiDuocNuoi Where year(ngaytaonguoinuoi) BETWEEN '"+tunam+"' and '"+dennam+"'";
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
        int nam = DateTime.Now.Year;
        public DataTable InNguoiDuocNuoiTuoiNhoHon(String tuoi, String trangthai)
        {
            DataTable dt = new DataTable();

            cmd.CommandText = "SELECT * FROM NguoiDuocNuoi WHERE "+nam+"- YEAR(ngaysinh) "+trangthai+" "+tuoi+""; 
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
