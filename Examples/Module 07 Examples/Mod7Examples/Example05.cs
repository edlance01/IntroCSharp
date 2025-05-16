using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Mod7Example05 {
    internal class Program {
        public static void Main(string[] args) {
            Animal animal = new Animal();
            animal.Color = AnimalColor.LightBrown;
            Animal animal2 = animal.Clone();
            Console.WriteLine($"animal.Color = {animal.Color}, anmial2.Color = {animal2.Color}");
            animal2.Color = AnimalColor.Brown;
            Console.WriteLine($"After changing animal2.Color: animal.Color = {animal.Color}, animal2.Color = {animal2.Color}");
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
        public Animal Clone() {
            return (Animal)MemberwiseClone();
        }
    }
}