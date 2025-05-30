using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Program;

namespace Aviation
{
    public static class LoggerExtensions
    {
        public static void LogInfo(this ILogger logger, string message)
        {
            Console.WriteLine($"[INFO - Extension]: {message}");
        }

        public static void LogError(this ILogger logger, string message)
        {
            logger.Log($"[ERROR - Extension]: {message}"); // Calls the actual logger's Log method
        }
    }
}
