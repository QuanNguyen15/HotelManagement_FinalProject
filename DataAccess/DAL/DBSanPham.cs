﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAL
{
    public class DBSanPham
    {

        classDataBase cDB = null;
        DataTable dt = null;

        public DBSanPham() { }

        public DBSanPham(string sername, string dbname, string user = "", string pass = "")
        {
            cDB = new classDataBase(sername, dbname);

        }

        public DataTable getDataTable()
        {
            dt = new DataTable();
            dt = cDB.getTable("SanPham");
            return dt;
        }
    }
}