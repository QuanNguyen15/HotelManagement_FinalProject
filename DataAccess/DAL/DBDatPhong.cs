using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAL
{
    public class DBDatPhong
    {
        classDataBase cDB = null;
        DataTable dt = null;

        public DBDatPhong() { }

        public DBDatPhong(string sername, string dbname, string user = "", string pass = "")
        {
            cDB = new classDataBase(sername, dbname);

        }

        public DataTable getDataTable()
        {
            dt = new DataTable();
            dt = cDB.getTable("DatPhong");
            return dt;
        }

        public DataTable getDataDatPhong(classDatPhong Object)
        {

            SqlParameter[] sp = new SqlParameter[2];

            sp[0] = new SqlParameter("@idPhong", SqlDbType.Int);
            sp[0].Value = Object.idPhong;
            sp[1] = new SqlParameter("@ngayDat", SqlDbType.DateTime);
            sp[1].Value = Object.ngayDat;

            return cDB.executeSQLselect("GetHoaDonInfoByDatPhong", sp);

        }
        
        public DataTable getDatPhongChiTiet()
        {
            string sql = "select d.idDatPhong,k.hoTen as khachHang ,d.ngayDat,n.hoTen as NhanVien from DatPhong as d, KhachHang as k, TaiKhoan as t ,NhanVien as n\r\n\twhere d.idkhachHang = k.idKhachHang and t.idTaiKhoan = d.idTaiKhoan and t.idNhanVien = n.idNhanVien;";
            dt = new DataTable();
            dt = cDB.getData(sql);
            return dt;
        }

        public DataTable searchDatPhong(classDatPhong Object)
        {

            SqlParameter[] sp = new SqlParameter[1];

            sp[0] = new SqlParameter("@search", SqlDbType.NVarChar, 50);
       
            sp[0].Value = Object.tenKhachHang;

            return cDB.executeSQLselect("searchDatPhong", sp);

        }
    }
}
