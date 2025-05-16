using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2Example04 {
    internal class Program {
        public static void Main(string[] args) {
            Console.Write("Please enter a floating point number: ");
            string? input = Console.ReadLine();
            if (input == null || !double.TryParse(input, out double value)) {
                Console.WriteLine("Bad input");
            } else {
                Console.WriteLine($"The floating point value is {value}");
            }
        }
    }
}
