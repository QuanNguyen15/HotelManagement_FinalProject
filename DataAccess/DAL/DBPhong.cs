using System;
using System.Collections.Generic;
using System.Data;
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

       
    }
}
