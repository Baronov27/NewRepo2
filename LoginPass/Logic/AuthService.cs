using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginPass.Model;

namespace LoginPass.Logic
{
    internal class AuthService
    {
        private List<User> _users;
        public AuthService()
        {
            _users = new List<User>()
            {
                new User("Login", "Password")
            };
        }

        public bool CheckData(string login, string password)
        {
            var user = _users.FirstOrDefault(u => u.Login == login && u.Password == password);
            if (user != null && user.Password == password)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}





