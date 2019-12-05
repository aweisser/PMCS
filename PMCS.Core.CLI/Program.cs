using PMCS.Core.CLI;
using System;

namespace PMCS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length > 0)
                PMCSCommand.Run(args);
        }

        
    }
}