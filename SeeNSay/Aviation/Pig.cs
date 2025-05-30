

internal class Pig : Animal, Flyer
{
    public override void Speak()
    {
        Console.WriteLine("Oink");
    }

    public void Fly()
    {
        Console.WriteLine("I'm flying - Swine rules!");
    }
}