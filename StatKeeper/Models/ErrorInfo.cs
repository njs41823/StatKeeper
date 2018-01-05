using System;

namespace StatKeeper.Models
{
    public class ErrorInfo
    {
        public ErrorInfo(Exception exception, string message)
        {
            Exception = exception;
            Message = message;
        }

        public Exception Exception { get; }

        public string Message { get; }
    }
}