using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_1 {
    internal class Program {
        static void Main(string[] args) {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 14, 16, 20, 54 };
            List<int> result = new List<int>();

            list.ForEach(x => {
                if (x % 2 == 0) {
                    result.Add(x);
                }
            } );
            result.ForEach(x => Console.WriteLine(x));
            Console.WriteLine();

            result.Clear();

            result = list.FindAll(x => x % 2 == 0);
            result.ForEach(x => Console.WriteLine(x));
            Console.WriteLine();

            result.Clear();


            Console.WriteLine(list.FindLast(x => x > 15));
            Console.WriteLine(list.FindLastIndex(x => x > 15));
            Console.ReadLine();

            // Using Predicate
            var predicate = new Predicate<int>((x) => x % 2 == 0);

            var filtered = list.FindAll(predicate);

            filtered.ForEach(x => Console.WriteLine(x));
            Console.ReadLine();



        }
    }
}
