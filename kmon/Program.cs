using System;
using System.Diagnostics;

namespace kmon
{
    public class Program
    {
        public void Main(string[] args)
        {

            Process process = new Process();
            process.StartInfo.FileName = "nodemon";
            process.StartInfo.Arguments = ParseArgs(args);
            
            process.Start();
            process.WaitForExit();
            Console.WriteLine("Done.");
        }

        string ParseArgs(string[] args)
        {
            var monArgs = "";
            var options = new Options(args);

            if (!options.Errors)
            {
                monArgs = options.ParsedArgs().Trim();
            }

            return monArgs;
        }
    }
}
