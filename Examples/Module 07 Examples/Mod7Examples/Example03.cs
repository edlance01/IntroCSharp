using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7Example03 {
    internal class Program {
        public static void Main(string[] args) {
            Console.Write("Enter one of the colors Brown, Green, Gray, LightBrown: ");
            string? color = Console.ReadLine();
            AnimalColor.TryParse(color, out AnimalColor animalColor);
            if (animalColor == 0) {
                Console.WriteLine($"Color {color} is not in the enumerated type");
            } else {
                Console.WriteLine($"{animalColor} ({(int)animalColor})");
            }
        }
    }

    public enum AnimalColor {
        Brown = 1,
        Green,
        Gray,
        LightBrown
    }

    internal class Animal {
        public AnimalColor Color { get; set; }
    }
}