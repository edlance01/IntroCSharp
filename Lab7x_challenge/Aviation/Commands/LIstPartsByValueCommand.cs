using Aviation.Interfaces; //

namespace Aviation.Commands
{
    public class ListPartsByValueCommand : ICommand //
    {
        private readonly Inventory _inventory;

        public ListPartsByValueCommand(Inventory inventory)
        {
            _inventory = inventory;
        }

        public void Execute()
        {
            _inventory.PrintAviationPartsByValue(); // Calls the PrintAviationPartsByValue method on the Inventory object
        }
    }
}