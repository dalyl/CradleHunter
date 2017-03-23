using System;
using System.Collections.Generic;
using System.Text;

namespace CradleHunter.Core
{

    public interface IMonitor
    {
        void StartWatch();
        void StopWatch();
        void Info(string message);
    }

    public class ServicesManager
    {
        static ServicesManager() {


        }

        public static ICatchException ExceptionProvider { get; private set; }
        public static Func<IMonitor> CreateMonitor { get; private set; }
    }


    public class ServiceDefaultSetting
    {

    }
}
