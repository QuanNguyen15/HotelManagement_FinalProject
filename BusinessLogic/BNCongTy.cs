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

    public class BNCongTy
    {

        DataTable dt = null;

        public BNCongTy()
        {
        }

        public DataTable getCongTy()
        {
            DBCongTy dbCongTy = new DBCongTy("DESKTOP-9HGBU5H\\SQLEXPRESS", "HOTELS");
            DataTable getDatatable= dbCongTy.getDataTable();
            dt = getDatatable;
            return dt;
        }

    }
}
