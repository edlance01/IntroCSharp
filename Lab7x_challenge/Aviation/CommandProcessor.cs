using Aviation.Interfaces; //
using Aviation.Commands; //

namespace Aviation
{
    public class CommandProcessor
    {
        private readonly Dictionary<string, ICommand> _commands;
        private readonly Inventory _inventory;

        public CommandProcessor(Inventory inventory)
        {
            _inventory = inventory;
            _commands = new Dictionary<string, ICommand>(StringComparer.OrdinalIgnoreCase) //
            {
                { "addengine", new AddEngineCommand(_inventory) }, //
                { "addtire", new AddTireCommand(_inventory) }, //
                { "list", new ListPartsCommand(_inventory) }, //
                { "listbyvalue", new ListPartsByValueCommand(_inventory) }, //
                { "total", new PrintInventoryTotalsCommand(_inventory) }, //
                { "exit", new ExitCommand() } //
            };
        }

        public bool ProcessCommand(string? commandName)
        {
            if (string.IsNullOrEmpty(commandName))
            {
                Console.WriteLine("Unknown command, please enter addengine, addtire, list, listbyvalue, total, or exit."); //
                return true; // Continue the loop
            }

            if (_commands.TryGetValue(commandName, out ICommand? command)) //
            {
                command.Execute(); // Execute the found command
                return !commandName.Equals("exit", StringComparison.OrdinalIgnoreCase); // Return false to exit the loop if it's the "exit" command
            }
            else
            {
                Console.WriteLine("Unknown command, please enter addengine, addtire, list, listbyvalue, total, or exit."); //
                return true; // Continue the loop
            }
        }

        public void DisplayAvailableCommands()
        {
            Console.Write("Please enter one of the following commands: "); //
            Console.WriteLine(string.Join(", ", _commands.Keys) + "."); // Dynamically lists available commands
        }
    }
}