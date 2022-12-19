using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanatoriy
{
    class User
    {
        string email;
        public string Email { get { return email; } set { email = value; } }
        string phone;
        public string Phone { get { return phone; } set { phone = value; } }
        string password;
        public string Password { get { return password; } set { password = value; } }
        string fullName;
        public string FullName { get { return fullName; } set { fullName = value; } }
    }
}
