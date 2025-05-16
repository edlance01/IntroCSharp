using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod5Example07 {
    internal class Program {
        public static void Main(string[] args) {
            int[] scores = new int[ 5 ] { 5, 4, 3, 2, 1 };
            for (int i = 0; i < scores.Length; i++) {
                Console.WriteLine($"{i} = {scores[ i ]}");
            }
        }
    }
}