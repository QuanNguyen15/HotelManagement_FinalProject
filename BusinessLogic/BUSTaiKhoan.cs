using DataAccess.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BUSTaiKhoan
    {
        ServerName ServerName = new ServerName();
        DataTable dt = null;

        public BUSTaiKhoan()
        {
        }

        public DataTable getKhachHang()
        {

            DBTaiKhoan dBTaiKhoan = new DBTaiKhoan(ServerName.userName, "HOTELS");
            DataTable getDatatable = dBTaiKhoan.getDataTable();

            dt = getDatatable;
            return dt;
        }
    }
}
