using Aviation.Interfaces; //

namespace Aviation.Commands
{
    public class ExitCommand : ICommand //
    {
        public void Execute()
        {
            Console.WriteLine("Exiting application."); // Prints an exit message
        }
    }
}