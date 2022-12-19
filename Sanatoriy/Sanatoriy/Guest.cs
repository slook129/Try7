using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanatoriy
{
    public class Guest:IComparable
    {
        private string role;
        private string medpolic;
        public string Role { get { return role; }  set { role = value; } }
        public string Medpolic { get { return medpolic; } set { medpolic = value; } }

        public int CompareTo(object? obj)
        {
            Guest comparing = obj as Guest;
            return comparing.Medpolic.CompareTo(this.Medpolic);
        }
    }
}
