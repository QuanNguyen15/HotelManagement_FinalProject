using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAL
{
    public class DBCongTy
    {

        classDataBase cDB = null;
        DataTable dt = null;

        public DBCongTy() { }

        public DBCongTy(string sername, string dbname, string user = "", string pass = "")
        {
            cDB = new classDataBase(sername, dbname);

        }

        public DataTable getDataTable()
        {
            dt = new DataTable();
            dt = cDB.getTable("CongTy");
            return dt;
        }
    }
}
