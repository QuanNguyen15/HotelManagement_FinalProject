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
            return cDB.ExecuteSQLSelect("SelectHoaDonPhong");
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

        public DataTable getBillDichVu(classHoaDon Object)
        {

            SqlParameter[] sp = new SqlParameter[1];

            sp[0] = new SqlParameter("@tenPhong", SqlDbType.NVarChar, 100);
            sp[0].Value = Object.tenHoaDon;
            return cDB.executeSQLselect("getBillDichVu", sp);
        }

        public DataTable getBillDetail(classHoaDon Object)
        {

            SqlParameter[] sp = new SqlParameter[1];

            sp[0] = new SqlParameter("@soHoaDon", SqlDbType.Int);
            sp[0].Value = Object.soHoaDon;
            return cDB.executeSQLselect("getBillDetail", sp);
        }

        public DataTable getBillDichVuDetail(classHoaDon Object)
        {

            SqlParameter[] sp = new SqlParameter[1];

            sp[0] = new SqlParameter("@soHoaDon", SqlDbType.Int);
            sp[0].Value = Object.soHoaDon;
            return cDB.executeSQLselect("getBillDichVuDetail", sp);
        }

        public DataTable SearchHoaDonPhongBySoHoaDonNew(classHoaDon Object)
        {

            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@search", SqlDbType.NVarChar, 100);
            sp[0].Value = Object.tenHoaDon;
            return cDB.executeSQLselect("SearchHoaDonPhongBySoHoaDonNew", sp);
        }

        public DataTable SelectTongTienDichVuPhongByMonth(classHoaDon Object)
        {

            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@thang", SqlDbType.NVarChar, 100);
            sp[0].Value = Object.tenHoaDon;
            return cDB.executeSQLselect("SelectTongTienDichVuPhongByMonth", sp);
        }

        public DataTable SelectTongTienPhongByMonth(classHoaDon Object)
        {

            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@thang", SqlDbType.NVarChar, 100);
            sp[0].Value = Object.tenHoaDon;
            return cDB.executeSQLselect("SelectTongTienPhongByMonth", sp);
        }

        public DataTable SelectSoPhongByMonth(classHoaDon Object)
        {

            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@thang", SqlDbType.NVarChar, 100);
            sp[0].Value = Object.tenHoaDon;
            return cDB.executeSQLselect("SelectSoPhongByMonth", sp);
        }

        public DataTable SelectHoaDonByMonthAndYear(classHoaDon Object)
        {

            SqlParameter[] sp = new SqlParameter[2];
            sp[0] = new SqlParameter("@thang", SqlDbType.NVarChar, 100);
            sp[0].Value = Object.tenHoaDon;
            sp[1] = new SqlParameter("@nam", SqlDbType.NVarChar, 100);
            sp[1].Value = Object.loaiHoaDon;
            return cDB.executeSQLselect("SelectHoaDonByMonthAndYear", sp);
        }
    }
}
