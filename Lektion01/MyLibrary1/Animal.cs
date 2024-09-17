using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary1
{
    public class Animal : IAnimal
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public Animal(string name, string species)
        {
            Name = name;
            Species = species;
        }

        public bool isDog()
        {
            if (Species.ToUpper() == "DOG") { return true; } else { return false; }
        }

        public override string ToString()
        {
            return Name + ", " + Species;
        }

    }
    public interface IAnimal
    {
        bool isDog();
    }
}
