using System;
using System.Collections.Generic;
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
            dt = new DataTable();
            dt = cDB.getTable("Phong");
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


    }
}
