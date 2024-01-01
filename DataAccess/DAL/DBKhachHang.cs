using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAL
{
    public class DBKhachHang
    {
        classDataBase cDB = null;
        DataTable dt = null;

        public DBKhachHang() { }

        public DBKhachHang(string sername, string dbname, string user = "", string pass = "")
        {
            cDB = new classDataBase(sername, dbname);

        }

        public DataTable getDataTable()
        {
            dt = new DataTable();
            dt = cDB.getTable("KhachHang");

            return dt;
        }

        public bool AddKhachHang(classKhachHang Object)
        {
            SqlParameter[] sp = new SqlParameter[6];
            
            sp[0] = new SqlParameter("@hoTen", SqlDbType.NVarChar, 100);
            sp[0].Value = Object.hoTen;            
            sp[1] = new SqlParameter("@gioiTinh", SqlDbType.NVarChar, 20);
            sp[1].Value = Object.gioiTinh;
            sp[2] = new SqlParameter("@soCCCD", SqlDbType.NVarChar, 20);
            sp[2].Value = Object.soCCCD;
            sp[3] = new SqlParameter("@dienThoai", SqlDbType.NVarChar, 20);
            sp[3].Value = Object.dienThoai;
            sp[4] = new SqlParameter("@email", SqlDbType.NVarChar, 100);
            sp[4].Value = Object.email;
            sp[5] = new SqlParameter("@diaChi", SqlDbType.NVarChar, 100);
            sp[5].Value = Object.diaChi;

            return cDB.executeProcedure("AddKhachHang", sp);

        }
    }
}
