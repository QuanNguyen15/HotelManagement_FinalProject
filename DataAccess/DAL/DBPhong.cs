using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
    public class DBPhong
    {

        
        classDataBase cDB = null;
        DataTable dt = null;

        public DBPhong() { }

        public DBPhong(string sername, string dbname, string user = "", string pass = "")
        {
            cDB = new classDataBase(sername, dbname);

        }

        public DataTable getDataTable()
        {
            string query = "select * from Phong where is_delete = 0";
            dt = new DataTable();
            dt = cDB.getData(query);
            return dt;
        }

        public bool AddPhong(classPhong Object)
        {
            SqlParameter[] sp = new SqlParameter[2];

            sp[0] = new SqlParameter("@tenPhong", SqlDbType.NVarChar, 50);
            sp[0].Value = Object.tenPhong;
            sp[1] = new SqlParameter("@idLoaiPhong", SqlDbType.Int);
            sp[1].Value = Object.idLoaiPhong;
            return cDB.executeProcedure("AddPhong", sp);

        }

        public DataTable searchPhong(classPhong Object)
        {

            SqlParameter[] sp = new SqlParameter[1];

            sp[0] = new SqlParameter("@SearchTermRoom", SqlDbType.NVarChar, 50);
            sp[0].Value = Object.tenPhong;
            return cDB.executeSQLselect("SearchRoom", sp);

        }

        public bool UpdatePhong(classPhong Object)
        {
            SqlParameter[] sp = new SqlParameter[4];

            sp[0] = new SqlParameter("@idPhong", SqlDbType.Int);
            sp[0].Value = Object.idPhong;
            sp[1] = new SqlParameter("@tenPhong", SqlDbType.NVarChar, 50);
            sp[1].Value = Object.tenPhong;
            sp[2] = new SqlParameter("@trangThai", SqlDbType.NVarChar, 50);
            sp[2].Value = Object.trangThai;
            sp[3] = new SqlParameter("@idLoaiPhong", SqlDbType.NVarChar, 50);
            sp[3].Value = Object.idLoaiPhong;

            return cDB.executeProcedure("UpdatePhong", sp);

        }

        public DataTable getRoomAvailable(string loaPhong)
        {
            string query = "select tenPhong , trangThai from Phong where trangThai = 'Available' and is_delete = 0 and idloaiPhong =" + loaPhong;
            dt = new DataTable();
            dt = cDB.getData(query);
            return dt;
        }

        public DataTable getIdPhong(string name)
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@TenPhong", SqlDbType.NVarChar, 50);
            sp[0].Value = name;
            return cDB.executeSQLselect("GetIdPhong", sp);
        }

        public bool updateBookedPhong(classPhong phong)
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@idPhong", SqlDbType.Int);
            sp[0].Value = phong.idPhong;
            return cDB.executeProcedure("updateBookedPhong", sp);
        }

        public DataTable getPhongByName(string name)
        {

            SqlParameter[] sp = new SqlParameter[1];

            sp[0] = new SqlParameter("@tenPhong", SqlDbType.NVarChar, 50);
            sp[0].Value = name;
            return cDB.executeSQLselect("getPhongbyName", sp);

        }

        public DataTable roomInforlb(classPhong Object)
        {

            SqlParameter[] sp = new SqlParameter[1];



            sp[0] = new SqlParameter("@tenPhong", SqlDbType.NVarChar, 50);
            sp[0].Value = Object.tenPhong;

            return cDB.executeSQLselect("roomInforlb", sp);

        }

        public DataTable GetDichVuDatPhong(classPhong Object)
        {

            SqlParameter[] sp = new SqlParameter[1];



            sp[0] = new SqlParameter("@tenPhong", SqlDbType.NVarChar, 50);
            sp[0].Value = Object.tenPhong;

            return cDB.executeSQLselect("GetDichVuDatPhong", sp);

        }
        public DataTable GetDonGiaByIdPhong(classPhong Object)
        {

            SqlParameter[] sp = new SqlParameter[1];



            sp[0] = new SqlParameter("@tenPhong", SqlDbType.NVarChar, 50);
            sp[0].Value = Object.tenPhong;

            return cDB.executeSQLselect("GetDonGiaByIdPhong", sp);

        }

        public bool DeleteDatPhong(classPhong phong)
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@tenPhong", SqlDbType.NVarChar, 100);
            sp[0].Value = phong.tenPhong;
            return cDB.executeProcedure("DeleteDatPhong", sp);
        }

    }
}
