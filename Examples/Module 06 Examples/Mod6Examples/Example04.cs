using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod6Example04 {
    internal class Program {
        public static void Main(string[] args) {
            Crocodile crocodile = new Crocodile() { Name = "Crocodile", Count = 5, Value = 10000.00M };
            Console.WriteLine(crocodile.Feed());    // The Crocodile Feed method is called
            Animal animal = crocodile;
            Console.WriteLine(animal.Feed());    // The Crocodile Feed method is called
        }
    }
    internal class Animal {
        public string Name { get; set; } = "";
        public int Count { get; set; }
        public decimal Value { get; set; }
        public Animal() { }
        public Animal(string Name, int Count, decimal Value) {
            this.Name = Name;
            this.Count = Count;
            this.Value = Value;
        }
        public virtual string Feed() {
            return $"Feeding the {Name}";
        }
    }

    internal class Mammal : Animal {
        public Mammal() { }
        public Mammal(string Name, int Count, decimal Value) : base(Name, Count, Value) {
        }
    }

    internal class Giraffe : Mammal {
        public Giraffe() { }
        public Giraffe(string Name, int Count, decimal Value) : base(Name, Count, Value) {
        }
        public override string Feed() {
            return ($"{base.Feed()} with fresh branches in the high feeder.");
        }
    }

    internal class Reptile : Animal {
        public Reptile() { }
        public Reptile(string Name, int Count, decimal Value) : base(Name, Count, Value) {
        }
    }

    internal class Crocodile : Reptile, Swimmer {
        public Crocodile() { }
        public Crocodile(string Name, int Count, decimal Value) : base(Name, Count, Value) {
        }
        public override string Feed() {
            return $"{base.Feed()} by throwing meat in the water.";
        }
        public string Method { get; set; } = "tail";
        public double Speed { get; set; } = 5.0;
    }

    class Drone {
    }

    class MarineDrone : Drone, Swimmer {
        public string Method { get; set; } = "propeller";
        public double Speed { get; set; } = 10.0;
    }

    interface Swimmer {
        string Method { get; set; }    // limb, tail, etc.
        double Speed { get; set; }
    }
}