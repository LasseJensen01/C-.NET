using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary1;

namespace Lektion01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            

            Person p1 = new Person("Peder");
            Person p2 = new Person("Kennet");
            Person p3 = new Person("Mark");
            Console.WriteLine(p1.Name);
            Console.WriteLine(p2.ToString());
            Console.WriteLine(p3.ToString());
            Cake choco = new Cake("Birthday Cake", "Chocolate Cake", "Vanilla and Chocolate" );
            Console.WriteLine(choco.ToString());

            Console.WriteLine("What animal should be created?");
            string species = Console.ReadLine();
            Console.WriteLine("What is their name?");
            string name = Console.ReadLine();
            var fido = new Animal(name, species);
            Console.WriteLine(fido.ToString());
            Console.WriteLine("Is " + fido.Name + " a dog?");
            Console.WriteLine(fido.isDog());
            Console.ReadLine();



        }
    }
}
