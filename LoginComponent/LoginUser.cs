using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginComponent
{
    class LoginUser
    {
        private string username, password;
        private ILoginDataMapper dm;

        //skulle return login token
        public LoginUser(string username, string password, ILoginDataMapper dm)
        {
            this.username = username;
            this.password = password;
            this.dm = dm;
        }
        public bool Execute()
        {
            string HashPassword = Helper.HashPassword(password);
            return dm.Read(username, HashPassword);
        }
    }
}
