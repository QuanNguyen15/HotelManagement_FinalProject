using DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAL
{
    public class DBHoaDonPhong
    {
        classDataBase cDB = null;
        DataTable dt = null;

        public DBHoaDonPhong() { }

        public DBHoaDonPhong(string sername, string dbname, string user = "", string pass = "")
        {
            cDB = new classDataBase(sername, dbname);

        }

        public bool creatHoaDonPhong(classHoaDonPhong hoaDonPhong)
        {

            SqlParameter[] sp = new SqlParameter[2];

            sp[0] = new SqlParameter("@idHoaDonMax", SqlDbType.Int);
            sp[0].Value = hoaDonPhong.idHoaDon;
            sp[1] = new SqlParameter("@idDatPhongMax", SqlDbType.Int);
            sp[1].Value = hoaDonPhong.idDatPhong;
            return cDB.executeProcedure("CreateHoaDonPhong", sp);
        }

    }
}
