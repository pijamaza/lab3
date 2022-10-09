using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4_3
{
    class Rifler : Sniper
    {
        public string Nationality { get; set; }
        public Rifler() { }
        public Rifler(string Name, string Team, string Role, string nationality) : base(Name, Team, Role)
        {
            this.Nationality = nationality;
        }
        public override void Information()
        {
            Console.WriteLine($"\nИмя: {this.Name}\nКоманда: '{this.Team}'\nРоль: '{this.Role}'\n" +
                $"Национальность: {this.Nationality}\n");
            Debug.WriteLine($"Класс Rifler: имя: {this.Name}\nкоманда: '{this.Team}'\nроль: '{this.Role}'\n" +
                $"Национальность: {this.Nationality}\n");
        }
    }
}
