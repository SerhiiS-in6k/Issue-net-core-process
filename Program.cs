using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //create simple console application or use system programe like gebit, calulator
            var executablePath = "/home/sergiish/Desktop/testdata/StubMicroservice";

            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = executablePath,
                    Arguments = "",
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true,
                },
                EnableRaisingEvents = true,
            };
            process.Start();
            process.Kill();
            process.WaitForExit();
            Console.WriteLine(process.HasExited);
            Console.WriteLine(process.StartTime);
        }
    }
}
