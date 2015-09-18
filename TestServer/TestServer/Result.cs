using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestServer
{
    class Result
    {
        public Result(bool isPassed, FailReason failReason = FailReason.NoFailes, int failedTestNumber = -1)
        {
            IsPassed = isPassed;
            FailReason = failReason;
            FailedTestNumber = failedTestNumber;
        }
        
        public bool IsPassed { get; }

        public FailReason FailReason { get; }

        public int FailedTestNumber { get; }
    }
}
