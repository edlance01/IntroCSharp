

using Aviation;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Starting ...");

        //make an array to hold our animals
        Animal[] animals = new Animal[4];
      

        //instantiate 3 animals
        Pig pig = new Pig();
        Cow cow = new Cow();
        Donkey donkey = new Donkey();

        animals[0] = pig;
        animals[1] = cow;   
        animals[2] = donkey;
        animals[3] = new Dog();

        Dog dog2 = new Dog();
        dog2.Sleep();


        //PrintAnimals(animals);

        //Polymorphism...typical "client" code
        for (int i = 0; i < animals.Length; i++)
        {
            animals[i].Speak();
            animals[i].Sleep();

            //downcast the animal to a Pig (a concrete type)
            //casting to an interface is fine
            if (animals[i] is Flyer)
            {
                Flyer myflyer = (Flyer)animals[i];
                myflyer.Fly();
            }
        }
        
        }



    }

    //static void PrintAnimals(Animal[] animals)
    //{
    //    for (int i = 0; i < animals.Length; i++)
    //    {
    //        Console.WriteLine($"Animal is : {animals[i]}");
    //    }
    //}
//}