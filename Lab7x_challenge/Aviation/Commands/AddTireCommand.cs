using Aviation.Interfaces; //

namespace Aviation.Commands
{
    public class AddTireCommand : ICommand //
    {
        private readonly Inventory _inventory;

        public AddTireCommand(Inventory inventory)
        {
            _inventory = inventory;
        }

        public void Execute()
        {
            _inventory.AddPart(_inventory.AddTire()); // Calls the AddPart and AddTire methods on the Inventory object
        }
    }
}