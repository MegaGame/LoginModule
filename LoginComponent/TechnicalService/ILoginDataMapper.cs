using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginComponent.Model;

namespace LoginComponent.TechnicalService
{
    public interface ILoginDataMapper
    {
        void Create(User u);
        bool Read(string username);
        bool Read(string username, string hashedpassword);
        bool Delete(string username, string hashedpassword);
        bool Update(string username, string hashedpassword, User u);
    }
}
