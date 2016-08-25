using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LoginModule_Test
{
    [TestClass]
    public class LoginUser_Test
    {
        [TestMethod]
        public void LoginModule_LoginUser_loginSucces_bool()
        {
            bool b = false;
            LoginComponent.ILoginDataMapper fdm = new FakeILoginDataMapper();
            LoginComponent.Login l = new LoginComponent.Login(fdm);
            l.CreateUser("username8", "123456", "123456");
            b = l.LoginUser("username8", "123456");
            Assert.IsTrue(b);
        }
        [TestMethod]
        public void LoginModule_LoginUser_loginFail_bool() //vill ikke pass før rigtig hashning af password er lavet
        {
            bool b = false;
            LoginComponent.ILoginDataMapper fdm = new FakeILoginDataMapper();
            LoginComponent.Login l = new LoginComponent.Login(fdm);
            l.CreateUser("username9", "123456", "123456");
            b = l.LoginUser("username9", "654321");
            Assert.IsTrue(!b);
        }
    }
}
