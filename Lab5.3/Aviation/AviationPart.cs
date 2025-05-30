using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Aviation
{
    /*
     * Data bucket that holds 4 values ...aka DTO (data transfer objects)
     */
    internal class AviationPart
    {
        public string Number { get; set; } = "";
        public string Name { get; set; } = "";
        public int Quantity { get; set; } = 0;
        public decimal Price { get; set; } = 0m;

    }
}
