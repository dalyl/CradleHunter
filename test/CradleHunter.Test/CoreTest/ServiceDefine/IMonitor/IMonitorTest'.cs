using CradleHunter.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CradleHunter.Test.CoreTest
{
  
    [TestClass]
    public class IMonitorTest : MonitorBaseTest
    {
        public override IMonitor TestModel =>  new MonitorTest();

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
