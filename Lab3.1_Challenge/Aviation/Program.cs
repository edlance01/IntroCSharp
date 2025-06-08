
/*
 * Format each entry, Part Number left aligned, Quantity right aligned, Part Price and Part Value both 
 * right aligned using currency formatting.
 */


decimal totalOrder = 0.0m;
bool stopLoop = false;

for (int i = 0; i < 3 && !stopLoop; i++)
{
    string? partNumber = null;
    int partQuantity = 0;
    decimal partPrice = 0.0m;
    bool isValidInput = false;

    while (!isValidInput && !stopLoop)
    {
        Console.Write("\nPlease enter an aviation part number (Ctrl+Z to exit): ");
        partNumber = Console.ReadLine();

        //EOF (Ctrl+Z) is read as null
        if (partNumber == null)
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

        if (!int.TryParse(quantity, out partQuantity) || partQuantity <= 0)
        {
            Console.WriteLine("Quantity must be an integer greater than zero.");
            continue;
        }


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

        if (!decimal.TryParse(price, out partPrice) || partPrice <= 0)
        {
            Console.WriteLine("Part price must be a decimal greater than 0.");
            continue;
        }

        isValidInput = true;
    }

    if (!stopLoop)
    {
        decimal partValue = partQuantity * partPrice;
        totalOrder += partValue;
        // Console.WriteLine($"The inventory value for {partNumber} is: {partValue}");
        Console.WriteLine($"{"Part Number",-10} {"Qty",4} {"Price",7} {"Part Value",9}");
        Console.WriteLine($"{partNumber,-10} {partQuantity,5} {partPrice,8:C} {partValue,10:C}");
    }
}

if (!stopLoop)
{
    Console.WriteLine($"\nThe total order is: {totalOrder, -15:C}");
   
}
else
{
    Console.WriteLine("\nOrder processing was terminated early.");
}