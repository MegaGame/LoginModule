using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginComponent.TechnicalService;

namespace LoginComponent.Model
{
    class UpdateUser
    {
        private ILoginDataMapper dm;
        private string newConfirmPassword;
        private string newPassword;
        private string password;
        private string username;

        public UpdateUser(string username, string password, string newPassword, string newConfirmPassword, ILoginDataMapper dm)
        {
            this.username = username;
            this.password = password;
            this.newPassword = newPassword;
            this.newConfirmPassword = newConfirmPassword;
            this.dm = dm;
        }
        public bool Execute()
        {
            if (newPassword.Equals(newConfirmPassword))
            {
                Helper.ChkPasswordlength(newPassword);
                string hashedPassword = Helper.HashPassword(password);
                string newHashedPassword = Helper.HashPassword(newPassword);
                User u = new User(username, newHashedPassword);
                return dm.Update(username, hashedPassword, u);
            }
            else
            {
                return false;
            }
        }
    }
}
