using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2Example03 {
    internal class Program {
        public static void Main(string[] args) {
            Console.Write("Please enter a number: ");
            string? input = Console.ReadLine();
            if (input == null) {
                Console.WriteLine("No data entered.");
            } else if (input == "") {
                Console.WriteLine("An empty string was provided.");
            } else {
                Console.WriteLine($"The numbered entered is {input}");
            }
        }
    }
}
