using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviation
{
    internal class Engine : AviationPart
    {
        public int Horsepower { get; set; }

        public override string GetPartInfo()
        {
            return $"{base.GetPartInfo()}, Horsepower: {Horsepower}";
        }
    }
}
