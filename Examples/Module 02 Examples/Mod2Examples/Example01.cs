using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2Examples // Changed namespace from Mod2Example01 to Mod2Examples
{
    internal class Example01 // Changed class name from Program to Example01
    {
        public static void Main(string[] args)
        {
            int x = 5;
            int y = 6;
            if (x == 5 || y == x)
            {
                Console.WriteLine($"x is {x} and y is {y}");
            }
        }
    }
}
