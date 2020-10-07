using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppInheritance.Model
{
    public interface IMenuOptions
    {
        bool Login(string userName, string password);
        bool Logout();
        bool CreateUser(string userName, string password);
        bool CreateAdmin(string userName, string password, int powerLevel);
        string[] UserNameList();

        User GetCurrentUser();
    }
}
