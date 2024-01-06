﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using DataAccess.DAL;
using DataAccess;

namespace BusinessLogic
{
    public class BUSPhongThietBi
    {
        ServerName serverName = new ServerName();

        DataTable dt = null;

        public BUSPhongThietBi()
        {
        }

        public DataTable getPhongThietBi()
        {

            DBPhongThietBi dbPhongThietBi = new DBPhongThietBi(serverName.userName, serverName.nameDataBase);
            DataTable getDatatable = dbPhongThietBi.getDataTable();
            dt = getDatatable;
            return dt;
        }


    }
}
