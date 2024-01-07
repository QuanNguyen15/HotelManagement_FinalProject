using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAL
{
    public class DBThietBi
    {
        classDataBase cDB = null;
        DataTable dt = null;

        public DBThietBi() { }

        public DBThietBi(string sername, string dbname, string user = "", string pass = "")
        {
            cDB = new classDataBase(sername, dbname);

        }

        public DataTable getDataTable()
        {
            dt = new DataTable();
            dt = cDB.getData("select idThietBi,tenThietBi,donGia from ThietBi where is_delete =0");
            return dt;
        }

        public bool DeleteThietBi(classThietBi Object)
        {
            SqlParameter[] sp = new SqlParameter[1];

            sp[0] = new SqlParameter("@idThietBi", SqlDbType.Int);
            sp[0].Value = Object.idThietBi;

            return cDB.executeProcedure("deleteThietBi", sp);

        }

        public bool AddThietBi(classThietBi Object)
        {
            SqlParameter[] sp = new SqlParameter[2];

            sp[0] = new SqlParameter("@tenThietBi", SqlDbType.NVarChar);
            sp[0].Value = Object.tenThietBi;
            sp[1] = new SqlParameter("@donGia", SqlDbType.Decimal);
            sp[1].Value = Object.donGia;

            return cDB.executeProcedure("addThietBi", sp);
        }

        public bool UpdateThietBi(classThietBi Object)
        {
            SqlParameter[] sp = new SqlParameter[3];

            sp[0] = new SqlParameter("@idThietBi", SqlDbType.Int);
            sp[0].Value = Object.idThietBi;
            sp[1] = new SqlParameter("@tenThietBi", SqlDbType.NVarChar , 100);
            sp[1].Value = Object.tenThietBi;
            sp[2] = new SqlParameter("@donGia", SqlDbType.Decimal);
            sp[2].Value = Object.donGia;

            return cDB.executeProcedure("UpdateThietBi", sp);
        }

        public DataTable SearchThietBi(classThietBi Object)
        {

            SqlParameter[] sp = new SqlParameter[1];

            sp[0] = new SqlParameter("@SearchKeyword", SqlDbType.NVarChar, 100);
            sp[0].Value = Object.tenThietBi;

            return cDB.executeSQLselect("SearchThietBi", sp);

        }
    }
}
