using System;
using BasicLogger;

namespace BasicLoggerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Usage: <text>");
                return;
            }

            // logging is opt-in
            Logging.Enabled = true;

            // write to the log file
            Logging.WriteLine(args[0]);
            Logging.WriteLine("tested @ {0}", DateTime.Now);
        }
    }
}