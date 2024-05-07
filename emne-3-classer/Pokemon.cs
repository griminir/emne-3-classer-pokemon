using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emne_3_classer
{
    internal class Pokemon
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }

        public void showInfo()
        {
            Console.WriteLine($"{Name} has {Health} HP and is level {Level}");
        }

        public Pokemon (string name, int level, int health)
        {
            Name = name;
            Level = level;
            Health = health;
        }
    }
}
