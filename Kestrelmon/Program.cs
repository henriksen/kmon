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
            process.StartInfo.Arguments = "--ext \"cs,json\" --exec \"cmd /c k web\"";
            process.Start();
            process.WaitForExit();
            Console.WriteLine("Done.");
        }
    }
}
