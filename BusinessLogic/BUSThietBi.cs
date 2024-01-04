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
    public class BUSThietBi
    {
        ServerName serverName = new ServerName();
        DataTable dt = null;

        public BUSThietBi()
        {
        }

        public DataTable getThietBi()
        {

            DBThietBi dBThietBi = new DBThietBi(serverName.userName, serverName.nameDataBase);
            DataTable getDatatable = dBThietBi.getDataTable();

            dt = getDatatable;
            return dt;
        }

        public bool addThietBi(classThietBi Object)
        {
            DBThietBi dBThietBi = new DBThietBi(serverName.userName, serverName.nameDataBase);
            return dBThietBi.AddThietBi(Object);
        }

        public bool deleteThietBi(classThietBi Object)
        {
            DBThietBi dBThietBi = new DBThietBi(serverName.userName, serverName.nameDataBase);
            return dBThietBi.DeleteThietBi(Object);
        }
    }
}
