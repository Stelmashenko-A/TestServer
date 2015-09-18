using System.Collections.Generic;
using System.Diagnostics;

namespace TestServer
{
    internal interface ITester
    {
        void Test(Process proc, Dictionary<string, string> testCases, string inputDirectory, string outputDirectory,
            out Result result);
    }
}