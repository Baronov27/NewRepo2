using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    public class user
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public user(string login, string password)
        { 
            Login = login;
            Password = password;
        }
    }
}
