using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LoginComponent.Model
{
    static class Helper
    {
        public static bool ChkUsername(string username)
        {
            //skulle teste om regler for username bliver overholdt
            return true;
        }
        public static bool  ChkPasswordlength(string password)
        {
            if (password == null)
            {
                return false;
            }
            else if (password.Length < 6)
            {
                return false;
            }
            return true;
        }        
        public static string HashPassword(string password)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(password));

            //get hash result after compute it
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits
                //for each byte
                strBuilder.Append(result[i].ToString("x2"));
            }
            return strBuilder.ToString();
        }     
    }
}
