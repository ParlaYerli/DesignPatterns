using Factory.Example1.Abstract;
using Factory.Example1.Enumeration;
using Factory.Example1.Manager;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class LoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger(LoggerType loggerType)
        {
            switch (loggerType)
            {
                case LoggerType.DatabaseLogger:
                    return new DatabaseLogManager();
                case LoggerType.FileLogger:
                    return new FileLogManager();
                case LoggerType.EmailLogger:
                    return new EmailLogManager();
               
                default:
                    break;
            }
            return null;
        }
    }
}
