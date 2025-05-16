using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod5Example06 {
    internal class Program {
        public static void Main(string[] args) {
            int[] scores = new int[ 5 ];
            scores[ 0 ] = 5;
            scores[ 1 ] = 4;
            scores[ 2 ] = 3;
            scores[ 3 ] = 2;
            scores[ 4 ] = 1;
            for (int i = 0; i < scores.Length; i++) {
                Console.WriteLine($"{i} = {scores[ i ]}");
            }
        }
    }
}