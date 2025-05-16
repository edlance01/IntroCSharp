using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod5Example09 {
    internal class Program {
        public static void Main(string[] args) {
            Animal[] animals = new Animal[] {
                new Animal { Name = "Giraffe", Count = 2, Value = 50000 },
                new Animal { Name = "Crocodile", Count = 3, Value = 500 },
                new Animal { Name = "Cobra", Count = 5, Value = 200 }
            };
            for (int i = 0; i < animals.Length; i++) {
                Console.WriteLine($"{animals[ i ].Name}: {animals[ i ].Count}, {animals[ i ].Value}, total value {animals[ i ].Count * animals[ i ].Value}");
            }
        }
    }

    class Animal {
        public string? Name { get; set; }
        public int Count { get; set; }
        public decimal Value { get; set; }
    }
}