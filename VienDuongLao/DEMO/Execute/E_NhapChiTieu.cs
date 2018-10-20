using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DEMO.Model;
using System.Data.SqlClient;
using System.Data;

namespace DEMO.Execute
{
    class E_NhapChiTieu
    {
        //||||||||||||||||||//
        //PHẦN XỬ LÝ CẬP NHẬT
        //||||||||||||||||||//
        //Lấy toàn bộ dữ liệu
        KetNoi con = new KetNoi();
        SqlCommand cmd = new SqlCommand();
        //Phương thức lấy dữ liệu
        public DataTable AllDataNgayNhapChiTieu()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT * FROM ChiTieu ORDER BY id_chi DESC";
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

        public DataTable AllDataChiTietNhapChiTieu()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT ChiTietChi.*, PhatTu.tenphattu FROM ChiTietChi INNER JOIN PhatTu ON ChiTietChi.id_phattu = PhatTu.id_phattu ORDER BY id_chitietchi DESC";
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
        public DataTable AllDataNhapChiTieuTheoNgay(String id_chi)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT * FROM ChiTieu WHERE id_chi = '"+id_chi+"' ORDER BY id_chi DESC";
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


        public DataTable AllDataNhapCTChiTieuTheoNgay(String id_chi)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT ChiTietChi.*, PhatTu.tenphattu FROM ChiTietChi INNER JOIN PhatTu ON ChiTietChi.id_phattu = PhatTu.id_phattu WHERE id_chi = '"+id_chi+"' ORDER BY id_chitietchi DESC";
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
        //Lấy toàn bộ tên người chi
        public DataTable GetDataId_nguoichi()
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
        
        //Thêm 
        public bool AddDataNgayNhapChiTieu(String ngaychi)
        {
            String ngaytao = DateTime.Now.ToShortDateString();
            cmd.CommandText = string.Format("INSERT INTO [QuanLyDieuVien].[dbo].[ChiTieu] ([ngaychi]) VALUES (CONVERT(date, '" + ngaychi + "', 103))");
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
        //thêm chi tiết
        public bool AddDataChiTietNhapChi(String tenkhoanchi, String sotien, String id_chi, String id_phattu)
        {
            String ngaytao = DateTime.Now.ToShortDateString();
            cmd.CommandText = string.Format("INSERT INTO [QuanLyDieuVien].[dbo].[ChiTietChi] ([tenkhoanchi] ,[sotien] ,[id_chi] ,[id_phattu]) VALUES (N'"+tenkhoanchi+"' ,'"+sotien+"' ,'"+id_chi+"' ,'"+id_phattu+"')");
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
        public bool UpdateDataNgayNhapChi(String id_chi, String ngaychi)
        {
            cmd.CommandText = string.Format("UPDATE [QuanLyDieuVien].[dbo].[ChiTieu] SET [ngaychi] = CONVERT(date, '" + ngaychi + "', 103) WHERE id_chi = '" + id_chi + "' ");
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

        //cập nhật cho chi tiết
        public bool UpdateChiTietChi(String id_chitietchi, String tenkhoanchi, String sotien, String id_chi, String id_phattu)
        {
            cmd.CommandText = string.Format("UPDATE [QuanLyDieuVien].[dbo].[ChiTietChi] SET [tenkhoanchi] = N'"+tenkhoanchi+"' ,[sotien] = '"+sotien+"' ,[id_chi] = '"+id_chi+"' ,[id_phattu] = '"+id_phattu+"' WHERE id_chitietchi = '" + id_chitietchi + "' ");
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
        public bool DeleteDataNgayNhapChi(String id_chi)
        {
            cmd.CommandText = string.Format("DELETE FROM [QuanLyDieuVien].[dbo].[ChiTieu] WHERE id_chi ='" + id_chi + "'");
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

        public bool DeleteDataChiTietChi(String id_chitietchi)
        {
            cmd.CommandText = string.Format("DELETE FROM [QuanLyDieuVien].[dbo].[ChiTietChi] WHERE id_chitietchi ='" + id_chitietchi + "'");
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
        public DataTable TKChiTieuToanBoNgay(String tungay, String denngay)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT ChiTieu.ngaychi, ChiTietChi.*, PhatTu.tenphattu FROM ChiTietChi INNER JOIN ChiTieu ON ChiTietChi.id_chi = ChiTieu.id_chi INNER JOIN PhatTu ON ChiTietChi.id_phattu = PhatTu.id_phattu WHERE ChiTieu.ngaychi BETWEEN CONVERT(date, '" + tungay + "', 103) AND CONVERT(date, '" + denngay + "', 103)";
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
        public DataTable TKChiTieuToanBoThang(String nam)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT ChiTieu.ngaychi, ChiTietChi.*, PhatTu.tenphattu, thang = MONTH(ChiTieu.ngaychi)  FROM ChiTietChi INNER JOIN ChiTieu ON ChiTietChi.id_chi = ChiTieu.id_chi INNER JOIN PhatTu ON ChiTietChi.id_phattu = PhatTu.id_phattu WHERE YEAR(ChiTieu.ngaychi) = '" + nam + "'";
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
        public DataTable TKChiTieuToanThang(String thang, String nam)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT ChiTieu.ngaychi, ChiTietChi.*, PhatTu.tenphattu FROM ChiTietChi INNER JOIN ChiTieu ON ChiTietChi.id_chi = ChiTieu.id_chi INNER JOIN PhatTu ON ChiTietChi.id_phattu = PhatTu.id_phattu WHERE MONTH(ChiTieu.ngaychi) = '" + thang + "' AND YEAR(ChiTieu.ngaychi) = '" + nam + "'";
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
        //Thống kê năm
        public DataTable TKPhatTuTatCaNamToanBo()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT ChiTieu.ngaychi, ChiTietChi.*, PhatTu.tenphattu, nam = YEAR(ChiTieu.ngaychi) FROM ChiTietChi INNER JOIN ChiTieu ON ChiTietChi.id_chi = ChiTieu.id_chi INNER JOIN PhatTu ON ChiTietChi.id_phattu = PhatTu.id_phattu";
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
            cmd.CommandText = "SELECT ChiTieu.ngaychi, ChiTietChi.*, PhatTu.tenphattu, thang = MONTH(ChiTieu.ngaychi) FROM ChiTietChi INNER JOIN ChiTieu ON ChiTietChi.id_chi = ChiTieu.id_chi INNER JOIN PhatTu ON ChiTietChi.id_phattu = PhatTu.id_phattu WHERE YEAR(ChiTieu.ngaychi) = '" + tunam + "'";
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
            cmd.CommandText = "SELECT ChiTieu.ngaychi, ChiTietChi.*, PhatTu.tenphattu, nam = YEAR(ChiTieu.ngaychi) FROM ChiTietChi INNER JOIN ChiTieu ON ChiTietChi.id_chi = ChiTieu.id_chi INNER JOIN PhatTu ON ChiTietChi.id_phattu = PhatTu.id_phattu WHERE YEAR(ChiTieu.ngaychi) BETWEEN '" + tunam + "' AND '" + dennam + "'";
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
