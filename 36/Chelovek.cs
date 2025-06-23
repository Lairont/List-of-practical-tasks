using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36
{
    // Абстрактный класс Человек
    abstract class Chelovek
    {
        public string Name { get; set; }  // Имя человека

        public Chelovek(string name)
        {
            Name = name;
        }

        // Абстрактный метод приветствия, должен быть реализован в наследниках
        public abstract void SkazatPrivetstvie();
    }
}
