using CradleHunter.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CradleHunter.Test.CoreTest
{

  
    [TestClass]
    public class ISchedulerTest : ISchedulerBaseTest
    {
        public override IScheduler TestModel => new SchedulerTest();

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
