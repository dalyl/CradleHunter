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

    public abstract class MonitorBaseTest
    {

        public abstract IMonitor TestModel { get; }


        public void Info(string message)
        {
            TestModel.Info(message);

        }

        public void StartWatch()
        {
            TestModel.StartWatch();

        }

        public void StopWatch()
        {
            TestModel.StopWatch();

        }
    }

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
