using Aviation.Interfaces; //

namespace Aviation.Commands
{
    public class ListPartsCommand : ICommand //
    {
        private readonly Inventory _inventory;

        public ListPartsCommand(Inventory inventory)
        {
            _inventory = inventory;
        }

        public void Execute()
        {
            _inventory.PrintAviationParts(); // Calls the PrintAviationParts method on the Inventory object
        }
    }
}