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
        ServerName ServerName = new ServerName();
        DataTable dt = null;

        public BUSDatPhong()
        {
        }

        public DataTable getDatPhong()
        {

            DBDatPhong dbDatPhong = new DBDatPhong(ServerName.userName, "HOTELS");
            DataTable getDatatable = dbDatPhong.getDataTable();

            dt = getDatatable;
            return dt;
        }
    }
}
