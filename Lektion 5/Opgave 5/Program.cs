using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_5 {
    internal class Program {
        public static List<Person> people1;
        static void Main(string[] args) {
            Exercise1();
            people1.Sort();
            foreach (var item in people1){
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
        public static void Exercise1() {
            try {
                people1 = Person.ReadCSVFile(@"C:\Users\lasse\source\repos\Lektion 5\Opgave 3\ressources\data1-1.csv");
            }
            catch (Exception ex) {
                Console.WriteLine("EXCEPTION: " + ex.Message);
                Console.WriteLine("You should probably set the filename to the Person.ReadCSVFile method to something on your disk!");
            }
        }
    }
}
