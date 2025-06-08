decimal totalValue = 0.0m;
bool exitProgram = false;
while (!exitProgram)
{
    Console.Write("Please enter a command: add, total, or exit: ");
    string? command = Console.ReadLine();
    switch (command)
    {
        case "add":
            string? partNumber;
            while (true)
            {
                Console.Write("Please enter an aviation part number: ");
                partNumber = Console.ReadLine();
                if (string.IsNullOrEmpty(partNumber))
                {
                    Console.WriteLine("Nothing was entered.");
                    continue;
                }
                break;
            }
            int partQuantity = 0;
            while (true)
            {
                Console.Write($"Please enter a quantity of part {partNumber}: ");
                string? quanity = Console.ReadLine();
                if (!int.TryParse(quanity, out partQuantity) || partQuantity <= 0)
                {
                    Console.WriteLine("Bad quantity, please enter a integer greater than zero.");
                    continue;
                }
                break;
            }
            decimal partPrice = 0.0m;
            while (true)
            {
                Console.Write($"Please enter a price for part {partNumber}: ");
                string? price = Console.ReadLine();
                if (!decimal.TryParse(price, out partPrice))
                {
                    Console.WriteLine("Bad price, please enter a decimal price.");
                    continue;
                }
                break;
            }
            decimal partValue = partQuantity * partPrice;
            totalValue += partValue;
            Console.WriteLine($"The inventory value for {partNumber} is: {partValue}");
            break;
        case "total":
            Console.WriteLine($"The total inventory value is: {totalValue}");
            break;
        case "exit":
            //goto EndProgram;
            exitProgram = true;
            break;
        default:
            Console.WriteLine("Unknown command, please enter add, total, or exit.");
            break;
    }
}
//EndProgram:;