using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanatoriy
{
    public class Guest
    {
        private string role;
        private string medpolic;
        public string Role { get { return role; }  set { role = value; } }
        public string Medpolic { get { return medpolic; } set { medpolic = value; } }
    }
}
