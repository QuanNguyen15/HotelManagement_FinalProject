using DataAccess.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BUSNhanVien
    {
        ServerName serverName = new ServerName();

        DataTable dt = null;

        public BUSNhanVien()
        {
        }

        public DataTable getNhanVien()
        {
            DBNhanVien dbNhanVien = new DBNhanVien(serverName.userName, "HOTELS");
            DataTable getDatatable = dbNhanVien.getDataTable();
            dt = getDatatable;
            return dt;
        }

    }
}
