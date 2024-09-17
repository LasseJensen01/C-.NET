﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_6 {
    internal class Person : IComparable<Person> {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public int Score { get; set; }
        public bool Accepted { get; set; }
        public Person(string data) {
            // Name, Age, Weight, Score
            var L = data.Split(';');
            Name = L[0];
            Age = int.Parse(L[1]);
            Weight = int.Parse(L[2]);
            Score = int.Parse(L[3]);
            Accepted = false; //denne parameter bliver ikke indlæst, men skal bruges senere.
        }

        public static List<Person> ReadCSVFile(string filename) {
            List<Person> list = new List<Person>();
            using (var file = new StreamReader(filename)) {
                string line;
                while ((line = file.ReadLine()) != null) {
                    var p = new Person(line);
                    list.Add(p);
                    //Console.WriteLine(p);
                }
            }
            return list;
        }



        public override string ToString() {
            return Name + ", Age: " + Age + ", Weight: " + Weight + ", Score: " + Score + ", Accepted: " + Accepted;
        }

        public int CompareTo(Person other) {
            return this.Age - other.Age;
        }
    }
}
