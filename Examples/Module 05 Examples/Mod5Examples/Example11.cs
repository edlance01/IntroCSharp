using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod5Example11 {
    internal class Program {
        public static void Main(string[] args) {
            Zoo zoo = new Zoo();
            zoo.CommandController();
        }
    }

    class Zoo {
        private Animal[] Animals { get; } = new Animal[ 100 ];
        private int AnimalListCount { get; set; } = 0;
        public int TotalAnimals {
            get {
                int totalAnimals = 0;
                for (int i = 0; i < AnimalListCount; i++) {
                    totalAnimals += Animals[ i ].Count;
                }
                return totalAnimals;
            }
        }
        public decimal TotalValue {
            get {
                decimal totalValue = 0;
                for (int i = 0; i < AnimalListCount; i++) {
                    totalValue += Animals[ i ].Count * Animals[ i ].Value;
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
                            int i = 0;
                            for (; i < AnimalListCount; i++) {
                                if (Animals[ i ].Name.Equals(animal.Name, StringComparison.OrdinalIgnoreCase)) {
                                    Animals[ i ] = animal;
                                    break;
                                }
                            }
                            if (i == AnimalListCount) {
                                Animals[ AnimalListCount ] = animal;
                                AnimalListCount++;
                            }
                        }
                        break;
                    case "list":
                        PrintZooAnimals(Animals, AnimalListCount);
                        break;
                    case "total":
                        PrintZooTotals(TotalAnimals, TotalValue);
                        break;
                    case "exit":
                        return;
                    default:
                        Console.WriteLine("Invalid command. Please try again.");
                        break;
                }
            }
        }

        private void PrintZooAnimals(Animal[] animals, int animalCount) {
            Console.WriteLine("Animals in the zoo:");
            for (int i = 0; i < animalCount; i++) {
                Console.WriteLine($"{animals[ i ].Name}: count = {animals[ i ].Count}, value = {animals[ i ].Value}, total value {animals[ i ].Count * animals[ i ].Value}");
            }
        }

        private void PrintZooTotals(int totalAnimals, decimal totalValue) {
            Console.WriteLine($"Total animals in the zoo: {totalAnimals}");
            Console.WriteLine($"Total value of the animals in the zoo: {totalValue}");
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