using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3Example07 {
    internal class Program {
        public static void Main(string[] args) {
            do {
                Console.Write("Please enter an animal name: ");
                string? name = Console.ReadLine();
                if (name == null) {
                    break;
                }
                if (string.IsNullOrWhiteSpace(name)) {
                    Console.WriteLine("Missing name.");
                    continue;
                }
                Console.WriteLine($"You entered: {name}");
            } while (true);
        }
    }
}
