using System.Collections.Generic;
using System.Diagnostics;

namespace TestServer
{
    internal interface ITester
    {
        void Test(Process proc, IList<string> testCases, string inputDirectory, string outputDirectory, int failedTest,
            FailReason reason);
    }
}
