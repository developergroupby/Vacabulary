using System;

namespace Common.Contracts.Logging
{
    public interface ILogger
    {
        void Error(string message);
        void Error(Exception exception);
    }
}
