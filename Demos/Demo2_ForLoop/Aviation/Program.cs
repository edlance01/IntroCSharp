using System;

public class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Please enter three names:");
        for (int i = 0; i < 4; ++i)
        {
            Console.WriteLine($"Please enter a shoe size for name {i}: ");
            string? shoe_size = Console.ReadLine();
            if (shoe_size == null)
            {
                goto EndLoop;
            }
        }
        
    EndLoop:;
        Console.WriteLine("At the end of the loop.");
    }
}