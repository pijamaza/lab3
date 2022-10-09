using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4_3
{
    class Captain : Sniper
    {
        public int Experience { get; set; }
        public string Rankcsgo { get; set; }
        public Captain() { }
        public Captain(string Name, string Team, string Role, int Experience, string Rankcsgo) : base(Name, Team, Role)
        {
            this.Experience = Experience;
            this.Rankcsgo = Rankcsgo;
        }
        public override void Information()
        {
            Console.WriteLine($"\n{this.Role} команды '{this.Team}' {this.Name}");
            Console.WriteLine($"Стаж: {this.Experience}\nРанг: {this.Rankcsgo}");
            Debug.WriteLine($"Класс Captain: Имя {this.Name}\nКоманда '{this.Team}'\nРоль '{this.Role}'\n" +
                $"Стаж: {this.Experience}\nРанг: {this.Rankcsgo}\n");
        }

    }
}
