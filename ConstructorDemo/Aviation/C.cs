
class C : B
{
    public C()
    {
        Console.WriteLine("Welcome");
        Console.WriteLine("C's default constructor");
    }

    public C(String s) : this()
    {
       
        Console.WriteLine($"C string constructor {s}");
    }
}