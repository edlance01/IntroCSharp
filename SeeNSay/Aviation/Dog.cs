using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviation
{
    internal class Dog : Animal
    {
        public override void Speak()
        {
            base.Speak();
            Console.WriteLine("WOOF");
        }

        public new void Sleep()
        {
            base.Sleep();
            Console.WriteLine("...well except dogs get to sleep longer");

        }
    }
}
