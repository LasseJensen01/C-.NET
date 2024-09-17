using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_2 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine(CalculateAge(new DateTime(2001, 08, 26), out int age));
            Console.ReadLine();
        }

        static int CalculateAge(DateTime bDay, out int age) {
            var now = DateTime.Now;
            age = now.Year - bDay.Year;
            if (bDay.Date > now.AddYears(-age)) age--;
            return age;
        }
    }
}
