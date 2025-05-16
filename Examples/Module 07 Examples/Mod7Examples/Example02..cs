using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7Example02 {
    internal class Program {
        public static void Main(string[] args) {
            Console.WriteLine($"{AnimalColor.Brown} ({(int)AnimalColor.Brown})");
            Console.WriteLine($"{AnimalColor.Green} ({(int)AnimalColor.Green})");
            Console.WriteLine($"{AnimalColor.Gray} ({(int)AnimalColor.Gray})");
            Console.WriteLine($"{AnimalColor.LightBrown} ({(int)AnimalColor.LightBrown})");

            Animal animal = new Animal();
            animal.Color = AnimalColor.Green;
            // animal.Color = AnimalColor.Pink;  // Fails, Pink is not defined
            // animal.Color = 5;  // Fails, not a symbol in the set
            animal.Color = (AnimalColor)42;
        }
    }

    public enum AnimalColor {
        Brown = 7,
        Green = 5,
        Gray,
        LightBrown
    }

    internal class Animal {
        public AnimalColor Color { get; set; }
    }
}