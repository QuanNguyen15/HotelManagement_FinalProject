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
            dt = cDB.getData("select idDichVu,tenDichVu,loaiDichVu,donGia from DichVu where is_delete = 0");
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

            sp[0] = new SqlParameter("@idDichVu", SqlDbType.Int);
            sp[0].Value = Object.idDichVu;

            return cDB.executeProcedure("deleteDichVu", sp);

        }

        public bool AddDichVu(classDichVu Object)
        {
            SqlParameter[] sp = new SqlParameter[3];

            sp[0] = new SqlParameter("@tenDichVu", SqlDbType.NVarChar, 100);
            sp[0].Value = Object.tenDichVu;
            sp[1] = new SqlParameter("@loaiDichVu", SqlDbType.NVarChar, 100);
            sp[1].Value = Object.loaiDichVu;
            sp[2] = new SqlParameter("@donGia", SqlDbType.Decimal);
            sp[2].Value = Object.donGia;


            return cDB.executeProcedure("addDichVu", sp);

        }


    }
}
