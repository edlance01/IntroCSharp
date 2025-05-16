using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Mod7Example04 {
    internal class Program {
        public static void Main(string[] args) {
            Program program = new Program();
            program.AnimalControl();
        }

        public void AnimalControl() {
            Animal animal = new Animal();
            animal.Color = AnimalColor.LightBrown;
            Food food = new Food();
            food.Type = FoodType.Branches;
            Console.WriteLine($"Before calling DoSomething: animal.Color = {animal.Color}, food.Type = {food.Type}");
            DoSomething(animal, food);
            Console.WriteLine($"After calling DoSomething: animal.Color = {animal.Color}, food.Type = {food.Type}");
        }

        public void DoSomething(Animal animal, Food food) {
            animal.Color = AnimalColor.Brown;
            food.Type = FoodType.Grass;
            Console.WriteLine($"Inside DoSomething: animal.Color = {animal.Color}, food.Type = {food.Type}");
        }
    }

    public enum AnimalColor {
        Brown,
        Green,
        Gray,
        LightBrown
    }

    public enum FoodType {
        Branches,
        Straw,
        Grass
    }

    internal class Animal {
        public AnimalColor Color { get; set; }
    }

    internal struct Food {
        public FoodType Type { get; set; }
    }
}