

//using Aviation;
namespace Aviation
{

    class Program
    {
        /*
         * This is the starting point, it instantiates Inventory and invokes CommandController.
         */
        public static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            inventory.CommandController();
        }

    }

}