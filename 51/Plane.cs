using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51
{
    class Plane : Vehicle
    {
        public double Height { get; set; }
        public int Passengers { get; set; }

        public Plane(double x, double y, double price, double speed, int year, double height, int passengers)
            : base(x, y, price, speed, year)
        {
            Height = height;
            Passengers = passengers;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Тип: Самолёт, Высота полёта: {Height} м, Пассажиров: {Passengers}\n");
        }
    }
}
