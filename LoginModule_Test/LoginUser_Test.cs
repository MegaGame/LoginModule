﻿using System;
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
            LoginComponent.TechnicalService.ILoginDataMapper fdm = new FakeILoginDataMapper();
            LoginComponent.Controller.Login l = new LoginComponent.Controller.Login(fdm);
            l.CreateUser("username8", "123456", "123456");
            b = l.LoginUser("username8", "123456");
            Assert.IsTrue(b);
        }
        [TestMethod]
        public void LoginModule_LoginUser_loginFail_bool()
        {
            bool b = false;
            LoginComponent.TechnicalService.ILoginDataMapper fdm = new FakeILoginDataMapper();
            LoginComponent.Controller.Login l = new LoginComponent.Controller.Login(fdm);
            l.CreateUser("username9", "123456", "123456");
            b = l.LoginUser("username9", "654321");
            Assert.IsTrue(!b);
        }
    }
}
