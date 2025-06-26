using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp500
{
    class DateClass
    {
        // a. поле DateTime data;
        private DateTime data;

        // b. конструктор без параметров
        public DateClass()
        {
            data = DateTime.Now; // по умолчанию текущая дата
        }

        // c. конструктор с тремя параметрами – год, месяц, день
        public DateClass(int year, int month, int day)
        {
            data = new DateTime(year, month, day);
        }

        // d. Свойство для доступа к полю data
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        // e. Метод вычисления предыдущего дня
        public DateTime PreviousDay()
        {
            return data.AddDays(-1);
        }

        // f. Метод вычисления следующего дня
        public DateTime NextDay()
        {
            return data.AddDays(1);
        }
    }
}
