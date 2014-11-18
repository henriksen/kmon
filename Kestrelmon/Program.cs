using System;
using System.Diagnostics;

namespace Kestrelmon
{
    public class Program
    {
        public void Main(string[] args)
        {

            Process process = new Process();
            process.StartInfo.FileName = "nodemon";

            //if (args != null)
            //{
            //    string monArgs = "";

            //    foreach (string a in args)
            //    {

            //        monArgs += " " + a;
            //    }

            //    process.StartInfo.Arguments += monArgs;
            //}

            //process.StartInfo.Arguments += " --exec \"cmd /c k web\" ";

            process.StartInfo.Arguments = ParseArgs(args);

            Console.WriteLine(process.StartInfo.Arguments);
            
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
                monArgs = string.Format("--ext {0} --exec \"cmd /c k {1} \"", options.FileExtensions, options.Server);
            }

            return monArgs;
        }
    }
}
