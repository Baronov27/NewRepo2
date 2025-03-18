using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forms.Model
{
    public class Users
    {
        public string Login { get; set; }
        public string Pass { get; set; }

        public Users(string login, string pass)
        {
            Login = login;
            Pass = pass;
        }
    }
}
