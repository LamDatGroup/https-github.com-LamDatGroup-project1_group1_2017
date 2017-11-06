using QLP.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLP.Controller
{
    class LoginCtrl
    {
        public static bool CheckDangNhap(string _user ,string _pass)
        {
            return LoginMod.CheckDangNhap(_user,_pass);
        }
    }
}
