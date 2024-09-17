using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion_2 {
    internal class Program {
        static void Main(string[] args) {
            bool isGoing = true;
            while (isGoing) {
                Console.WriteLine("Type number for fibonacci thingy");
                string input = Console.ReadLine();
                if (!input.Equals("0")) {
                    int temp = Convert.ToInt32(input);
                    var array = new int[temp];
                    Console.WriteLine(fibonacci(temp, ref array));
                    foreach (int i in array) {
                        Console.Write(i + ", ");
                    }
                    Console.WriteLine();
                }
                else {
                    isGoing = false;
                }
            }

        }

        static int fibonacci(int n, ref int[] arr) {
            if (n <= 1) {
                return n;
            }
            else {
                if (arr[n - 1] == 0) {
                    arr[n - 1] = fibonacci(n - 1, ref arr);
                }
                if (arr[n - 2] == 0) {
                    arr[n - 2] = fibonacci(n - 2, ref arr);
                }
                return arr[n - 1] + arr[n - 2];
            }
        }
    }
}
