using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicAuthentication.Models
{
    public static class UserValidate
    {

        public static bool Login(string username,string password)
        {
            if (username == "fatih" && password == "1234")
                return true;
            else
                return false;
        }
    }
}