using CradleHunter.Core;
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

}
