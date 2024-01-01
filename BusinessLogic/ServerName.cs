using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ServerName
    {
        public string userName {get ; set;}
        public string password { get; set; }

        public string Quan = "DESKTOP-FOV0R60\\SQLEXPRESS";
        public string Viet = "DESKTOP-2MC26TB\\SQLEXPRESS";
        public ServerName()
        {
            userName = Viet;
        }

    }
}
