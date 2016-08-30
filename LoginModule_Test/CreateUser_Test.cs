using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LoginModule_Test
{
    [TestClass]
    public class CreateUser_Test
    {
        [TestMethod]
        public void LoginModule_CreateUser_AllInputOk_Void()
        {
            LoginComponent.TechnicalService.ILoginDataMapper fdm = new FakeILoginDataMapper();
            LoginComponent.Controller.Login l = new LoginComponent.Controller.Login(fdm);
            l.CreateUser("username1", "password", "password");
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void LoginModule_CreateUser_Shortpassword_int()
        {
            bool b = false;
            LoginComponent.TechnicalService.ILoginDataMapper fdm = new FakeILoginDataMapper();
            LoginComponent.Controller.Login l = new LoginComponent.Controller.Login(fdm);
            
            if (l.CreateUser("username2", "1234", "1234") == 3)
            {
                b = true;
            }
            Assert.IsTrue(b);
        }
        [TestMethod]
        public void LoginModule_CreateUser_PasswordNotMatch_int()
        {
            bool b = false;
            LoginComponent.TechnicalService.ILoginDataMapper fdm = new FakeILoginDataMapper();
            LoginComponent.Controller.Login l = new LoginComponent.Controller.Login(fdm);            
            if (l.CreateUser("username3", "123456", "654321") == 2)
            {
                b = true;
            }           
            Assert.IsTrue(b);
        }
        [TestMethod]
        public void LoginModule_CreateUser_PasswordNotHashed_bool()
        {
            bool b = false;
            LoginComponent.TechnicalService.ILoginDataMapper fdm = new FakeILoginDataMapper();
            LoginComponent.Controller.Login l = new LoginComponent.Controller.Login(fdm);
            l.CreateUser("username4", "123456", "123456");
            //test if password has been hashed. change b to true
            if (!FakeDatabase.GetHashedPassword("username4").Equals("123456"))
            {
                b = true;
            }
            Assert.IsTrue(b);
        }
        [TestMethod]
        public void LoginModule_CreateUser_UsernameAvailable_int()
        {
            bool b = false;
            LoginComponent.TechnicalService.ILoginDataMapper fdm = new FakeILoginDataMapper();
            LoginComponent.Controller.Login l = new LoginComponent.Controller.Login(fdm);
            l.CreateUser("username5", "123456", "123456");
            if (l.CreateUser("username5", "123456", "123456") == 1)
            {
                b = true;
            }            
            Assert.IsTrue(b);
        }
        [TestMethod]
        public void LoginModule_CreateUser_UserStorged_Void()
        {
            bool b = false;
            LoginComponent.TechnicalService.ILoginDataMapper fdm = new FakeILoginDataMapper();
            LoginComponent.Controller.Login l = new LoginComponent.Controller.Login(fdm);
            l.CreateUser("username6", "123456", "123456");
            string hashedpassword = FakeHelper.HashPassword("123456");
            foreach (var x in FakeDatabase.user_table)
            {
                if (x.username.Equals("username6") && x.hashedPassword.Equals(hashedpassword))
                {
                    b = true;
                }
            }
            Assert.IsTrue(b);
        }
        [TestMethod]
        public void LoginModule_CreateUser_UsernameRules_int()
        {
            //bool b = false;
            LoginComponent.TechnicalService.ILoginDataMapper fdm = new FakeILoginDataMapper();
            LoginComponent.Controller.Login l = new LoginComponent.Controller.Login(fdm);
            l.CreateUser("username7", "123456", "123456");
            //relger for username skal laves for test kan få error number 4
            Assert.IsTrue(true);
        }
    }
}
