using CradleHunter.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CradleHunter.Test.CoreTest
{
    [TestClass]
    public class ISchedulerTest : IScheduler
    {
        public ISchedulerTest()
        {
        }

        [TestMethod]
        public void Fail()
        {
            Console.Write("fail");
        }

        [TestMethod]
        public void Fail(StatusResult status)
        {
            Console.WriteLine("fail:");
            Console.WriteLine(status.Errors);
        }
    }
}
