using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3Example14 {
    internal class Program {
        public static void Main(string[] args) {
            string? name = null;
            Console.Write($"Please enter an animal name: ");
            name = Console.ReadLine();
            if (name != null) {
                switch (name) {
                    case "giraffe":
                        Console.WriteLine("Giraffe is a valid animal.");
                        break;
                    case "crocodile":
                        Console.WriteLine("Crocodile is a valid animal and supersedes Giraffe.");
                        goto case "giraffe";
                    default:
                        Console.WriteLine("Animal name is not valid.");
                        break;
                }
            }
        }
    }
}
