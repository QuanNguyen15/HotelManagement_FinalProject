using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAL
{
    public class DBDichVu
    {

        classDataBase cDB = null;
        DataTable dt = null;

        public DBDichVu() { }

        public DBDichVu(string sername, string dbname, string user = "", string pass = "")
        {
            cDB = new classDataBase(sername, dbname);

        }

        public DataTable getDataTable()
        {
            dt = new DataTable();
            dt = cDB.getTable("DichVu");
            return dt;
        }
        
        public DataTable searchDichVu(classDichVu Object)
        {

            SqlParameter[] sp = new SqlParameter[1];

            sp[0] = new SqlParameter("@searchSanPham", SqlDbType.NVarChar, 100);
            sp[0].Value = Object.tenDichVu;
            return cDB.executeSQLselect("SearchSanPhamByName", sp);

        }

        public bool DeleteDichVu(classDichVu Object)
        {
            SqlParameter[] sp = new SqlParameter[1];

            sp[0] = new SqlParameter("@idSanPham", SqlDbType.Int);
            sp[0].Value = Object.idDichVu;

            return cDB.executeProcedure("DeleteProduct", sp);

        }
    }
}
