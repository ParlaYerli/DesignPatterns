using Factory.Example2.Abstract;
using Factory.Example2.Manager;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Example2
{
    public class ConcreteEmployeeFactory : EmployeeFactory
    {
        public override IFactory GetFactoryEmployee(string employeeType)
        {
            switch (employeeType)
            {
                case "PermanentEmployee":
                    return new PermanentEmployee();
                case "TemporaryEmployee":
                    return new TemporaryEmployee();
                default:
                    throw new Exception();
            }
        }
    }
}
