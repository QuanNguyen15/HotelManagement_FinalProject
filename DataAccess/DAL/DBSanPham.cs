using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAL
{
    public class DBSanPham
    {

        classDataBase cDB = null;
        DataTable dt = null;

        public DBSanPham() { }

        public DBSanPham(string sername, string dbname, string user = "", string pass = "")
        {
            cDB = new classDataBase(sername, dbname);

        }

        public DataTable getDataTable()
        {
            dt = new DataTable();
            dt = cDB.getTable("SanPham");
            return dt;
        }
        
        public DataTable searchSanPam(classSanPham Object)
        {

            SqlParameter[] sp = new SqlParameter[1];

            sp[0] = new SqlParameter("@searchSanPham", SqlDbType.NVarChar, 100);
            sp[0].Value = Object.tenSanPham;
            return cDB.executeSQLselect("SearchSanPhamByName", sp);

        }

        public bool DeleteSanPham(classSanPham Object)
        {
            SqlParameter[] sp = new SqlParameter[1];

            sp[0] = new SqlParameter("@idSanPham", SqlDbType.Int);
            sp[0].Value = Object.id;

            return cDB.executeProcedure("DeleteProduct", sp);

        }
    }
}
