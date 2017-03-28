using CradleHunter.Core;
using CradleHunter.Hangfire;
using CradleHunter.Test.CoreTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CradleHunter.Test.HangfireTest
{
 

    [TestClass]
    public class HangfireMonitorTest: MonitorBaseTest
    {
        public override IMonitor TestModel => new HangfireMonitor();

        [TestMethod]
        public void Info()
        {
            base.Info("test");
        }

        [TestMethod]
        public void StartWatch()
        {
            base.StartWatch();

        }

        [TestMethod]
        public void StopWatch()
        {
            base.StopWatch();
        }
    }
}
