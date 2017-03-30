using System;
using System.Collections.Generic;
using System.Text;

namespace CradleHunter.Core
{

    public interface IContext
    {
        StatusResult Result { get; set; }
    }

    public interface IContext<T>: IContext
    {
        T Content { get; set; }
    }


 }
