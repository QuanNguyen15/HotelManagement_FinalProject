using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAL
{
    public class DBPhongThietBi
    {

        classDataBase cDB = null;
        DataTable dt = null;

        public DBPhongThietBi() { }

        public DBPhongThietBi(string sername, string dbname, string user = "", string pass = "")
        {
            cDB = new classDataBase(sername, dbname);

        }

        public DataTable getDataTable()
        {
            dt = new DataTable();
            dt = cDB.getTable("Phong_ThietBi");
            return dt;
        }


    }
}
