decimal totalValue = 0.0m;

while (true)
{
    Console.Write("Please enter a command: add, total, or exit: ");
    string? command = Console.ReadLine();

    switch (command)
    {
        case "add":
            if (GetPartDetails(out string? partNumber, out int partQuantity, out decimal partPrice))
            {
                decimal partValue = partQuantity * partPrice;
                totalValue += partValue;
                Console.WriteLine($"The inventory value for {partNumber} is: {partValue}");
            }
            break;
        case "total":
            Console.WriteLine($"The total inventory value is: {totalValue}");
            break;
        case "exit":
            break; // Use return to exit the method cleanly
            //Note a return will return from a function, i.e. it would never run any code in the function after default.
        default:
            Console.WriteLine("Unknown command, please enter add, total, or exit.");
            break;
    }
}

static bool GetPartDetails(out string? partNumber, out int partQuantity, out decimal partPrice)
{
    partNumber = null;
    partQuantity = 0;
    partPrice = 0.0m;

    while (string.IsNullOrEmpty(partNumber))
    {
        Console.Write("Please enter an aviation part number: ");
        partNumber = Console.ReadLine();
        if (string.IsNullOrEmpty(partNumber))
        {
            Console.WriteLine("Nothing was entered.");
        }
    }

    while (true)
    {
        Console.Write($"Please enter a quantity of part {partNumber}: ");
        string? quantityInput = Console.ReadLine();
        if (int.TryParse(quantityInput, out partQuantity) && partQuantity > 0)
        {
            break;
        }
        Console.WriteLine("Bad quantity, please enter an integer greater than zero.");
    }

    while (true)
    {
        Console.Write($"Please enter a price for part {partNumber}: ");
        string? priceInput = Console.ReadLine();
        if (decimal.TryParse(priceInput, out partPrice))
        {
            break;
        }
        Console.WriteLine("Bad price, please enter a decimal price.");
    }

    return true;
}