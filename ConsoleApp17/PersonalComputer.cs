using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class PersonalComputer : ISwitchable
    {
        public void TurnOn()
        {
            Console.WriteLine("Персональный компьютер включён.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Персональный компьютер выключен.");
        }
    }

}
