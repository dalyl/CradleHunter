using CradleHunter.Hangfire;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CradleHunter.Test.HangfireTest
{
    [TestClass]
    public class HangfireMonitorTest
    {
        public HangfireMonitor Model = new HangfireMonitor();

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
