using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51
{
    class Car : Vehicle
    {
        public Car(double x, double y, double price, double speed, int year)
            : base(x, y, price, speed, year) { }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Тип: Машина\n");
        }
    }
}
