using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginComponent
{
    static class Helper
    {
        public static void ChkUsername(string username)
        {

        }
        public static void ChkPasswordlength(string password)
        {
            if (password == null)
            {
                throw new Exception("Password is null");
            }
            else if (password.Length < 6)
            {
                throw new Exception("Password needs to be 6 or more charaters long");
            }
        }
        public static string HashPassword(string password)
        {
            return "sdgokjsdjkg";
        }     
    }
}
