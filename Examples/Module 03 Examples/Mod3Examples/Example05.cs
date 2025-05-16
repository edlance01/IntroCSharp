using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3Example05 {
    internal class Program {
        public static void Main(string[] args) {
            while (true) {
                Console.Write("Please enter an animal name: ");
                string? name = Console.ReadLine();
                if (name == null) {
                    break;
                }
                Console.WriteLine($"You entered: {name}");
            }
        }
    }
}
