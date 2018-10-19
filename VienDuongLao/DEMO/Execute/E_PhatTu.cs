using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DEMO.Model;
using System.Data.SqlClient;
using System.Data;

namespace DEMO.Execute
{
    class E_PhatTu
    {
        KetNoi con = new KetNoi();
        SqlCommand cmd = new SqlCommand();
        //Phương thức lấy dữ liệu
        public DataTable AllDataPhatTu()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT * FROM PhatTu";
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
        public bool AddDataPhatTu(String tenphattu ,String ngaysinh ,String quequan ,String chucdanh)
        {
            String ngaytao = DateTime.Now.ToShortDateString();
            cmd.CommandText = string.Format("INSERT INTO [QuanLyDieuVien].[dbo].[PhatTu] ([tenphattu] ,[ngaysinh] ,[quequan] ,[chucdanh] ,[ngaytaophattu]) VALUES (N'" + tenphattu + "' ,CONVERT(date, '" + ngaysinh + "', 103) ,N'" + quequan + "' ,N'" + chucdanh + "','" + ngaytao + "')");
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
        public bool UpdateDataPhatTu(String id_phattu, String tenphattu, String ngaysinh, String quequan, String chucdanh)
        {
            cmd.CommandText = string.Format("UPDATE [QuanLyDieuVien].[dbo].[PhatTu] SET [tenphattu] = N'" + tenphattu + "' ,[ngaysinh] = CONVERT(date, '" + ngaysinh + "', 103) ,[quequan] = N'" + quequan + "' ,[chucdanh] = N'" + chucdanh + "' WHERE id_phattu = '" + id_phattu + "' ");
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
        public bool DeleteDataPhatTu(String id_PhatTu)
        {
            cmd.CommandText = string.Format("DELETE FROM [QuanLyDieuVien].[dbo].[PhatTu] WHERE id_PhatTu = '" + id_PhatTu + "' ");
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
        public DataTable TKPhatTuToanBoNgay(String tungay, String denngay)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT * FROM PhatTu WHERE ngaytaophattu BETWEEN CONVERT(date, '" + tungay + "', 103) AND CONVERT(date, '" + denngay + "', 103)";
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
        public DataTable TKPhatTuToanBoThang(String nam)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT * FROM PhatTu WHERE YEAR(ngaytaophattu) = '"+nam+"'";
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
        public DataTable TKPhatTuToanThang(String thang, String nam)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT * FROM PhatTu WHERE MONTH(ngaytaophattu) = '" + thang + "' AND YEAR(ngaytaophattu) = '" + nam + "'";
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

        public DataTable TKPhatTuTatCaNamToanBo()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT *, nam = YEAR(ngaytaophattu) FROM PhatTu";
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

        public DataTable TKPhatTuTungNamTheoThang(String tunam)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT *, thang = MONTH(ngaytaophattu) FROM PhatTu WHERE YEAR(ngaytaophattu) = '" + tunam + "'";
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

        public DataTable TKPhatTuTungNam(String tunam, String dennam)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT *, nam = YEAR(ngaytaophattu) FROM PhatTu WHERE YEAR(ngaytaophattu) BETWEEN '"+tunam+"' AND '"+dennam+"'";
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
