using DataAccess.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BUSSanPham
    {
        ServerName serverName = new ServerName();

        DataTable dt = null;

        public BUSSanPham()
        {
        }

        public DataTable getSanPham()
        {

            DBSanPham dbSanPham = new DBSanPham(serverName.userName, "HOTELS");
            DataTable getDatatable = dbSanPham.getDataTable();
            dt = getDatatable;
            return dt;
        }
    }
}
