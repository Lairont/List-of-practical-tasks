using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46
{
    public class Multiply : ICalculation
    {
        private double factor;

        public Multiply(double factor)
        {
            this.factor = factor;
        }

        public double Perform(double x)
        {
            return x * factor;
        }
    }
}
