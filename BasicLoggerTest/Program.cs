﻿using System;
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

            Logging.WriteLine(args[0]);
            Logging.WriteLine("tested @ {0}", DateTime.Now);
        }
    }
}