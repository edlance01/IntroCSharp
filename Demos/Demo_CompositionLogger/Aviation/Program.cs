
using System.Runtime.CompilerServices;
using Aviation;

public class Program
{

    public static void Main(string[] args)
    {
        // Usage:
        ILogger logger = new ConsoleLogger();
        logger.Log("Standard log.");
        logger.LogInfo("Info via extension."); // Calls the extension method
        logger.LogError("Error via extension."); // Calls the extension method

    }

}  
  

   