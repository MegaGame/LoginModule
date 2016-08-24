using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginComponent
{
     public class Login
    {
        private ILoginDataMapper dm;

        public Login(ILoginDataMapper dm)
        {
            this.dm = dm;
        }
        public void CreateUser(string username, string password, string confirmPassword)
        {
            new CreateUser(username, password, confirmPassword, dm).Execute();
        }
    }
}
