using System;

public class Program
{
    public static void Main(string[] args)
    {
        string userInput1 = "123.4x";
        double parsedValue1;

        if (double.TryParse(userInput1, out parsedValue1))
        {
            Console.WriteLine($"TryParse returned true.  '{userInput1}' was successfully parsed as a double: {parsedValue1}");
            //parsedValue1 can now be used in calculations
            double finalAnswer = 42 + parsedValue1;
            Console.WriteLine($"finalAnswer: {finalAnswer}");
        }
        else
        {
            Console.WriteLine($"TryParse returned false. '{userInput1}' could not be parsed as a double.");
            //parsedValue1 is 0 here
            Console.WriteLine($"parsedValue1 is: {parsedValue1}");
        }

    }
}