using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CradleHunter.Spider;
using CradleHunter.Core;
using CradleHunter.Test.CoreTest;

namespace CradleHunter.Test.SpiderTest
{
    [TestClass]
    public class SpiderOperaterTest
    {

        public SpiderOperaterTest()
        {
            ServicesManager.AddTransient<IMonitor, IMonitorTest>();
        }


        [TestMethod]
        public void Start()
        {
            var scheduler = new ISchedulerTest();
            var context = new SpiderContext("http://118.41.172.240:62297/cn/", "");
            var spider = new SpiderOperater(scheduler,"œ¬‘ÿ≤‚ ‘", context);
            spider.Start();
        }
    }
}
