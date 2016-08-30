using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginComponent.Model;
using LoginComponent;

namespace LoginModule_Test
{
    static class FakeDatabase
    {
        public static List<User> user_table = new List<User>();
                
        public static void SaveUser(User u)
        {
            user_table.Add(u);
        }
        public static string GetHashedPassword(string username)
        {
            string s = null;
            foreach (User u in user_table)
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
