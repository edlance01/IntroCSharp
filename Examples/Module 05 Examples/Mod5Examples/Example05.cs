using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod5Example05 {
    internal class Program {
        public static void Main(string[] args) {
            int[] scores = new int[ 5 ];
            for (int i = 0; i < scores.Length; i++) {
                Console.WriteLine($"{i} = {scores[ i ]}");
            }
            Object[] objects = new Object[ 5 ];
            for (int i = 0; i < objects.Length; i++) {
                Console.WriteLine($"{i} = {objects[ i ] == null}");
            }
        }
    }
}