using System;
using System.Collections.Generic;
using System.Text;

namespace CradleHunter.Core
{
    public class DefaultCatchException : ICatchException
    {
        public const int Level =1;
        
        public ILog Logger { get; }

        public void Catch(Exception ex)
        {
           // Logger
        }

    }

    public interface ILog
    {
    }
}
