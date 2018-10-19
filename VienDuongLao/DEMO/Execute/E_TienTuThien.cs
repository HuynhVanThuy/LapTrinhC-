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
        //Hết
    }
}
