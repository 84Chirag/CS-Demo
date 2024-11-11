using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Player
    {
        public int id;
        public string name;
        public int health;
        public void details(string name, int health)
        {
            this.name = name;
            this.health = health;
            Console.WriteLine($"your player name {name} and health {health} is set!");
        }
    }
}
