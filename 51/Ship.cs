using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51
{
    class Ship : Vehicle
    {
        public int Passengers { get; set; }
        public string Port { get; set; }

        public Ship(double x, double y, double price, double speed, int year, int passengers, string port)
            : base(x, y, price, speed, year)
        {
            Passengers = passengers;
            Port = port;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Тип: Корабль, Пассажиров: {Passengers}, Порт приписки: {Port}\n");
        }
    }
}
