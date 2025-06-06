﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Aviation
{
    internal class Inventory
    {
        private ICollection<AviationPart> AviationParts = new List<AviationPart>();
        private int AviationPartsCount { get; set; } = 0;
        public int TotalQuantity
        {
            get
            {
                int totalQuantity = 0;
                foreach (var aviationPart in AviationParts)
                {
                    totalQuantity += aviationPart.Quantity;
                }
                return totalQuantity;
            }
        }
        public decimal TotalValue
        {
            get
            {
                decimal totalValue = 0;
                foreach (var aviationPart in AviationParts)
                {
                    totalValue += aviationPart.Quantity * aviationPart.Price;
                }
                return totalValue;
            }
        }


        public void CommandController()
        {

            while (true)
            {
                Console.Write("Please enter a command: addengine, addtire, list, total, or exit: ");
                string? command = Console.ReadLine();
                switch (command)
                {
                    case "addengine":
                        AddPart(AddEngine());
                        break;
                    case "addtire":
                        AddPart(AddTire());
                        break;
                    case "list":
                        PrintAviationParts();
                        break;
                    case "total":
                        PrintInventoryTotals();
                        break;
                    case "exit":
                        return;
                    default:
                        Console.WriteLine("Unknown command, please enter addengine, addtire, list, total, or exit.");
                        break;
                }
            }

        }

        
        private void AddPart(AviationPart? part)
        {
            if (part != null)
            {
                AviationPart? removePart = null;
                foreach (AviationPart aviationPart in AviationParts) 
                {
                    if (aviationPart.Number.Equals(part.Number, StringComparison.OrdinalIgnoreCase))
                    {
                        removePart = aviationPart;
                        break;
                    }

                }
                if (removePart != null)
                {
                   AviationParts.Remove(removePart);
                }
                AviationParts.Add(part);
                decimal partValue = part.Quantity * part.Price;
                PrintInventoryValue(part.Number, part.Price);
            }
        }


        private void PrintAviationParts()
        {
            Console.WriteLine("Aviation Parts: ");
            foreach (AviationPart aviationPart in AviationParts) 
            {
                Console.WriteLine(aviationPart.GetPartInfo()); 
            }
        }

        private void PrintInventoryValue(string? partNumber, decimal partValue)
        {
            Console.WriteLine($"The inventory value for {partNumber} is: {partValue}");
        }

        private void PrintInventoryTotals()
        {
            Console.WriteLine($"The total inventory quantity is: {TotalQuantity}");
            Console.WriteLine($"The total inventory value is: {TotalValue}");
        }

        private AviationPart? AddEngine()
        {
            string? partNumber = AddAviationPartNumber();
            if (string.IsNullOrEmpty(partNumber))
            {
                return null;
            }

            string partName = AddAviationPartName(partNumber);
            int partQuantity = AddAviationPartQuantity(partNumber);
            decimal partPrice = AddAviationPartPrice(partNumber);
            int engineHorsepower = AddEngineHorsepower(partNumber);
            return new Engine() { Number = partNumber, Name = partName, Quantity = partQuantity, Price = partPrice, Horsepower = engineHorsepower };
        }

        private AviationPart? AddTire()
        {
            string? partNumber = AddAviationPartNumber();
            if (string.IsNullOrEmpty(partNumber))
            {
                return null;
            }

            string partName = AddAviationPartName(partNumber);
            int partQuantity = AddAviationPartQuantity(partNumber);
            decimal partPrice = AddAviationPartPrice(partNumber);
            double tireSize = AddTireSize(partNumber);
            return new Tire() { Number = partNumber, Name = partName, Quantity = partQuantity, Price = partPrice, Size = tireSize };
        }

        private string? AddAviationPartNumber()
        {

            Console.WriteLine("Please enter an aviation part number (or nothing to exit): ");
            string? partNumber = Console.ReadLine();
            return partNumber;

        }

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

        private int AddEngineHorsepower(string partNumber)
        {
            while (true)
            {
                Console.WriteLine($"Please enter the horsepower for part {partNumber}: ");
                string? horsepower = Console.ReadLine();
                if (int.TryParse(horsepower, out int engineHorsepower) && engineHorsepower > 0)
                {
                    return engineHorsepower;
                }
                Console.WriteLine("Bad horsepower, please enter an integer greater than zero.");

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

        private double AddTireSize(string partNumber)
        {
            while (true)
            {
                Console.WriteLine($"Please enter a tire size for part {partNumber}: ");
                string? size = Console.ReadLine();
                if (double.TryParse(size, out double tireSize) && tireSize > 0)
                {
                    return tireSize;
                }
                Console.WriteLine("Bad tire size please enter a decimal size.");
            }
        }

    }

}
