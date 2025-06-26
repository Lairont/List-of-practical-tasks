using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46
{
    // Интерфейс преобразования чисел
    public interface ICalculation
    {
        double Perform(double x);
    }

    // Класс сложения
    public class Add : ICalculation
    {
        private double value;

        public Add(double value)
        {
            this.value = value;
        }

        public double Perform(double x)
        {
            return x + value;
        }
    }
}
