using DataAccess.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BUSHoaDon
    {
        ServerName serverName = new ServerName();
        DataTable dt = null;

        public BUSHoaDon()
        {
        }

        public DataTable getHoaDon()
        {

            DBHoaDon dBHoaDon = new DBHoaDon(serverName.userName, serverName.nameDataBase);
            DataTable getDatatable = dBHoaDon.getDataTable();

            dt = getDatatable;
            return dt;
        }
    }
}
