using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginComponent.TechnicalService;

namespace LoginComponent.Model
{
    class CreateUser
    {
        private ILoginDataMapper dm;
        private string username, password, confirmPassword;
        public CreateUser(string username, string password, string confirmPassword, ILoginDataMapper dm)
        {
            this.username = username;
            this.password = password;
            this.confirmPassword = confirmPassword;
            this.dm = dm;          
        }
        public int Execute()
        {
            if (!Helper.ChkUsername(username))
            {
                return 4;
            }
            if (dm.Read(username))
            {
                return 1;
            }
            if (!Helper.ChkPasswordlength(password))
            {
                return 3;
            }
            if (!password.Equals(confirmPassword))
            {
                return 2;
            }
            User u = new User(username, Helper.HashPassword(password));
            dm.Create(u);
            return 0;


        }
    }
}
