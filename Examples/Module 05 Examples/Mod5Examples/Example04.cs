using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod5Example04 {
    internal class Program {
        public static void Main(string[] args) {
            Zoo zoo = new Zoo();
            zoo.CommandController();
        }
    }

    class Zoo {
        public int TotalAnimals { get; private set; }
        public decimal TotalValue { get; private set; }
        public void CommandController() {
            while (true) {
                Console.Write("Please enter a command, add, total, or exit: ");
                string? command = Console.ReadLine();
                switch (command) {
                    case "add":
                        var animal = AddAnimalToZoo();
                        if (animal.Count > 0 && animal.Value > 0) {
                            TotalAnimals += animal.Count;
                            TotalValue += animal.Count * animal.Value;
                        }
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

        private void PrintZooTotals(int totalAnimals, decimal totalValue) {
            Console.WriteLine($"Total animals in the zoo: {totalAnimals}");
            Console.WriteLine($"Total value of the animals in the zoo: {totalValue}");
        }

        private (int Count, decimal Value) AddAnimalToZoo() {
            string? animalName = AddAnimalName();
            if (string.IsNullOrEmpty(animalName)) {
                return (0, 0m);
            } else {
                int animalCount = AddAnimalCount();
                decimal animalValue = AddAnimalValue();
                return (Count: animalCount, Value: animalValue);
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
}