using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3Example12 {
    internal class Program {
        public static void Main(string[] args) {
            string? animalNumber = null;
            Console.Write($"Please enter an animal number: ");
            animalNumber = Console.ReadLine();
            if (animalNumber != null) {
                if (int.TryParse(animalNumber, out int number)) {
                    switch (number) {
                        case 123:
                            Console.WriteLine("Animal number 123 is a giraffe.");
                            break;
                        case 456:
                            Console.WriteLine("Animal number 456 is a crocodile.");
                            break;
                        default:
                            Console.WriteLine("Animal number is not valid.");
                            break;
                    }
                } else {
                    Console.WriteLine("animal number is not a valid number.");
                }
            }
        }
    }
}
