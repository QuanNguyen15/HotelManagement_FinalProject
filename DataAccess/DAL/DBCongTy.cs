using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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


/*        public bool AddCongTy(classCongTy congTy)
        {
            SqlParameter[] sp = new SqlParameter[6];

            sp[0] = new SqlParameter("@maCongTy", SqlDbType.NVarChar, 100);
            sp[0].Value = congTy.maCongTy;

            sp[1] = new SqlParameter("@tenCongTy", SqlDbType.NVarChar, 100);
            sp[1].Value = congTy.tenCongTy;

            sp[2] = new SqlParameter("@dienThoai", SqlDbType.NVarChar, 50);
            sp[2].Value = congTy.dienThoai;

            sp[3] = new SqlParameter("@fax", SqlDbType.NVarChar, 100);
            sp[3].Value = congTy.fax;

            sp[4] = new SqlParameter("@email", SqlDbType.NVarChar, 100);
            sp[4].Value = congTy.email;

            sp[5] = new SqlParameter("@diaChi", SqlDbType.NVarChar, 100);
            sp[5].Value = congTy.diaChi;

            return cDB.executeSQL("AddCongTy", sp);
        }
*/
    }
}
