using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginModule_Test
{
    static class FakeDatabase
    {
        public static List<LoginComponent.User> user_table = new List<LoginComponent.User>();
                
        public static void SaveUser(LoginComponent.User u)
        {
            user_table.Add(u);
        }
        public static string GetHashedPassword(string username)
        {
            string s = "";
            foreach (LoginComponent.User u in user_table)
            {
                if (u.username.Equals(username))
                {
                    s = u.hashedPassword;
                    return s;
                }
            }           
            return s;
        }
    }
}
