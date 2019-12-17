using System;
using System.Collections.Generic;
using System.Text;

namespace Extensibility
{
    public class ConsoleLogger : ILogger
    {
        void ILogger.LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }

        void ILogger.LogInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
        }
    }
}
