using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace DEMO.Model
{
    class KetNoi
    {
        private SqlConnection _con;
        string path;
        public SqlConnection Connection
        {
            get { return _con; }
        }

        private SqlCommand _cmd;
        public SqlCommand Cmd
        {
            get { return _cmd; }
            set { _cmd = value; }
        }

        string strCon;
        //Hàm dựng
        public KetNoi() {
            //strCon = @"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Projects\QLXeMay\QLXeMay\Database\QLXeMay.mdf;Integrated Security=True;User Instance=True";
            // strCon = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Database\QLXeMay.mdf;Integrated Security=True;User Instance=True";
            path = Path.GetFullPath(Environment.CurrentDirectory);
            strCon = @"Data Source=VANTHUY-PC\SQLEXPRESS;Initial Catalog=QuanLyDieuVien;Integrated Security=True";
            _con = new SqlConnection(strCon);
        }

        private string error;
        public string Error{
            get { return error; }
            set { error = value; }
        }
        //Xử lý ngoại lệ khi đóng mở kết nối
        public bool openCon() {
            try
            {
                if (_con.State == ConnectionState.Closed) _con.Open();
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
            return true;
        }

        public bool closeCon() {
            try
            {
                if (_con.State == ConnectionState.Open) _con.Close();
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
            return true;
        }

    }
}
