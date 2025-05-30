

Console.Write("Enter an aviation part number:");
 
string? partNumber = Console.ReadLine();

if (string.IsNullOrEmpty(partNumber) )
{
    Console.WriteLine("Nothing was entered.");
}
else
{
    Console.WriteLine($"Your entered an aviation part number named {partNumber}");
}

Console.Write("\nPlease enter an integer for the quantity of the part you requested: ");

string? quantity = Console.ReadLine();

Console.Write("\nPlease enter a double for the price for the part you requested: ");

string? price = Console.ReadLine();


if(string.IsNullOrEmpty(quantity) || string.IsNullOrEmpty(price)) 
{
    Console.WriteLine("Neither quanity or price can be empty.");
}
else if(!int.TryParse(quantity, out int partQty))
{
    Console.WriteLine("Quantity must be an integer");
}
else if(!decimal.TryParse(price, out decimal partPrice))
{
    Console.WriteLine("Quantity must be a decimal.");
}
else
{
    double partValue = partQty * partPrice;
    Console.WriteLine($"\nThe total inventory value for {partNumber} is {partValue}");
}


