using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_4 {
    internal class Program {
        public static List<Person> people1;
        static void Main(string[] args) {
            Exercise1();


            var indexOfPersonWith3Score = people1.FindIndex(x => x.Score == 3);
            var indexOfPersonWith3ScoreUnder10years = people1.FindIndex(x => x.Score == 3 && x.Age < 10);
            var numberOfPeopleWith3Scoreunder10Years = people1.FindAll(x => x.Score == 3 && x.Age < 10).Count();
            var indexOfPeopleUnder8YearsWithScoreOf3 = people1.FindIndex(x => x.Age < 8 && x.Score == 3);

            Console.WriteLine("Index of person with 3 Score");
            Console.WriteLine(indexOfPersonWith3Score);
            Console.WriteLine(people1.ElementAt(indexOfPersonWith3Score));
            Console.WriteLine();
            Console.WriteLine("Index of person With 3 Score under 10 years");
            Console.WriteLine(indexOfPersonWith3ScoreUnder10years);
            Console.WriteLine(people1.ElementAt(indexOfPersonWith3ScoreUnder10years));
            Console.WriteLine();
            Console.WriteLine("Number of People with 3 Score under 10 years");
            Console.WriteLine(numberOfPeopleWith3Scoreunder10Years);
            Console.WriteLine();
            Console.WriteLine("Index of People Under 8 Years with score of 3");
            Console.WriteLine(indexOfPeopleUnder8YearsWithScoreOf3);
            // Console.WriteLine(people1.ElementAt(indexOfPeopleUnder8YearsWithScoreOf3));

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
