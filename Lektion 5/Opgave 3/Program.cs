using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_3 {
    internal class Program {
        public static List<Person> people1;
        static void Main(string[] args) {
            Exercise1();
            //people1.ForEach(person => Console.WriteLine(person.ToString()));
            

            var peopleScoreLessThan2Score = people1.FindAll(people => people.Score < 2);
            var peopleWithEvenScore = people1.FindAll(people => people.Score % 2 == 0);
            var peopleWithEvenScoreOver60KG = peopleWithEvenScore.FindAll(people => people.Weight > 60);
            var peopleWithWeightDividableBy3 = people1.FindAll(people => people.Weight % 3 == 0);

            Console.WriteLine("People with score less than 2");
            peopleScoreLessThan2Score.ForEach(person => Console.WriteLine(person));
            Console.WriteLine();

            Console.WriteLine("People with even score");
            peopleWithEvenScore.ForEach(person => Console.WriteLine(person));
            Console.WriteLine();

            Console.WriteLine("People with even score over 60KG");
            peopleWithEvenScoreOver60KG.ForEach(person => Console.WriteLine(person));
            Console.WriteLine();

            Console.WriteLine("People with weight divideable by 3");
            peopleWithWeightDividableBy3.ForEach(person => Console.WriteLine(person));
            Console.WriteLine();

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
