using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_2 {
    internal class Program {
        static void Main(string[] args) {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 14, 16, 20, 54, -44 };
            List<int> result = new List<int>();

            var linQ = list.Where(x => x % 2 == 0);
            var linQTwoDigits = list.Where(x => x.ToString().Length == 2);
            foreach (var x in linQ) {
                Console.WriteLine(x);
            }
            Console.WriteLine();
            foreach (var x in linQTwoDigits){
                Console.WriteLine(x);
            }
            Console.ReadLine();
        }
    }
}
