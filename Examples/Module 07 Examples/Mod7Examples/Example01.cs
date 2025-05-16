using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7Example01 {
    internal class Program {
        public static void Main(string[] args) {
            Animal animal = new Animal();
            Console.WriteLine($"Animal Color: {animal.Color} ({(int)animal.Color})");
        }
    }

    public enum AnimalColor {
        Brown,
        Green,
        Gray,
        LightBrown
    }

    internal class Animal {
        public AnimalColor Color { get; set; }
    }
}