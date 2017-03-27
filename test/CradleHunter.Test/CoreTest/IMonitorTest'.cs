using CradleHunter.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CradleHunter.Test.CoreTest
{
    [TestClass]
    public class IMonitorTest : IMonitor
    {
        [TestMethod]
        public void Info(string message)
        {
            Console.WriteLine(message);

        }

        [TestMethod]
        public void StartWatch()
        {
            Console.WriteLine("Monitor TASKS");

        }

        [TestMethod]
        public void StopWatch()
        {
            Console.WriteLine("Monitor TASKS");

        }

    }
}
