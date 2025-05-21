using Aviation.Interfaces; 
    
namespace Aviation.Commands
{
    public class AddEngineCommand : ICommand //
    {
        private readonly Inventory _inventory;

        public AddEngineCommand(Inventory inventory)
        {
            _inventory = inventory;
        }

        public void Execute()
        {
            _inventory.AddPart(_inventory.AddEngine()); // Calls the AddPart and AddEngine methods on the Inventory object
        }
    }
}