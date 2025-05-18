using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviation
{
    internal class Tire : AviationPart
    {
        public double Size { get; set; }


        public override string GetPartInfo()
        {
            return $"{base.GetPartInfo()}, Tire Size: {Size}";
           
        }
    }
}
