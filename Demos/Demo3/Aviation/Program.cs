
using System.Runtime.CompilerServices;

public class Program
{

    public static void Main(string[] args)
    {

        //int a = 1;
        //int result = a++ + ++a;
        //Console.WriteLine(result);

        int x = 1;
        int y = 2;
        
        int z = AddPlus(ref x, y);
        Console.WriteLine(z); //10

        Console.WriteLine(x); //6
        Console.WriteLine(y); //2
    }

static int AddPlus(ref int a, int b)
    {
        a += 5;
        b += 2;

    return a + b;
    }

}