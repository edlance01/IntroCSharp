using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Mod7Example07 {
    internal class Program {

        public static void Main(string[] args) {
            List<Animal> animals = new List<Animal>() {
                new Animal() { Name = "Bear", Color = AnimalColor.Brown },
                new Animal() { Name = "Elephant", Color = AnimalColor.Gray },
                new Animal() { Name = "Giraffe", Color = AnimalColor.LightBrown },
                new Animal() { Name = "Crocodile", Color = AnimalColor.Green }
            };
            Console.WriteLine("Animals before sorting:");
            foreach (Animal animal in animals) {
                Console.WriteLine($"{animal.Name}: {animal.Color}");
            }
            animals.Sort(new SortAnimalsByColorDescending());
            Console.WriteLine("\nAnimals after sorting by color in descending order:");
            foreach (Animal animal in animals) {
                Console.WriteLine($"{animal.Name}: {animal.Color}");
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
        public string Name { get; set; }
        public AnimalColor Color { get; set; }
        public virtual bool Equals(object? obj) {
            if (obj is Animal) {
                return Color == ((Animal)obj).Color;
            }
            return false;
        }
    }

    internal class SortAnimalsByColorDescending : IComparer<Animal> {
        public int Compare(Animal x, Animal y) {
            return x.Color.CompareTo(y.Color) * -1;
        }
    }
}