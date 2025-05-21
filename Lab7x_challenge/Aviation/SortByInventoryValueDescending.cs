using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviation
{
    internal class SortByInventoryValueDescending : IComparer<AviationPart>
    {

        public int Compare(AviationPart? a, AviationPart? b)
        {
            if (a == null || b == null)
            {
                return 0;
            }
            decimal v = ((a.Price * a.Quantity) - (b.Price * b.Quantity));
            return (int)v;
        }
    }
}
