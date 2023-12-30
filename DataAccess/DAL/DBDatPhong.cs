using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAL
{
    public class DBDatPhong
    {
        classDataBase cDB = null;
        DataTable dt = null;

        public DBDatPhong() { }

        public DBDatPhong(string sername, string dbname, string user = "", string pass = "")
        {
            cDB = new classDataBase(sername, dbname);

        }

        public DataTable getDataTable()
        {
            dt = new DataTable();
            dt = cDB.getTable("DatPhong");
            return dt;
        }

        public DataTable getDataDatPhong(classDatPhong Object)
        {

            SqlParameter[] sp = new SqlParameter[2];

            sp[0] = new SqlParameter("@idPhong", SqlDbType.Int);
            sp[0].Value = Object.idPhong;
            sp[1] = new SqlParameter("@ngayDat", SqlDbType.DateTime);
            sp[1].Value = Object.ngayDat;

            return cDB.executeSQLselect("GetHoaDonInfoByDatPhong", sp);

        }
    }
}
