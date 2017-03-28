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
    public class HangfireSchedulerTest : ISchedulerBaseTest
    {
        public override IScheduler TestModel => new HangfireScheduler();

        [TestMethod]
        public void Fail_Test()
        {
            base.Fail();
        }

        [TestMethod]
        public void Fail_Status_Test()
        {
            base.Fail_Status();
        }
    }

}