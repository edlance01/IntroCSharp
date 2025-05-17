using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Aviation
{
    internal class Inventory
    {
        public int TotalQuantity { get; private set; }
        public decimal TotalValue { get; private set; }

        public void CommandController()
        {
            
       
            while (true)
            {
                Console.Write("Please enter a command: add, total, or exit: ");
                string? command = Console.ReadLine();
                switch (command)
                {
                    case "add":
                        var part = AddAviationPart();
                        if (part.Number != null)
                        {
                            decimal partValue = part.Quantity * part.Price;
                            PrintInventoryValue(part.Number, partValue);
                            TotalQuantity += part.Quantity;
                            TotalValue += partValue;
                        }
                        break;

                    case "total":
                        PrintInventoryTotals(TotalQuantity, TotalValue);
                        break;

                    case "exit":
                        return;

                    default:
                        Console.WriteLine("Unknown command, please enter add, total, or exit.");
                        break;
                }
            }

        }

        private void PrintInventoryValue(string? partNumber, decimal partValue)
        {
            Console.WriteLine($"The inventory value for {partNumber} is: {partValue}");
        }

        private void PrintInventoryTotals(int totalQuantity, decimal totalValue)
        {
            Console.WriteLine($"The total inventory quantity is: {totalQuantity}");
            Console.WriteLine($"The total inventory value is: {totalValue}");
        }

        private (string? Number, int Quantity, decimal Price) AddAviationPart()
        {
            string? partNumber = AddAviationPartNumber();
            if (string.IsNullOrEmpty(partNumber))
            {
                return (null, 0, 0m);
            }

            int partQuantity = AddAviationPartQuantity(partNumber);
            decimal partPrice = AddAviationPartPrice(partNumber);
            return (Number: partNumber, Quantity: partQuantity, Price: partPrice);
        }

        private string? AddAviationPartNumber()
        {

            while (true)
            {
                Console.WriteLine("Please enter an aviation part number (or nothing to exit): ");
                string? partNumber = Console.ReadLine();
                if (!string.IsNullOrEmpty(partNumber))
                {
                    return partNumber;
                }
                Console.WriteLine("Part number not entered.");
            }

        }

        private int AddAviationPartQuantity(string partNumber)
        {
            while (true)
            {
                Console.WriteLine($"Please enter a quantity of part {partNumber}: ");
                string? quantity = Console.ReadLine();
                if (int.TryParse(quantity, out int partQuantity) && partQuantity > 0)
                {
                    Console.WriteLine($"quantity is {quantity}");
                    return partQuantity;
                }
                Console.WriteLine("Bad quantity, please enter an integer greater than zero.");

            }
        }

        private decimal AddAviationPartPrice(string partNumber)
        {
            while (true)
            {
                Console.WriteLine($"Please enter a price for the part {partNumber}: ");
                string? price = Console.ReadLine();
                if (decimal.TryParse(price, out decimal partPrice) && partPrice > 0)
                {
                    return partPrice;
                }
                Console.WriteLine("Bad price, please enter a decimal price greater than 0.");
            }
        }
    }

}
