using System;
using System.Diagnostics;

namespace kmon
{
    public class Program
    {
        public void Main(string[] args)
        {

            while(true) {
                Process process = new Process();
                process.StartInfo.UseShellExecute = false;
                
                process.StartInfo.FileName = "dnx";
                process.StartInfo.Arguments = ParseArgs(args);
                
                Console.WriteLine("Starting {0} {1}, will restart it if it stops. Press Ctrl+C to quit.", 
                    process.StartInfo.FileName, process.StartInfo.Arguments);
                process.Start();
                process.WaitForExit();
                Console.WriteLine("Process stopped with exitcode {0}", process.ExitCode);
                Console.WriteLine("Restarting...");
            }
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
