using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod5Example08 {
    internal class Program {
        public static void Main(string[] args) {
            int[,] scores = new int[,] {
                { 1, 2, 3, 4, 5 },
                { 11, 12, 13, 14, 15 }
            };
            for (int i = 0; i < scores.Length; i++) {
                for (int j = 0; j < scores.GetLength(1); j++) {
                    Console.Write($"{scores[ i, j ]} ");
                }
            }
        }
    }
}