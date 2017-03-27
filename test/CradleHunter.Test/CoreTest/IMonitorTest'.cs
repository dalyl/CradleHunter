using CradleHunter.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CradleHunter.Test.CoreTest
{
    public class MonitorTest : IMonitor
    {
        public void Info(string message)
        {
            Console.WriteLine(message);

        }

        public void StartWatch()
        {
            Console.WriteLine("Monitor TASKS");

        }

        public void StopWatch()
        {
            Console.WriteLine("Monitor TASKS");

        }
    }

    [TestClass]
    public class IMonitorTest 
    {
        public IMonitor Model { get; set; } = new MonitorTest();

        [TestMethod]
        public void Info()
        {
            Model.Info("test");
        }

        [TestMethod]
        public void StartWatch()
        {
            Model.StartWatch();

        }

        [TestMethod]
        public void StopWatch()
        {
            Model.StopWatch();

        }
    }

}
