using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4Example05 {
    internal class Program {
        public static void Main(string[] args) {
            int totalAnimals = 0;
            decimal totalValue = 0m;
            while (true) {
                Console.Write("Please enter a command, add, total, or exit-: ");
                string? command = Console.ReadLine();
                switch (command) {
                    case "add":
                        var animal = AddAnimalToZoo();
                        if (animal.Count > 0 && animal.Value > 0) {
                            totalAnimals += animal.Count;
                            totalValue += animal.Count * animal.Value;
                        }
                        break;
                    case "total":
                        Console.WriteLine($"Total animals in the zoo: {totalAnimals}");
                        Console.WriteLine($"Total value of the animals in the zoo: {totalValue}");
                        break;
                    case "exit":
                        return;
                    default:
                        Console.WriteLine("Invalid command. Please try again.");
                        break;
                }
            }
        }

        private static (int Count, decimal Value) AddAnimalToZoo() {
            string? animalName = AddAnimalName();
            if (string.IsNullOrEmpty(animalName)) {
                return (0, 0m);
            } else {
                int animalCount = AddAnimalCount();
                decimal animalValue = AddAnimalValue();
                return (Count: animalCount, Value: animalValue);
            }
        }

        private static string? AddAnimalName() {
            Console.Write("Please enter a name for the animal: ");
            string? name = Console.ReadLine();
            return name;
        }

        private static int AddAnimalCount() {
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

        private static decimal AddAnimalValue() {
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
}
