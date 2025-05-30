

internal class Cow : Animal
{
    public override void Speak()
    {
        base.Speak();
        Console.WriteLine("MOO");
    }
}