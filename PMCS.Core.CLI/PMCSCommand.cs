using PMCS.Classes;
using System;
using System.IO;

namespace PMCS.Core.CLI
{
    class PMCSCommand
    {
        public static void Run(string[] args)
        {
            string sourcePath = null;
            string outputFile = null;
            string whitelistRegexp = null;
            string blacklistRegexp = null;
            foreach (string arg in args)
            {
                if (arg.StartsWith("/"))
                {
                    if (arg.StartsWith("/o:"))
                    {
                        outputFile = arg.Substring(3);
                    }
                    if (arg.StartsWith("/w:"))
                    {
                        whitelistRegexp = arg.Substring(3);
                    }
                    if (arg.StartsWith("/b:"))
                    {
                        blacklistRegexp = arg.Substring(3);
                    }
                }
                else
                {
                    sourcePath = arg;
                }
            }

            InputSource inputSource = new InputSource();
            inputSource.WhitelistRegexp = whitelistRegexp;
            inputSource.BlacklistRegexp = blacklistRegexp;
            inputSource.ElementID = 0;
            inputSource.ListOfNamespaces.Clear();

            Log("Counting files in {0}", sourcePath);
            inputSource.ProjectFileCount(sourcePath);

            Log("Reading files");
            inputSource.ReadProject(sourcePath, x => Log("- {0}", x));
            inputSource.ProcessNamespaceHierarchy();

            Log("Writing output to {0}", outputFile);
            var writer = (outputFile != null) ? new StreamWriter(outputFile) : Console.Out;
            new MseOutput().WriteMse(inputSource.ListOfNamespaces, writer);
            if (outputFile != null)
                writer.Close();
        }

        private static void Log(string message, params string[] args)
        {
            Console.WriteLine(String.Format(message, args));
        }
    }
}
