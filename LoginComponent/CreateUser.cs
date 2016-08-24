using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginComponent
{
    class CreateUser : ICommand
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
        public void Execute()
        {
            if (dm.Read(username))
            {
                throw new Exception("Username is already in use");
            }
            Helper.ChkPasswordlength(password);
            if (!password.Equals(confirmPassword))
            {
                throw new Exception("Passwords do not match");
            }
            User u = new User(username, Helper.HashPassword(password));
            dm.Create(u);
                                  
        }
    }
}
