using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3Example02 {
    internal class Program {
        public static void Main(string[] args) {
            int i = 0;
            do {
                Console.WriteLine($"The value of i is {i}");
                ++i;
            } while (i < 10);
        }
    }
}
