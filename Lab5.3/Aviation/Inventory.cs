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
        //array of AviationParts that is 100 elements long
        private AviationPart[] AviationParts { get; } = new AviationPart[100];
        //counter to show me populated elemtns of the AviationParts array
        private int AviationPartsCount { get; set; } = 0;

        //calculates and holds total quantity of ALL elements in the array
        public int TotalQuantity
        {
            get
            {
                int totalQuantity = 0;
                for (int i = 0; i < AviationPartsCount; i++)
                {
                    totalQuantity += AviationParts[i].Quantity;
                }
                return totalQuantity;
            }
        }
        //this is total value of ALL objects populated in my array
        public decimal TotalValue   
        {
            get
            {
                decimal totalValue = 0;
                for (int i = 0; i < AviationPartsCount; i++)
                { 
                    totalValue += AviationParts[i].Quantity * AviationParts[i].Price;
                }
                return totalValue;
            }
        }

        
        public void CommandController()
        {
            
       
            while (true)
            {
                //get user input
                Console.Write("Please enter a command: add, list, total, or exit: ");
                string? command = Console.ReadLine();

                //switch statements acts as the controller
                switch (command)
                {
                    case "add":
                        var part = AddAviationPart();
                        if (part != null)
                        {
                            //loops through array and overwrites values IF it finds a matching part number
                            int i;  //want to use i outside of for loop
                            for (i =0; i < AviationPartsCount; i++)
                            {
                                if (AviationParts[i].Number.Equals(part.Number, StringComparison.OrdinalIgnoreCase))
                                {
                                    AviationParts[i] = part;
                       
                                    break;
                                }
                            }
                            //assigns currently created part to first open slot in array
                            if (i == AviationPartsCount)
                            {
                                AviationParts[AviationPartsCount] = part;
                                AviationPartsCount++;
                            }

                            //calculates and calls function to print value for just CURRENT part
                            decimal partValue = part.Quantity * part.Price;
                            PrintCurrentPartValue(part.Number, partValue);
                        }
                        break;
                    case "list":
                        //PrintAviationParts(AviationParts, AviationPartsCount);
                        PrintAviationParts();
                        break;
                    case "total":
                        PrintInventoryTotals(TotalQuantity, TotalValue);
                        break;

                    case "exit":
                        return;

                    default:
                        Console.WriteLine("Unknown command, please enter add, list, total, or exit.");
                        break;
                }
            }

        }
         
        //private void PrintAviationParts(AviationPart[] avaiationParts, int aviationPartsCount)
        //{
        //    Console.WriteLine("Aviation Parts: ");
        //    for (int i = 0; i < aviationPartsCount; i++)
        //    {
        //        Console.WriteLine($"Part Number: {AviationParts[i].Number}, Name: {AviationParts[i].Name}, Quantity: {AviationParts[i].Quantity}" +
        //                            $" Price: {AviationParts[i].Price}, Value: {AviationParts[i].Quantity * AviationParts[i].Price}");
        //    }
        //}

        //this method loops through the array and prints all values of all properties
        private void PrintAviationParts()
        {
            Console.WriteLine("Aviation Parts: ");
            for (int i = 0; i < AviationPartsCount; i++)
            {
                Console.WriteLine($"Part Number: {AviationParts[i].Number}, Name: {AviationParts[i].Name}, Quantity: {AviationParts[i].Quantity}" +
                                    $" Price: {AviationParts[i].Price}, Value: {TotalValue}");
            }
        }

        private void PrintCurrentPartValue(string? partNumber, decimal partValue)
        {
            Console.WriteLine($"The part value for {partNumber} is: {partValue}");
        }

        private void PrintInventoryTotals(int totalQuantity, decimal totalValue)
        {
            Console.WriteLine($"The total inventory quantity is: {totalQuantity}");
            Console.WriteLine($"The total inventory value is: {totalValue}");
        }

        //collects the actual data for each property by invoking its specific method
        //creates (instatiates) an AviationPart object (instance)
        //returns the AviationPart instance to the caller
        private AviationPart? AddAviationPart()
        {
            string? partNumber = AddAviationPartNumber();
            if (string.IsNullOrEmpty(partNumber))
            {
                return null;
            }

            string partName = AddAviationPartName(partNumber);
            int partQuantity = AddAviationPartQuantity(partNumber);
            decimal partPrice = AddAviationPartPrice(partNumber);
            AviationPart myPart = new AviationPart() { Number = partNumber, Name = partName, Quantity = partQuantity, Price = partPrice };
            return myPart;
        }

        private string? AddAviationPartNumber()
        {

            Console.WriteLine("Please enter an aviation part number (or nothing to exit): ");
            string? partNumber = Console.ReadLine();
            return partNumber;

        }

        //get a valid part NAME from the user and return it
        private string AddAviationPartName(string partNumber)
        {
            while (true)
            {
                Console.WriteLine($"Please enter an aviation part name for part {partNumber}: ");
                string? partName = Console.ReadLine();
                if (!string.IsNullOrEmpty(partName))
                {
                    return partName;
                }
                Console.WriteLine("Bad part name, please enter a valid part name.");

            }
        }

        // gets a valid part quantity from the user
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

        //gets valid price from user
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
