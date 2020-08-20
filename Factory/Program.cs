using Factory.Example1.Abstract;
using Factory.Example1.Enumeration;
using Factory.Example2;
using Factory.Example2.Abstract;
using Factory.Example3;
using Factory.Example3.Abstract;
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
            Console.WriteLine("");

            ///example2
            EmployeeFactory concreteEmployee = new ConcreteEmployeeFactory();
            IFactory permanentEmployee = concreteEmployee.GetFactoryEmployee("PermanentEmployee");

            permanentEmployee.Details();
            Console.WriteLine("");

            ///example 3
            Creator creator = new Creator();
            IProduct product1 = creator.GetProduct(ProductType.Product1);
            product1.ShipFrom();
            Console.ReadKey();
        }
    }
}
