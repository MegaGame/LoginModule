using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginComponent
{
    public class User
    {
        public string username { get; }
        public string hashedPassword { get; }

        public User(string username, string hashedPassword)
        {
            this.username = username;
            this.hashedPassword = hashedPassword;
        }
    }
}
