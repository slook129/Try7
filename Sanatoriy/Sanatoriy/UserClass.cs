using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanatoriy
{
    class User : IComparable
    {
        string email;
        public string Email { get { return email; } set { email = value; } }
        string phone;
        public string Phone { get { return phone; } set { phone = value; } }
        string password;
        public string Password { get { return password; } set { password = value; } }
        string fullName;
        public string FullName { get { return fullName; } set { fullName = value; } }
        /// <summary>
        /// Метод, сравнивающий пароли у двух пользователей 
        /// </summary>
        /// <param name="obj"> - Объект, который потом сравнивается с нашим пользователем</param>
        /// <returns>Числа: -1, 0, 1, в зависимости от выполненных условий</returns>
        public int CompareTo(object? obj)
        {
            User comparing = obj as User;
            return comparing.Password.CompareTo(this.Password);
        }
        /// <summary>
        /// Конструктор, создающий элемент класса User
        /// </summary>
        public User()
        {
            email = "";
            phone = "";
            password = "";
            fullName = "";
        }
    }
}
