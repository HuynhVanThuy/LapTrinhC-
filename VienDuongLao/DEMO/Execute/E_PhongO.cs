using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DEMO.Model
{
    class E_PhongO
    {
        KetNoi con = new KetNoi();
        SqlCommand cmd = new SqlCommand();
        //Phương thức lấy dữ liệu
        public DataTable AllDataPhongO()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT * FROM PhongO";
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
        //Thêm phòng ở mới
        public bool AddDataPhongO(String tenphong)
        {
            String dateNow = DateTime.Now.ToShortDateString();
            String toida = "4";
            String hienco = "0";
            String ngaytaophongo = dateNow;
            cmd.CommandText = string.Format("INSERT INTO [QuanLyDieuVien].[dbo].[PhongO] ([tenphong] ,[toida] ,[hienco] ,[ngaytaophongo]) VALUES (N'" + tenphong + "', '" + toida + "','" + hienco + "','" + ngaytaophongo + "')");
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

        //Cập nhập phòng ở
        public bool UpdateDataPhongO(String hienco, String id_phong)
        {
            cmd.CommandText = string.Format("UPDATE [QuanLyDieuVien].[dbo].[PhongO] SET [hienco] = '" + hienco + "' WHERE id_phongo = '" + id_phong + "'");
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
        //Xóa bỏ phòng ở 
        public bool DeleteDataPhongO(String id_phong)
        {
            cmd.CommandText = string.Format("DELETE FROM [QuanLyDieuVien].[dbo].[PhongO] WHERE id_phongo ='"+id_phong+"'");
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
        //hết
    }
}
