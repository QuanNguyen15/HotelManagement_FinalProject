﻿using DataAccess.DAL;
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
        DataTable dt = null;

        public BUSDatPhong()
        {
        }

        public DataTable getCongTy()
        {
            DBCongTy dbCongTy = new DBCongTy("DESKTOP-2MC26TB\\SQLEXPRESS", "HOTELS");
            DataTable getDatatable = dbCongTy.getDataTable();
            dt = getDatatable;
            return dt;
        }
    }
}
