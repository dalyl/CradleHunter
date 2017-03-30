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

}
