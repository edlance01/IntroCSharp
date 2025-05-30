decimal totalOrder = 0.0m;
bool stopLoop = false;
bool validPart = false;
bool validQty = false;
bool validPrice = false;

for (int i = 0; i < 3 && !stopLoop; i++)
{
    string? partNumber = "UNKNOWN";

    while (!validPart)
    {
        Console.Write("\nPlease enter an aviation part number (Ctrl+Z to exit): "); 
        partNumber = Console.ReadLine();

        if(partNumber == null)
        {
            Console.WriteLine("Program terminating");
            stopLoop = true;
            break;
        }

        if (string.IsNullOrEmpty(partNumber))
        {
            Console.WriteLine("Nothing was entered for part number.");
            continue;

        }
        else
        {
            validPart = true;
        }
    }

    if (stopLoop) // Check if stopLoop became true in the previous block
    {
        break; // Exit the outer for loop
    }

    int partQuantity = 0;
    while (!validQty)
    {
        Console.Write("\nPlease enter an integer for the quantity of the part you requested (Ctrl+Z to exit): ");
        string? quantity = Console.ReadLine();

        if (quantity == null)
        {
            Console.WriteLine("Program terminating");
            stopLoop = true;
            break;
        }

        if (string.IsNullOrEmpty(quantity))
        {
            Console.WriteLine("Nothing was entered for quantity.");
            continue;
        }
        else if(!int.TryParse(quantity, out partQuantity) || partQuantity <= 0)
        {
            Console.WriteLine("Quantity must be an integer greater than zero.");
            continue;
        }
        else
        {
            validQty = true;
        }
    }

    if (stopLoop) // Check if stopLoop became true in the previous block
    {
        break; // Exit the outer for loop
    }

    decimal partPrice = 0.0m;

    while(!validPrice)
    {
        Console.Write("\nPlease enter a decimal for the price for the part you requested (Ctrl+Z to exit): ");
        string? price = Console.ReadLine();

        if (price == null)
        {
            Console.WriteLine("Program terminating");
            stopLoop = true;
            break;
        }
        if (string.IsNullOrEmpty(price))
        {
            Console.WriteLine("Nothing was entered for price.");
            continue;
        }
        else if (!decimal.TryParse(price, out partPrice) || partPrice <= 0)
        {
            Console.WriteLine("Part price must be a decimal greater than 0.");    
            continue;
             
        }
        else
        {
            validPrice = true;
        }
    }

    if (!stopLoop) //Only calc and print if stopLoop is still false.
    {
        decimal partValue = partQuantity * partPrice;
        totalOrder += partValue;
        Console.WriteLine($"The inventory value for {partNumber} is: {partValue}");
    }

    validPart = false;
    validQty = false;
    validPrice = false;

}

if (!stopLoop) //Only calc and print if stopLoop is still false.
{
    Console.WriteLine($"\nThe total order is: {totalOrder}");
}
else
{
    Console.WriteLine("\nOrder processing was terminated early.");
}





