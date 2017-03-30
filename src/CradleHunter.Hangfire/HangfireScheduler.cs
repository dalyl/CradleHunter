using CradleHunter.Core;
using Hangfire;
using System;

namespace CradleHunter.Hangfire
{
    public class HangfireScheduler : IScheduler
    {
        public HangfireScheduler()
        {
        }

        public void Fail()
        {
            Console.Write("fail");
        }

        public void Fail(StatusResult status)
        {
            Console.WriteLine("fail:");
            Console.WriteLine(status.Errors);
        }
    }
}
