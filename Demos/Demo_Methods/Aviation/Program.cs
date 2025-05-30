
using System.Runtime.CompilerServices;

public class Program
{

    public static void Main(string[] args)
    {
        Program myProgram = new Program();

        myProgram.StepOne();
        myProgram.StepTwo("C# is Fun.");
        int myInt = myProgram.StepThree(5);
        Console.WriteLine($"The value returned from StepThree is: {myInt}");
    }

    void StepOne()
    {
        Console.WriteLine("StepOne is a method with no parameters or return type.");
    }

    void StepTwo(string value)
    {
        Console.WriteLine($"StepTwo is a method that takes one parameter, a string: {value}");
    }

    int StepThree(int num)
    {
        return num * 3;
    }

}