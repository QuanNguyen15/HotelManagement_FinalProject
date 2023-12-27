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
<<<<<<< HEAD
            DBDatPhong dBDatPhong = new DBDatPhong("DESKTOP-2MC26TB\\SQLEXPRESS", "HOTELS");
            DataTable getDatatable = dBDatPhong.getDataTable();
=======
            DBDatPhong dbDatPhong = new DBDatPhong(ServerName.userName, "HOTELS");
            DataTable getDatatable = dbDatPhong.getDataTable();
>>>>>>> 351ba38e7667c961988ab07c7536f417fb62d5c4
            dt = getDatatable;
            return dt;
        }
    }
}
