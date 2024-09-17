using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_6 {
    internal static class PersonExt {
        public static void SetAcceptedP(this List<Person> lst, Predicate<Person> pred) {
            foreach (var item in lst.FindAll(pred)) {
                Console.WriteLine("Debug");
                item.Accepted = true;
            }
        }
    }
}
