using CradleHunter.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace CradleHunter.Hangfire
{
    public class HangfireMonitor: IMonitor
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
}
