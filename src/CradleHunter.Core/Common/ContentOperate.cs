using System;
using System.Collections.Generic;
using System.Text;

namespace CradleHunter.Core
{
    public abstract class ContentOperate<T> : Operate<IContext<T>>
    {
        public ContentOperate(string name,IContext<T> context) : base(name, context)
        {

        }
    }
}
