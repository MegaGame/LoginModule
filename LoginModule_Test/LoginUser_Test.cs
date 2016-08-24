using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LoginModule_Test
{
    [TestClass]
    public class LoginUser_Test
    {
        [TestMethod]
        public void LoginModule_LoginUser_login_void()
        {
            bool b = false;
            LoginComponent.ILoginDataMapper fdm = new FakeILoginDataMapper();
            LoginComponent.Login l = new LoginComponent.Login(fdm);
            l.CreateUser("username7", "123456", "123456");
            b = l.LoginUser("username7", "123456");
            Assert.IsTrue(b);
        }
    }
}
