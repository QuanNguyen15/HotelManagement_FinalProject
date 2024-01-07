using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAL
{
    public class DBHoaDon
    {
        classDataBase cDB = null;
        DataTable dt = null;

        public DBHoaDon() { }

        public DBHoaDon(string sername, string dbname, string user = "", string pass = "")
        {
            cDB = new classDataBase(sername, dbname);

        }

        public DataTable getDataTable()
        {
            dt = new DataTable();
            dt = cDB.getTable("HoaDon");
            return dt;
        }

        public DataTable getDataHoaDon()
        {

            dt = new DataTable();
            return cDB.ExecuteSQLSelect("getHoaDon");
        }
        public DataTable searchHoaDon(classHoaDon Object) {

            SqlParameter[] sp = new SqlParameter[1];

            sp[0] = new SqlParameter("@search", SqlDbType.NVarChar, 100);
            sp[0].Value = Object.tenHoaDon;
            return cDB.executeSQLselect("searchHoaDon", sp);

        }

        public DataTable getBooKing(classHoaDon Object)
        {

            SqlParameter[] sp = new SqlParameter[1];

            sp[0] = new SqlParameter("@idHoaDon", SqlDbType.Int);
            sp[0].Value = Object.idHoaDon;
            return cDB.executeSQLselect("getBooking", sp);

        }

        public DataTable getBooKinglable(classHoaDon Object)
        {

            SqlParameter[] sp = new SqlParameter[1];

            sp[0] = new SqlParameter("@idHoaDon", SqlDbType.Int);
            sp[0].Value = Object.idHoaDon;
            return cDB.executeSQLselect("getBookinglb", sp);

        }

        public DataTable searchBooking(classHoaDon Object)
        {

            SqlParameter[] sp = new SqlParameter[1];

            sp[0] = new SqlParameter("@searchValue", SqlDbType.NVarChar);
            sp[0].Value = Object.tenHoaDon;
            return cDB.executeSQLselect("SearchBooking", sp);
        }

        public DataTable getMaxHoaDon()
        {
            dt = new DataTable();
            dt = cDB.getData("select max(idHoaDon) as idBill from HoaDon");
            return dt;
        }

        public bool CreateHoaDon(classHoaDon hoaDon)
        {
            SqlParameter[] sp = new SqlParameter[1];

            sp[0] = new SqlParameter("@idKhachHang", SqlDbType.Int);
            sp[0].Value = hoaDon.idKhachHang;
            return cDB.executeProcedure("creatHoaDon", sp);
        }

        public bool DeleteBooking(classHoaDon hoaDon)
        {
            SqlParameter[] sp = new SqlParameter[1];

            sp[0] = new SqlParameter("@idHoaDon", SqlDbType.Int);
            sp[0].Value = hoaDon.idHoaDon;
            return cDB.executeProcedure("DeleteBooking", sp);
        }

        public DataTable getBill(classHoaDon Object)
        {

            SqlParameter[] sp = new SqlParameter[1];

            sp[0] = new SqlParameter("@tenPhong", SqlDbType.NVarChar ,100);
            sp[0].Value = Object.tenHoaDon;
            return cDB.executeSQLselect("getBill", sp);
        }
    }
}
