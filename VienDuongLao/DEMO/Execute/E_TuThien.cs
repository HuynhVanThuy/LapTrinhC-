using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DEMO.Model;
using System.Data.SqlClient;
using System.Data;

namespace DEMO.Execute
{
    class E_TuThien
    {
        KetNoi con = new KetNoi();
        SqlCommand cmd = new SqlCommand();
        //Phương thức lấy dữ liệu
        public DataTable AllDataTuThien()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT * FROM ToChucTuThien";
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
        public bool AddDataTCTuThien(String tentochuc ,String nguoidaidien ,String lienhe)
        {
            String ngaytao = DateTime.Now.ToShortDateString();
            cmd.CommandText = string.Format("INSERT INTO [QuanLyDieuVien].[dbo].[ToChucTuThien] ([tentochuc] ,[nguoidaidien] ,[lienhe] ,[ngaytaotochuc]) VALUES (N'" + tentochuc + "' ,N'" + nguoidaidien + "',N'" + lienhe + "' ,CONVERT(date, '" + ngaytao + "', 103))");
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
        public bool UpdateDataTCTuThien(String id_tochuc, String tentochuc, String nguoidaidien, String lienhe)
        {
            cmd.CommandText = string.Format("UPDATE [QuanLyDieuVien].[dbo].[ToChucTuThien] SET [tentochuc] = N'"+tentochuc+"' ,[nguoidaidien] = N'"+nguoidaidien+"' ,[lienhe] = N'"+lienhe+"' WHERE id_tochuc = '"+id_tochuc+"' ");
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
        public bool DeleteDataTCTuThien(String id_tochu)
        {
            cmd.CommandText = string.Format("DELETE FROM [QuanLyDieuVien].[dbo].[ToChucTuThien] WHERE id_tochuc = '" + id_tochu + "' ");
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

        public DataTable TKTuThienToanBoNgay(String tungay, String denngay)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT * FROM ToChucTuThien WHERE ngaytaotochuc BETWEEN CONVERT(date, '" + tungay + "', 103) AND CONVERT(date, '" + denngay + "', 103)";
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

        public DataTable TKTuThienToanBoThang(String nam)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT *, thang = MONTH(ngaytaotochuc) FROM ToChucTuThien WHERE YEAR(ngaytaotochuc) = '" + nam + "'";
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

        public DataTable TKTuThienToanThang(String thang,String nam)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT *, thang = MONTH(ngaytaotochuc) FROM ToChucTuThien WHERE MONTH(ngaytaotochuc) = '" + thang + "' AND YEAR(ngaytaotochuc) = '" + nam + "'";
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
