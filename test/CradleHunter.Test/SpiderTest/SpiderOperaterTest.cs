using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CradleHunter.Spider;
using CradleHunter.Core;
using CradleHunter.Test.CoreTest;
using System.IO;

namespace CradleHunter.Test.SpiderTest
{
    [TestClass]
    public class SpiderOperaterTest
    {

        public SpiderOperaterTest()
        {
            ServiceManager.AddTransient<IMonitor, MonitorTest>();
        }


        [TestMethod]
        public void Start()
        {
            var scheduler = new SchedulerTest();
            var context = new SpiderContext("https://www.baidu.com/", "");
            var spider = new SpiderOperater(scheduler,"œ¬‘ÿ≤‚ ‘", context);
            spider.Start();
            Assert.AreEqual(true, context.Result.Succeeded);
        }
    }
}
