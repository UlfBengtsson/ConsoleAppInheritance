using System;
using Xunit;
using ConsoleAppInheritance.Model;

namespace ConsoleAppInheritance.Tests
{
    public class UserMenuTests
    {
        [Fact]
        public void Test1()
        {

        }

        [Fact]
        public void GoodCreateAdminTest()
        {
            //Arrange
            string userName = "good";
            string password = "good";
            int powerLevel = 1;
            UserMenu userMenu = new UserMenu();

            //Act
            bool result = userMenu.CreateAdmin(userName, password, powerLevel);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void TwoGoodCreateAdminTest()
        {
            //Arrange
            string userName = "good", userName2 = "good2";
            string password = "good", password2 = "good2";
            int powerLevel = 1;
            UserMenu userMenu = new UserMenu();

            //Act
            bool result = userMenu.CreateAdmin(userName, password, powerLevel);
            bool result2 = userMenu.CreateAdmin(userName2, password2, powerLevel);

            //Assert
            Assert.True(result);
            Assert.True(result2);
        }

        [Fact]
        public void BadCreateAdminTest()
        {
            //Arrange
            string userName = "bad";
            string password= "bad";
            int powerLevel = -1;
            UserMenu userMenu = new UserMenu();
            userMenu.CreateAdmin(userName,password,powerLevel);

            //Act
            bool result = userMenu.CreateAdmin(userName,password,powerLevel);

            //Assert
            Assert.False(result);
        }
        public bool CreateUser(string userName, string password)
        {
            throw new NotImplementedException();
        }

        public bool Login(string userName, string password)
        {
            throw new NotImplementedException();
        }

        public bool Logout()
        {
            throw new NotImplementedException();
        }


        public string[] UserNameList()
        {
            throw new NotImplementedException();
        }
    }
}
