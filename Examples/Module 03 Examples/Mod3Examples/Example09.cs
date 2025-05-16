using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3Example09 {
    internal class Program {
        public static void Main(string[] args) {
            int i = 0;
            Console.WriteLine("Please enter three animals");
            while (++i < 4) {
                while (true) {
                    Console.Write($"Please enter a name for animal {i}: ");
                    string? name = Console.ReadLine();
                    if (name == null) {
                        goto EndLoop;
                    }
                    if (string.IsNullOrWhiteSpace(name)) {
                        Console.WriteLine("Missing name.");
                        continue;
                    }
                    Console.WriteLine($"You entered: {name}");
                    break;
                }
            }
        EndLoop:
            ;
        }
    }
}
