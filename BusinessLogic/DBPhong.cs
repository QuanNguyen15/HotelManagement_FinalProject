using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class DBPhong
    {
        cDB cDB = null;
        DataTable dt = null;

        public DBPhong() { }

        public DBPhong(string sername, string dbname, string user = "", string pass = "")
        {
            cDB = new cDB(sername, dbname);

        }

        public DataTable getDataTable()
        {
            dt = new DataTable();
            dt = cDB.getTable("Phong");

            return dt;
        }
    }
}
