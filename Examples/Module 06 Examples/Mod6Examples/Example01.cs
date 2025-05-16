using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod6Example01 {
    internal class Program {
        public static void Main(string[] args) {
            Crocodile crocodile = new Crocodile() { Name = "Crocodile", Count = 5, Value = 10000.00M };
            Console.WriteLine(crocodile.Feed());
        }
    }
    internal class Animal {
        public string Name { get; set; } = "";
        public int Count { get; set; }
        public decimal Value { get; set; }
        public string Feed() {
            return $"Feeding the {Name}.";
        }
    }

    internal class Mammal : Animal {
    }

    internal class Giraffe : Mammal {

    }

    internal class Reptile : Animal {
    }

    internal class Crocodile : Reptile {
    }
}