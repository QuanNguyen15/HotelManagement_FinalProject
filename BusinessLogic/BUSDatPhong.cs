using DataAccess;
using DataAccess.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BUSDatPhong
    {
        ServerName serverName = new ServerName();
        DataTable dt = null;

        public BUSDatPhong()
        {
        }

        public DataTable getDatPhong()
        {

            DBDatPhong dbDatPhong = new DBDatPhong(serverName.userName, serverName.nameDataBase);
            DataTable getDatatable = dbDatPhong.getDataTable();

            dt = getDatatable;
            return dt;
        }

        public DataTable getDataDatPhong(classDatPhong datphong)
        { 
            DBDatPhong dbDatPhong = new DBDatPhong(serverName.userName, serverName.nameDataBase);
            return dbDatPhong.getDataDatPhong(datphong);
        }
        
        public DataTable getDatPhongChiTiet()
        {
            DBDatPhong dbDatPhong = new DBDatPhong(serverName.userName, serverName.nameDataBase);
            return dbDatPhong.getDatPhongChiTiet();
        }
        public DataTable searchDatPhong(classDatPhong Object)
        {
            DBDatPhong dbDatPhong = new DBDatPhong(serverName.userName, serverName.nameDataBase);
            return dbDatPhong.searchDatPhong(Object);
        }
    }
}
