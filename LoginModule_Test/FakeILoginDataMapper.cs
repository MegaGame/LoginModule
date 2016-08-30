using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginComponent;
using LoginComponent.TechnicalService;
using LoginComponent.Model;

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
            foreach (User x in FakeDatabase.user_table)
                {
                    if (x.username.Equals(username) && x.hashedPassword.Equals(hashedpassword))
                    {
                    return true;
                    }
                }
            return false;
        }
        public bool Delete(string username, string hashedpassword)
        {
            return true;
            //User user = FakeDatabase.user_table.SingleOrDefault(x => x.username.Equals(username) && x.hashedPassword.Equals(hashedpassword));
            //return FakeDatabase.user_table.Remove(user);
        }
        public bool Update(string username, string hashedpassword, User u)
        {
            return true;
        }
    }
}
