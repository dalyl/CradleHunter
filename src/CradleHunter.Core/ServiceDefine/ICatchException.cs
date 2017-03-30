using System;
using System.Collections.Generic;
using System.Text;

namespace CradleHunter.Core
{
    public interface ICatchException
    {
        void Catch(string name, Exception ex);
    }
}
