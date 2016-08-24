using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginComponent;

namespace LoginModule_Test
{
    class FakeILoginDataMapper : ILoginDataMapper
    {
        public void Create(User u)
        {
            FakeDatabase.SaveUser(u);
        }
        public bool Read(string username)
        {
            foreach (User x in FakeDatabase.user_table)
                {
                    if (x.username.Equals(username))
                    {
                        return true;
                    }
                }
            return false;
        }
        public bool Read(string username, string hashedpassword)
        {
            //med rigtig database ville dette være linq2sql, med lambda
            foreach (User x in FakeDatabase.user_table)
                {
                    if (x.username.Equals(username) && x.hashedPassword.Equals(hashedpassword))
                    {
                    return true;
                    }
                }
            return false;
        }
    }
}
