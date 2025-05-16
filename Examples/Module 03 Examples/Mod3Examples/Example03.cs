using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3Example03 {
    internal class Program {
        public static void Main(string[] args) {
            string? name = "start";
            while (name != null && name != "") {
                Console.Write("Please enter an animal name: ");
                name = Console.ReadLine();
                Console.WriteLine($"You entered: {name}");
            }
        }
    }
}
