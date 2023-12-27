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

    public class BUSCongTy
    {
        ServerName serverName=new ServerName();

        DataTable dt = null;

        public BUSCongTy()
        {
        }

        public DataTable getCongTy()
        {
            
            DBCongTy dbCongTy = new DBCongTy(serverName.userName, "HOTELS");
            DataTable getDatatable= dbCongTy.getDataTable();
            dt = getDatatable;
            return dt;
        }

    }
}
