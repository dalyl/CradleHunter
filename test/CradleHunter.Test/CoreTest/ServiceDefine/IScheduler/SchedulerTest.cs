using CradleHunter.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace CradleHunter.Test.CoreTest
{
    public class SchedulerTest : IScheduler
    {
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