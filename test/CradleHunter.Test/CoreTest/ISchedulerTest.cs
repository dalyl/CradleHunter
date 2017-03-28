using CradleHunter.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CradleHunter.Test.CoreTest
{

    public abstract class ISchedulerBaseTest
    {
        public abstract IScheduler TestModel { get; }

        public void Fail()
        {
            TestModel.Fail();
        }

        public void Fail_Status()
        {
            var status = new StatusResult();
            status.AddError("fail:");
            TestModel.Fail(status);
        }
    }

    public class SchedulerTest : IScheduler
    {
        public void Fail()
        {
            Console.Write("fail");
        }

        public void Fail(StatusResult status)
        {
            Console.WriteLine("fail:");
            Console.WriteLine(status.Errors);
        }
    }

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
