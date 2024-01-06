using Microsoft.SqlServer.Server;
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

            dt = new DataTable();
            dt = cDB.ExecuteSQLSelect("GetDatPhongChiTiet");
            return dt;
        }

        public DataTable searchDatPhong(classDatPhong Object)
        {

            SqlParameter[] sp = new SqlParameter[1];

            sp[0] = new SqlParameter("@search", SqlDbType.NVarChar, 50);
       
            sp[0].Value = Object.tenKhachHang;

            return cDB.executeSQLselect("searchDatPhong", sp);

        }
        public bool AddDatPhong(classKhachHang khachHang, classHoaDon hoaDon, classDatPhong datPhong, classTaiKhoan TaiKhoan)
        {
            SqlParameter[] sp = new SqlParameter[5];

            sp[0] = new SqlParameter("@idKhachHang", SqlDbType.Int);
            sp[0].Value = khachHang.idKhachHang;
            sp[1] = new SqlParameter("@idPhong", SqlDbType.Int);
            sp[1].Value = khachHang.idKhachHang;
            sp[2] = new SqlParameter("@ngayDat ", SqlDbType.DateTime);
            sp[2].Value = khachHang.idKhachHang;
            sp[3] = new SqlParameter("@ngayTra", SqlDbType.DateTime);
            sp[3].Value = khachHang.idKhachHang;
            sp[4] = new SqlParameter("@idTaiKhoan", SqlDbType.Int);
            sp[4].Value = khachHang.idKhachHang;
            return cDB.executeProcedure("addDatPhong", sp);

        }

        public DataTable getDatPhongMax()
        {
            string sql = " select max(idDatPhong) as BookingID from DatPhong where is_delete = 0";
            dt = new DataTable();
            dt = cDB.getData(sql);
            return dt;
        }

        public bool createDatPhong( classDatPhong Object)
        {
            SqlParameter[] sp = new SqlParameter[6];

            sp[0] = new SqlParameter("@idKhachHang", SqlDbType.Int);
            sp[0].Value = Object.idKhachHang;
            sp[1] = new SqlParameter("@idPhong", SqlDbType.Int);
            sp[1].Value = Object.idPhong;
            sp[2] = new SqlParameter("@ngayDat ", SqlDbType.DateTime);
            sp[2].Value = Object.ngayDat;
            sp[3] = new SqlParameter("@ngayTra", SqlDbType.DateTime);
            sp[3].Value = Object.ngayTra;
            sp[4] = new SqlParameter("@idTaiKhoan", SqlDbType.Int);
            sp[4].Value = Object.idTaiKhoan;
            sp[5] = new SqlParameter("@soLuongNguoi", SqlDbType.Int);
            sp[5].Value = Object.soLuongNguoi;
            return cDB.executeProcedure("creatDatPhong", sp);

        }

       
    }
}
