using DataAccess.DAL;
using DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BUSHoaDonPhong
    {
        ServerName serverName = new ServerName();
        DataTable dt = null;

        public BUSHoaDonPhong()
        {
        }

        public bool creatHoaDonPhong(classHoaDonPhong hoaDonPhong)
        {
            DBHoaDonPhong dBHoaDonPhong =new DBHoaDonPhong(serverName.userName, serverName.nameDataBase);
            return dBHoaDonPhong.creatHoaDonPhong(hoaDonPhong);
        }
    }
}
