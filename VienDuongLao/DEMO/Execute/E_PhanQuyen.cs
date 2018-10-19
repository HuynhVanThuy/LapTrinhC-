using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DEMO.Model;
using System.Data.SqlClient;
using System.Data;

namespace DEMO.Execute
{
    class E_PhanQuyen
    {
        KetNoi con = new KetNoi();
        SqlCommand cmd = new SqlCommand();
        //Phương thức lấy dữ liệu
        public DataTable LoadQuyen(String id_phattu)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "Select * From PhanQuyen WHERE id_taikhoan = (SELECT id_taikhoan FROM [QuanLyDieuVien].[dbo].[TaiKhoan] WHERE id_phattu = '"+id_phattu+"')";
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

        public DataTable LoadID_phattu()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT [id_phattu] ,[tenphattu] FROM [QuanLyDieuVien].[dbo].[PhatTu] Where id_phattu IN (Select id_phattu From TaiKhoan WHERE quyen = 'user')";
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

        public DataTable LoadDataQuyen()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT * FROM [QuanLyDieuVien].[dbo].[PhanQuyen]";
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
        public DataTable LoadMaPhanQuyen(String id_phattu)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT id_phanquyen FROM PhanQuyen WHERE id_taikhoan = (SELECT id_taikhoan FROM TaiKhoan WHERE id_phattu = '"+id_phattu+"' )";
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
        public DataTable LoadThongTinTaiKhoan(String id_phattu)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT ngaysinh,quequan FROM PhatTu WHERE id_phattu = '"+id_phattu+"' ";
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

        public DataTable LoadID_taikhoan(String id_phattu)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT id_taikhoan FROM TaiKhoan WHERE id_phattu ='"+id_phattu+"' ";
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
        
        //cập nhật lại trạng thái cho các quyền
        public bool UpdateQuyen(int[] listquyen, String id_phanquyen)
        {
            cmd.CommandText = string.Format("UPDATE [QuanLyDieuVien].[dbo].[PhanQuyen] SET [ql_phong] = '" + listquyen[0] + "' ,[ql_chitietphong] = '" + listquyen[1] + "' ,[ql_nguoinuoi] = '" + listquyen[2] + "' ,[ql_phattu] = '" + listquyen[3] + "' WHERE id_phanquyen = '" + id_phanquyen + "' ");
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
        //Thêm quyền
        public bool AddQuyen( String id_taikhoan)
        {
            cmd.CommandText = string.Format("INSERT INTO [QuanLyDieuVien].[dbo].[PhanQuyen] ([ql_phong] ,[ql_chitietphong] ,[ql_nguoinuoi] ,[ql_phattu] ,[id_taikhoan]) VALUES ('"+0+"' ,'"+0+"' ,'"+0+"' ,'"+0+"' ,'"+id_taikhoan+"') ");
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
        

    }
}
