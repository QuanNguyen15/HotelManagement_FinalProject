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
    public class BUSKhachHang
    {
        ServerName serverName = new ServerName();
        DataTable dt = null;
       
        public BUSKhachHang()
        {
        }

        public DataTable getKhachHang()
        {
            DBKhachHang dBKhachHang = new DBKhachHang(serverName.userName, "HOTELS");
            DataTable getDatatable = dBKhachHang.getDataTable();
            dt = getDatatable;
            return dt;
        }

        public bool addKhachHang(classKhachHang Object)
        {
            DBKhachHang dBKhachHang = new DBKhachHang(serverName.userName, "HOTELS");
            return dBKhachHang.AddKhachHang(Object);
        }

        public bool deleteKhachHang(classKhachHang Object)
        {
            DBKhachHang dBKhachHang = new DBKhachHang(serverName.userName, "HOTELS");
            return dBKhachHang.DeleteKhachHang(Object);
        }
        public bool upDateKhachHang(classKhachHang Object)
        {
            DBKhachHang dBKhachHang = new DBKhachHang(serverName.userName, "HOTELS");
            return dBKhachHang.UpdateKhachHang(Object);
        }

        public DataTable searchKhachHang(classKhachHang Object)
        {
            DBKhachHang dBKhachHang = new DBKhachHang(serverName.userName, "HOTELS");
            return dBKhachHang.searchKhachHang(Object);
        }
    }
}
