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

            if (args != null)
            {
                string monArgs = "";

                foreach (string a in args)
                {

                    monArgs += " " + a;
                }

                process.StartInfo.Arguments += monArgs;
            }

            process.StartInfo.Arguments += " --exec \"cmd /c k web\" ";

            Console.WriteLine(process.StartInfo.Arguments);
            
            process.Start();
            process.WaitForExit();
            Console.WriteLine("Done.");
        }
    }
}
