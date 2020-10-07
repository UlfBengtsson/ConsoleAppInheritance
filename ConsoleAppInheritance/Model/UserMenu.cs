using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppInheritance.Model
{
    class UserMenu : IMenuOptions
    {
        public bool CreateAdmin(string userName, string password, int powerLevel)
        {
            throw new NotImplementedException();
        }

        public bool CreateUser(string userName, string password)
        {
            throw new NotImplementedException();
        }

        public User GetCurrentUser()
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
