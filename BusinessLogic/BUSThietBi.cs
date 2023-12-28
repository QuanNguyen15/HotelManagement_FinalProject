using DataAccess.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BUSThietBi
    {
        ServerName ServerName = new ServerName();
        DataTable dt = null;

        public BUSThietBi()
        {
        }

        public DataTable getKhachHang()
        {

            DBThietBi dBThietBi = new DBThietBi(ServerName.userName, "HOTELS");
            DataTable getDatatable = dBThietBi.getDataTable();

            dt = getDatatable;
            return dt;
        }
    }
}
