using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2Example01 {
    internal class Program {
        public static void Main(string[] args) {
            int x = 5;
            int y = 6;
            if (x == 5 || (y = x) > 0) {
                Console.WriteLine($"x is {x} and y is {y}");   // produces x is 5 and y is 6
            }
        }
    }
}
