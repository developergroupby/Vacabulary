using System;
using NLog;

namespace Common.Logging
{
    public class Logger : Contracts.Logging.ILogger
    {
        private readonly NLog.Logger logger = LogManager.GetLogger("Vacabulary");

        public void Error(string message)
        {
            logger.Error(message);
        }

        public void Error(Exception exception)
        {
            logger.Error(exception);
        }
    }
}
