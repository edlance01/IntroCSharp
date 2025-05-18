using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Aviation
{
    internal abstract class AviationPart
    {
        public string Number { get; set; } = "";
        public string Name { get; set; } = "";
        public int Quantity { get; set; } = 0;
        public decimal Price { get; set; } = 0m;

        public decimal TotalValue
        {
            get
            {
                return Quantity * Price;
            }
        }
        public virtual string GetPartInfo()
        {
            return $"Part Number: {Number}, Name {Name}, Quantity {Quantity}," +
                $" Price: {Price:C}, Total Value: {TotalValue:C}";
        }

    }
}
