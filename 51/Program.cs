using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle plane = new Plane(10, 20, 5000000, 850, 2020, 12000, 180);
            Vehicle car = new Car(5, 10, 1500000, 180, 2022);
            Vehicle ship = new Ship(30, 40, 7000000, 40, 2018, 300, "Одесса");

            plane.PrintInfo();
            car.PrintInfo();
            ship.PrintInfo();

            Console.ReadKey();
        }
    }
}
