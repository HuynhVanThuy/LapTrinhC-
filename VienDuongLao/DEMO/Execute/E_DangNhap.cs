using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DEMO.Model;
using System.Data.SqlClient;
using System.Data;

namespace DEMO.Execute
{
    class E_DangNhap
    {
        KetNoi con = new KetNoi();
        SqlCommand cmd = new SqlCommand();
        //Phương thức lấy dữ liệu
        public DataTable AllDataTaiKhoan(String tentaikhoan, String matkhau, String quyen)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT * FROM [QuanLyDieuVien].[dbo].[TaiKhoan] WHERE [tentaikhoan] = '" + tentaikhoan + "' and [matkhau] = '" + matkhau + "' and [quyen] = '" + quyen + "' ";
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

        //Phương thức lấy dữ liệu
        public DataTable AllDataTaiKhoanMain(String id_taikhoan)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT * FROM [QuanLyDieuVien].[dbo].[TaiKhoan] WHERE id_taikhoan = '" + id_taikhoan + "' ";
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
        //Phương thức tên
        public DataTable GetDataNamePhatTu(String id_PhatTu)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT [tenphattu] FROM [QuanLyDieuVien].[dbo].[PhatTu] WHERE id_phattu = '" + id_PhatTu + "' ";
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
        //Phương thức tên
        public DataTable Get_id_name_PhatTu()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT id_phattu,tenphattu FROM PhatTu Where id_phattu NOT IN (Select id_phattu From TaiKhoan) ";
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
        //lấy quyền để hiển thị tương ứng
        public DataTable LoadDanhSachQuyen(String id_taikhoan)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT * FROM [QuanLyDieuVien].[dbo].[PhanQuyen] WHERE id_taikhoan = '"+id_taikhoan+"'";
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

        //Cập nhật lại tài khoản
        public bool UpdateTaiKhoan(String id_taikhoan, String tentaikhoan, String matkhau)
        {
            cmd.CommandText = string.Format("UPDATE [QuanLyDieuVien].[dbo].[TaiKhoan] SET [tentaikhoan] = '" + tentaikhoan + "' ,[matkhau] = '" + matkhau + "' WHERE id_taikhoan = '" + id_taikhoan + "'");
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

        //Xử lý đăng ký tài khoản
        public bool AddNewAccout(String tentaikhoan, String matkhau, String quyen, String id_phattu)
        {
            cmd.CommandText = string.Format("INSERT INTO [QuanLyDieuVien].[dbo].[TaiKhoan] ([tentaikhoan] ,[matkhau] ,[quyen] ,[id_phattu] ,[ngaytaotaikhoan]) VALUES ('" + tentaikhoan + "' ,'" + matkhau + "' ,'" + quyen + "' ,'" + id_phattu + "' ,'" + DateTime.Now.ToShortDateString() + "')");
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
        
        //In ấn tài khoản
        public DataTable InTaiKhoan()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT * FROM TaiKhoan ";
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

        public DataTable InTaiKhoanTheoQuyen(String quyen)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT * FROM TaiKhoan WHERE quyen = '"+quyen+"'";
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
    }
}
