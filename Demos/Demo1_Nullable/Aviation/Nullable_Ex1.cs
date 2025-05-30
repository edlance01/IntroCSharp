
class Nullable_Ex1
{

    internal void NullableStringTest()
    {

        // Step 1: Declare a nullable string variable.
        // The '?' after 'string' indicates that this variable can hold a string value or null.
        string? message = null;
        Console.WriteLine("Step 1: Declaring a nullable string.");
        Console.WriteLine($"Initial value of message: {message}");
        Console.WriteLine();

        // Step 2: Assign a string value to the nullable string.
        message = "Hello, nullable string!";
        Console.WriteLine("Step 2: Assigning a string value.");
        Console.WriteLine($"Value of message after assignment: {message}");
        Console.WriteLine();

        // Step 3: Checking if the nullable string has a value before using it.
        if (message != null)
        {
            Console.WriteLine("Step 3a: The string has a value:");
            Console.WriteLine($"Length of the message: {message.Length}");
            Console.WriteLine($"Uppercase message: {message.ToUpper()}");
        }
        else
        {
            Console.WriteLine("Step 3b: The string is null, so we can't access its properties or methods without a potential error.");
        }
        Console.WriteLine();

        // Step 4: Using the null-coalescing operator (??) with a string.
        string greeting = message ?? "No message available.";
        Console.WriteLine("Step 4: Using the null-coalescing operator (??).");
        Console.WriteLine($"Greeting: {greeting}");

        // Let's set message back to null to see the null-coalescing operator in action again.
        message = null;
        string anotherGreeting = message ?? "Default greeting.";
        Console.WriteLine($"Another greeting when message is null: {anotherGreeting}");

    }
}