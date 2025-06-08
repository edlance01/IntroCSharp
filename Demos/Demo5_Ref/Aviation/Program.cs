using System;

public class RefExample
{

    static void Main(string[] args)
    {
        int myNumber = 5;
        Console.WriteLine($"Original value: {myNumber}");

        AddOne(ref myNumber);

        Console.WriteLine($"New value of myNumber after call to AddOne: {myNumber}");
    }

    public static void AddOne(ref int number)
    {
        number += 1;
        Console.WriteLine($"number inside AddOne: {number}");
    }
}