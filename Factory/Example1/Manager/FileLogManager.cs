using Factory.Example1.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Example1.Manager
{
    public class FileLogManager : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("{0} FileLogManager loglama işlemi ", message);
        }
    }
}
