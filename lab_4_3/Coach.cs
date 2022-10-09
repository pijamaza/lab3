using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4_3
{
    class Coach : Sniper
    {
        public int Experience { get; set; }
        public int Majorswon { get; set; }
        public Coach() { }
        public Coach(string Name, string Team, string Role, int experience, int majorswon) : base(Name, Team, Role)
        {
            this.Experience = experience;
            this.Majorswon = majorswon;
        }
        public override void Information()
        {
            Console.WriteLine($"Имя: {this.Name}\nКоманда: '{this.Team}'\nРоль: '{this.Role}'\n" +
                $"Стаж: {this.Experience}\nВыигранных мажоров: {this.Majorswon}\n");
            Debug.WriteLine($"Класс Coach: имя: {this.Name}\nкоманда: '{this.Team}'\nроль: '{this.Role}'\n" +
                $"Стаж: {this.Experience}\nВыигранных мажоров: {this.Majorswon}\n");
        }
    }
}
