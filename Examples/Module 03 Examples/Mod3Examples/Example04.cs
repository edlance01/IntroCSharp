using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3Example04 {
    internal class Program {
        public static void Main(string[] args) {
            string? name;
            do {
                Console.Write("Please enter an animal name: ");
                name = Console.ReadLine();
                Console.WriteLine($"You entered: {name}");
            } while (!string.IsNullOrWhiteSpace(name));
        }
    }
}
