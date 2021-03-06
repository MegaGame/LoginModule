﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LoginModule_Test
{
    [TestClass]
    public class DeleteUser_Test
    {
        [TestMethod]
        public void LoginModule_DeleteUser_DeleteUser_bool()
        {
            LoginComponent.TechnicalService.ILoginDataMapper fdm = new FakeILoginDataMapper();
            LoginComponent.Controller.Login l = new LoginComponent.Controller.Login(fdm);
            l.CreateUser("username10", "123456", "123456");
            bool b;
            string hashedpassword = FakeHelper.HashPassword("123456");
            b = l.DeleteUser("username10", hashedpassword);
            Assert.IsTrue(b);
        }
    }
}
