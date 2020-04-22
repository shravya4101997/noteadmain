using ConsoleApplication3.PAGEOBJECTS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class SignupTest:launch
    {
        public static void Main()
        {
           
            search s = new search();
            addcart a = new addcart();
            logout n = new logout();
            Launchmethod();
            Login l = new Login();
            l.loginmethod();
            s.searchmethod();
            a.addcartmethod();
            n.logoutmethod();


        }

    }
}
