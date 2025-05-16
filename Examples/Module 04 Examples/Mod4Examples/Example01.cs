using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4Example01 {
    internal class Program {
        public static void Main(string[] args) {
            int totalAnimals = 0;
            while (true) {
                Console.Write("Please enter a command, add, total, or exit: ");
                string? command = Console.ReadLine();
                switch (command) {
                    case "add":
                        totalAnimals += AddAnimalToZoo();
                        break;
                    case "total":
                        Console.WriteLine($"Total animals in the zoo: {totalAnimals}");
                        break;
                    case "exit":
                        return;
                    default:
                        Console.WriteLine("Invalid command. Please try again.");
                        break;
                }
            }
        }

        private static int AddAnimalToZoo() {
            Console.Write($"Please enter a name for the animal: ");
            string? name = Console.ReadLine();
            if (string.IsNullOrEmpty(name)) {
                return 0;
            }
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
    }
}
