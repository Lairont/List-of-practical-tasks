using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35
{
    // Класс Person реализует интерфейс IComparable, чтобы объекты можно было сравнивать и сортировать
    class Person : IComparable
    {
        // Свойство: имя человека
        public string Name { get; set; }

        // Свойство: возраст человека
        public int Age { get; set; }

        // Конструктор: инициализирует имя и возраст
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Метод CompareTo нужен для сортировки.
        // Сравниваем объекты по имени в алфавитном порядке.
        public int CompareTo(object obj)
        {
            // Проверяем, что переданный объект — это тоже Person
            if (obj is Person other)
            {
                // Сравнение по имени (по алфавиту)
                return this.Name.CompareTo(other.Name);
            }
            else
            {
                // Если объект другого типа — бросаем исключение
                throw new ArgumentException("Объект не является типом Person");
            }
        }

        // Метод для вывода информации об объекте в консоль, например: Имя: Андрей, Возраст: 25
        public override string ToString()
        {
            return $"Имя: {Name}, Возраст: {Age}";
        }

        // Метод сравнения двух объектов Person по значению (для HashSet и других коллекций)
        public override bool Equals(object obj)
        {
            if (obj is Person other)
                return this.Name == other.Name && this.Age == other.Age;

            return false;
        }

        // Метод, который возвращает хеш-код (для работы в HashSet, Dictionary и т.д.)
        // Комбинируем хеши имени и возраста с помощью XOR
        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Age.GetHashCode();
        }
    }
}
