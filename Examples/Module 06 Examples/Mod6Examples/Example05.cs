using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod6Example05 {
    internal class Program {
        public static void Main(string[] args) {
            Zoo zoo = new Zoo();
            zoo.CommandController();
        }
    }

    class Zoo {
        private List<Animal> Animals { get; } = new List<Animal>();
        public int TotalAnimals {
            get {
                int totalAnimals = 0;
                foreach (Animal animal in Animals) {
                    totalAnimals += animal.Count;
                }
                return totalAnimals;
            }
        }
        public decimal TotalValue {
            get {
                decimal totalValue = 0;
                foreach (Animal animal in Animals) {
                    totalValue += animal.Count * animal.Value;
                }
                return totalValue;
            }
        }
        public void CommandController() {
            while (true) {
                Console.Write("Please enter a command, add, total, or exit: ");
                string? command = Console.ReadLine();
                switch (command) {
                    case "add":
                        var animal = AddAnimalToZoo();
                        if (animal != null) {
                            Animal? replaceAnimal = null;
                            foreach (Animal listAnimal in Animals) {
                                if (listAnimal.Name.Equals(animal.Name, StringComparison.OrdinalIgnoreCase)) {
                                    replaceAnimal = listAnimal;
                                    break;
                                }
                            }
                            if (replaceAnimal != null) {
                                Animals.Remove(replaceAnimal);
                            }
                            Animals.Add(animal);
                        }
                        break;
                    case "list":
                        PrintZooAnimals();
                        break;
                    case "total":
                        PrintZooTotals();
                        break;
                    case "exit":
                        return;
                    default:
                        Console.WriteLine("Invalid command. Please try again.");
                        break;
                }
            }
        }

        private void PrintZooAnimals() {
            Console.WriteLine("Animals in the zoo:");
            foreach (Animal animal in Animals) {
                Console.WriteLine($"{animal.Name}: count = {animal.Count}, value = {animal.Value}, total value {animal.Count * animal.Value}");
            }
        }

        private void PrintZooTotals() {
            Console.WriteLine($"Total animals in the zoo: {TotalAnimals}");
            Console.WriteLine($"Total value of the animals in the zoo: {TotalValue}");
        }

        private Animal? AddAnimalToZoo() {
            string? animalName = AddAnimalName();
            if (string.IsNullOrEmpty(animalName)) {
                return null;
            } else {
                int animalCount = AddAnimalCount();
                decimal animalValue = AddAnimalValue();
                return new Animal() { Name = animalName, Count = animalCount, Value = animalValue };
            }
        }

        private string? AddAnimalName() {
            Console.Write("Please enter a name for the animal: ");
            string? name = Console.ReadLine();
            return name;
        }

        private int AddAnimalCount() {
            while (true) {
                Console.Write("Enter the number of animals to add: ");
                string? count = Console.ReadLine();
                if (int.TryParse(count, out int numberOfAnimals)) {
                    return numberOfAnimals;
                } else {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }

        private decimal AddAnimalValue() {
            while (true) {
                Console.Write("Enter the value of the animal: ");
                string? value = Console.ReadLine();
                if (decimal.TryParse(value, out decimal animalValue)) {
                    return animalValue;
                } else {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }
    }
    class Animal {
        public string Name { get; set; } = "";
        public int Count { get; set; }
        public decimal Value { get; set; }
    }
}