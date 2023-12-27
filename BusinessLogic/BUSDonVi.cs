using DataAccess.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BUSDonVi
    {
        ServerName ServerName = new ServerName();
        DataTable dt = null;

        public BUSDonVi()
        {
        }

        public DataTable getDonVi()
        {

            DBDonVi dBDonVi = new DBDonVi(ServerName.userName, "HOTELS");
            DataTable getDatatable = dBDonVi.getDataTable();

            dt = getDatatable;
            return dt;
        }
    }
}
