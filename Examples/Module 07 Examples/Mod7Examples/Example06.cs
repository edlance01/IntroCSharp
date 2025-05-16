using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Mod7Example06 {
    internal class Program {

        public static void Main(string[] args) {
            List<Animal> animals = new List<Animal>() { new Animal() };
            animals[ 0 ].Color = AnimalColor.Gray;
            Animal animal = new Animal();
            animal.Color = AnimalColor.LightBrown;
            if (animals.Contains(animal)) {
                Console.WriteLine("animals contains an animal that matches the LightBrown animal.");
            } else {
                Console.WriteLine("animals does not contain a match.");
            }
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
        public virtual bool Equals(object? obj) {
            if (obj is Animal) {
                return Color == ((Animal)obj).Color;
            }
            return false;
        }
    }
}