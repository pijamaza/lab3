using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4_3
{
    class Sniper
    {
        public string Name { get; set; }
        public string Team { get; set; }
        public string Role { get; set; }
        public Sniper() { }
        public Sniper(string name, string team, string role)
        {
            this.Name = name;
            this.Team = team;
            this.Role = role;
        }

        public virtual void Information()
        {
            Console.WriteLine($"Имя: {this.Name}");
            Console.WriteLine($"Команда: {this.Team}");
            Console.WriteLine($"Роль: {this.Role}");
            Debug.WriteLine($"Класс Sniper: имя {this.Name}, команда '{this.Team}', роль '{this.Role}'\n");
        }
    }
}
