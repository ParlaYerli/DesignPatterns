using Factory.Example1.Abstract;
using Factory.Example1.Enumeration;
using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            ///example1
            ILogger logger = new LoggerFactory().CreateLogger(LoggerType.DatabaseLogger);
            logger.Log("system format exception : ");

            Console.ReadKey();
        }
    }
}
