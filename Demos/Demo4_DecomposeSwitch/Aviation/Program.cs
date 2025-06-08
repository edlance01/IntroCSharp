using System;

public class RefactoringExample
{
    public static void Main(string[] args)
    {
        bool exitApp = false;
        while (exitApp == false)
        {
            Console.WriteLine("Please enter a command: print, save, quit");
            string? command = Console.ReadLine();

            //Console.WriteLine("--- Original Switch Statement ---");

            //// Original switch statement
            //switch (command)
            //{
            //    case "print":
            //        Console.WriteLine("Initiating print operation.");
            //        Console.WriteLine("Sending document to default printer.");
            //        break;
            //    case "save":
            //        Console.WriteLine("Opening save dialog.");
            //        Console.WriteLine("Please choose a location to save the file.");
            //        break;
            //    case "quit":
            //        Console.WriteLine("Exiting the application.");
            //        Console.WriteLine("Goodbye!");
            //        exitApp = true;
            //        break;
            //    default:
            //        Console.WriteLine($"Unknown command: {command}");
            //        break;
            //}


            Console.WriteLine("\n--- Refactored Switch Statement ---");

            //Refactored switch statement using methods
            switch (command)
            {
                case "print":
                    HandlePrintCommand();
                    break;
                case "save":
                    HandleSaveCommand();
                    break;
                case "quit":
                    HandleQuitCommand();
                    exitApp = true;
                    break;
                default:
                    HandleUnknownCommand(command);
                    break;
            }

           
        }
    }

    // Refactored methods
    private static void HandlePrintCommand()
    {
        Console.WriteLine("Initiating print operation.");
        Console.WriteLine("Sending document to default printer.");
    }

    private static void HandleSaveCommand()
    {
        Console.WriteLine("Opening save dialog.");
        Console.WriteLine("Please choose a location to save the file.");
    }

    private static void HandleQuitCommand()
    {
        Console.WriteLine("Exiting the application.");
        Console.WriteLine("Goodbye!");
    }

    private static void HandleUnknownCommand(string? command)
    {
        Console.WriteLine($"Unknown command: {command}");
    }
}