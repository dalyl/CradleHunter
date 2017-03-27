using CradleHunter.Core;
using CradleHunter.Hangfire;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CradleHunter.Test.HangfireTest
{
    [TestClass]
    public class HangfireSchedulerTest
    {

        public HangfireScheduler Model = new HangfireScheduler();

        [TestMethod]
        public void Fail()
        {
            Model.Fail();

            var status = new StatusResult();
            status.AddError("test");
            Model.Fail(status);
        }

       
    }
}