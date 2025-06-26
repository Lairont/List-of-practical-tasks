using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    public class Disk : IShape
    {
        private double radius;

        public Disk(double radius)
        {
            this.radius = radius;
        }

        public double Perimeter()
        {
            return 2 * Math.PI * radius;
        }

        public double Area()
        {
            return Math.PI * radius * radius;
        }

        public string GetInfo()
        {
            return $"Радиус: r = {radius}";
        }

        public string Name => "Круг";
    }
}
