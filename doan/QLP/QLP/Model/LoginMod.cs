using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace QLP.Model
{
    class LoginMod
    {
        //Khai Bao Bien
        protected string user { get; set; }
        protected string pass { get; set; }
        //Bien status dung de kiem tra trang thai tai khoan 
        protected bool status { get; set; }
 
        //Ham khoi tao : 2 doi so de kiem tra dang nhap 
        public LoginMod (string _user , string _pass)
        {
            this.user = _user;
            this.user = _pass;
        }
        //Check dang nhap
        public static bool CheckDangNhap(string _user , string _pass)
        {
            bool str;
            //Truyen bien vao
            str = Model.Connection.ExcuteScalar("spCheckDangNhap", CommandType.StoredProcedure,
                new SqlParameter("@IdDangNhap", _user), new SqlParameter("@MatKhau", _pass));
            return str;
        }
    }
}
