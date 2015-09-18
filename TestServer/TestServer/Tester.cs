using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace TestServer
{
    internal class Tester : ITester
    {
        public void Test(Process proc, Dictionary<string, string> testCases, string inputDirectory,
            string outputDirectory, out Result result)
        {
            proc.MaxWorkingSet = new IntPtr(100000);
            var counter = 1;
            foreach (var test in testCases)
            {
                proc.StandardInput.Write(test.Key);

                proc.Start();
                while (proc.WaitForExit(1000))
                {

                }
                if (!proc.HasExited)
                {
                    proc.Kill();
                    result = new Result(false, FailReason.OutOfTime, counter);
                    return;
                }
                if (proc.StandardOutput.ReadToEnd() != test.Value)
                {
                    result = new Result(false, FailReason.WrongAnswer, counter);
                    return;
                }
                counter++;
            }
            result = new Result(true);
        }
    }
}
