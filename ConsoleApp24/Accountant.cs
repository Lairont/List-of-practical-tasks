using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    // Перечисление должностей с количеством часов
    enum Post
    {
        Manager = 160,
        Developer = 150,
        Designer = 140,
        Tester = 130
    }
    class Accountant
    {
        public bool AskForBonus(Post worker, int hours)
        {
            // Если отработано больше, чем положено, то премия положена
            return hours > (int)worker;
        }
    }
}
