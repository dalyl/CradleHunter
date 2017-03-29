using System;
using System.Collections.Generic;
using System.Text;

namespace CradleHunter.Core
{
    public interface IScheduler
    {
        void Fail();

        void Fail(StatusResult status);
    }
}
