using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ServerName
    {
        public string userName { get; set; }
        public string nameDataBase { get; set; }

        public string userNameTest { get; set; }
        public string nameDataBaseTest { get; set; }
        public string password { get; set; }

        public string Khai = "DESKTOP-FOV0R60\\SQLEXPRESS";
        public string Viet = "DESKTOP-2MC26TB\\SQLEXPRESS";
        public string Quan = "DESKTOP-9HGBU5H\\SQLEXPRESS";

        public string dataBase = "HOTEL_MANAGEMENT";
        public string dataBaseTesting = "HOTEL_MANAGEMENT_2";


        public ServerName()
        {
            userName = Viet;
            nameDataBase = dataBase;

            ///////////////////////////////////////

            userNameTest = Viet;
            nameDataBaseTest = dataBaseTesting;
        }



    }
}
