using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4Example02 {
    internal class Program {
        public static void Main(string[] args) {
            int totalAnimals = 0;
            decimal totalValue = 0m;
            while (true) {
                Console.Write("Please enter a command, add, total, or exit: ");
                string? command = Console.ReadLine();
                switch (command) {
                    case "add":
                        AddAnimalToZoo(ref totalAnimals, ref totalValue);
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

        private static void AddAnimalToZoo(ref int totalAnimals, ref decimal totalValue) {
            Console.Write($"Please enter a name for the animal: ");
            string? name = Console.ReadLine();
            if (string.IsNullOrEmpty(name)) {
                return;
            }
            while (true) {
                Console.Write("Enter the number of animals to add: ");
                string? count = Console.ReadLine();
                int numberOfAnimals = 0;
                if (int.TryParse(count, out numberOfAnimals)) {
                    while (true) {
                        Console.Write("Enter the value of the animal: ");
                        string? value = Console.ReadLine();
                        decimal animalValue = 0;
                        if (decimal.TryParse(value, out animalValue)) {
                            totalAnimals += numberOfAnimals;
                            totalValue += numberOfAnimals * animalValue;
                            return;
                        } else {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                        }
                    }
                } else {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }
    }
}
