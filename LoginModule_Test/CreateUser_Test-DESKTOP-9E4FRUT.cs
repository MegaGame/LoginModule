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
            LoginComponent.ILoginDataMapper fdm = new FakeILoginDataMapper();
            LoginComponent.Login l = new LoginComponent.Login(fdm);
            l.CreateUser("username1", "password", "password");
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void LoginModule_CreateUser_Shortpassword_Exception()
        {
            bool b = false;
            try
            {
                LoginComponent.ILoginDataMapper fdm = new FakeILoginDataMapper();
                LoginComponent.Login l = new LoginComponent.Login(fdm);
                l.CreateUser("username2", "1234", "1234");
            }
            catch (Exception)
            {

                b = true;
            }
            Assert.IsTrue(b);
        }
        [TestMethod]
        public void LoginModule_CreateUser_PasswordNotMatch_Void()
        {
            bool b = false;
            try
            {
                LoginComponent.ILoginDataMapper fdm = new FakeILoginDataMapper();
                LoginComponent.Login l = new LoginComponent.Login(fdm);
                l.CreateUser("username3", "123456", "654321");
            }
            catch (Exception)
            {

                b = true;
            }
            Assert.IsTrue(b);
        }
        [TestMethod]
        public void LoginModule_CreateUser_PasswordNotHashed_Void()
        {
            bool b = false;
            LoginComponent.ILoginDataMapper fdm = new FakeILoginDataMapper();
            LoginComponent.Login l = new LoginComponent.Login(fdm);
            l.CreateUser("username4", "123456", "123456");
            //test if password has been hashed. change b to true
            if (!FakeDatabase.GetHashedPassword("username4").Equals("123456"))
            {
                b = true;
            }
            Assert.IsTrue(b);
        }
        [TestMethod]
        public void LoginModule_CreateUser_UsernameAvailable_Exception()
        {
            bool b = false;
            LoginComponent.ILoginDataMapper fdm = new FakeILoginDataMapper();
            LoginComponent.Login l = new LoginComponent.Login(fdm);
            l.CreateUser("username5", "123456", "123456");
            try
            {                
                l.CreateUser("username5", "123456", "123456");
            }
            catch (Exception)
            {
                b = true;
            }
            Assert.IsTrue(b);

        }
    }
}
