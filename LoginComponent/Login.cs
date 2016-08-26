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
        public int CreateUser(string username, string password, string confirmPassword)
        {
            return new CreateUser(username, password, confirmPassword, dm).Execute();
            //return message
            //0 = user lavet
            //1 = username er alderede taget
            //2 = Password er ikke ens
            //3 = password opfylder ikke kræverne
            //4 = username overholder ikke reglerne for usernames
        }        
        public bool LoginUser(string username, string password)//skulle give en access token istedet.
        {
            
            return new LoginUser(username, password, dm).Execute();
        }
        public bool DeleteUser(string username, string password)
        {
            return new DeleteUser(username, password, dm).Execute();
        }
    }
}
