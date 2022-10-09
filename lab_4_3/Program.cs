using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Sniper S1mple = new Sniper("Александр Костылев", "Нави", "Снайпер");
            S1mple.Information();

            Captain Boombl4 = new Captain("Кирилл Михайлов", "Нави", "Капитан", 5, "Глобал");
            Boombl4.Information();

            Rifler Bit = new Rifler("Валерий Ваховский", "Нави", "Рифлер", "Украина");
            Bit.Information();

            Coach B1ad3 = new Coach("Андрей Городенский", "Нави", "Тренер", 10, 1);
            B1ad3.Information();

            Console.ReadLine();

        }
    }
}
