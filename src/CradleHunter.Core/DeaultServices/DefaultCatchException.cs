using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace CradleHunter.Core
{
    public class DefaultCatchException : ICatchException
    {
        public  readonly EventId _event;

        private readonly ILogger _logger;

        public DefaultCatchException(ILogger<DefaultCatchException> logger)
        {
            _event = new EventId(10001);
            _logger = logger;
        }

        public void Catch(string name,Exception ex)
        {
            _logger.LogTrace(_event, ex, name);
        }

    }
 
}
