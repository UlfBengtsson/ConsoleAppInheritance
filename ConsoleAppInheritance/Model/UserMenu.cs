using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppInheritance.Model
{
    public class UserMenu : IMenuOptions
    {
        int idCounter = 0;
        List<User> users = new List<User>();


        public bool CreateAdmin(string userName, string password, int powerLevel)
        {
            User user = users.SingleOrDefault(x => x.UserName.ToLower() == userName.ToLower());
            if (user != null)
            {
                return false;
            }
            else
            {
                users.Add(new Admin() { Id = ++idCounter, UserName = userName, Password = password, PowerLevel = powerLevel });
                return true;
            }
        }

        public bool CreateUser(string userName, string password)
        {
            User user = users.SingleOrDefault(x => x.UserName.ToLower() == userName.ToLower());
            if (user != null)
            {
                return false;
            }
            else
            {
                users.Add(new User() { Id = ++idCounter, UserName = userName, Password = password});
                return true;
            }
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
