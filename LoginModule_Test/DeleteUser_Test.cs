using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LoginModule_Test
{
    /// <summary>
    /// Summary description for DeleteUser_Test
    /// </summary>
    [TestClass]
    public class DeleteUser_Test
    {
        [TestMethod]
        public void LoginModule_DeleteUser_DeleteUser_void()
        {
            LoginComponent.ILoginDataMapper fdm = new FakeILoginDataMapper();
            LoginComponent.Login l = new LoginComponent.Login(fdm);
            l.CreateUser("username10", "123456", "123456");
            bool b = true;
            string hashedpassword = FakeHelper.HashPassword("123456");
            foreach (var x in FakeDatabase.user_table)
            {
                if (x.username.Equals("username10") && x.hashedPassword.Equals(hashedpassword))
                {
                    b = false;
                }
            }          
            Assert.IsTrue(b);
        }
    }
}
