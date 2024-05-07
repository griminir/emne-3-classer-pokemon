using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emne_3_classer
{
     class Pikachu
    {
        public string Name = "Pikachu";
        public int Health = 50;
        public int Level = 21;

        public void nameThatPokemon ()
        {
            Console.WriteLine($"{Name} has {Health} HP and is level {21}");
        }
    }
}
