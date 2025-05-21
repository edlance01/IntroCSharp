using Aviation.Interfaces; //

namespace Aviation.Commands
{
    public class PrintInventoryTotalsCommand : ICommand //
    {
        private readonly Inventory _inventory;

        public PrintInventoryTotalsCommand(Inventory inventory)
        {
            _inventory = inventory;
        }

        public void Execute()
        {
            _inventory.PrintInventoryTotals(); // Calls the PrintInventoryTotals method on the Inventory object
        }
    }
}