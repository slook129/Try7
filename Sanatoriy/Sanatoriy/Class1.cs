using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanatoriy
{
    class Service
    {
        // Поля класса услуги.
        public string Schedule { get { return schedule; } set { Schedule = value; } }
        public string Price { get { return price; } set { peice = value; } }
        public string Desription { get { return description; } set { description = value; } }
        /// <summary>
        /// //Конструктор класса услуги, который создает элементы класса Услуги.
        /// </summary>
        public Service()
        {
            schedule = "";
            price = "";
            desription = "";
        }
        
        

    }
}
