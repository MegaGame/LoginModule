using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LoginModule_Test
{
    [TestClass]
    public class UpdateUser_Test
    {
        [TestMethod]
        public void LoginModule_UpdateUser_ChangePassword_Bool()
        {
            LoginComponent.TechnicalService.ILoginDataMapper fdm = new FakeILoginDataMapper();
            LoginComponent.Controller.Login l = new LoginComponent.Controller.Login(fdm);
            l.CreateUser("username11", "password", "password");
            bool b = l.UpdateUser("username11", "password", "123456", "123456");
            Assert.IsTrue(b);
        }
    }
}
