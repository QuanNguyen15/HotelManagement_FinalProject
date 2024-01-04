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


    }
}
