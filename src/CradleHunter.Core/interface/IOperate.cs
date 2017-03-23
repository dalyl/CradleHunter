using System;
using System.Collections.Generic;
using System.Text;

namespace CradleHunter.Core
{
    public interface IOperate<C> where C : IContext
    {
        C Context { get; set; }
        StatusResult Result { get; }
    }
}
