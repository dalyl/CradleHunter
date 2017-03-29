using CradleHunter.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace CradleHunter.Test.CoreTest
{
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

}
