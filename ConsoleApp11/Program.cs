using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Point<int> pint = new Point<int>(45, 82);
            Point<double> pdouble = new Point<double>(45.2, 82.1);
            pint.Info();
            Console.WriteLine();
            pdouble.Info();
            Console.ReadLine();
        }
    }
}
