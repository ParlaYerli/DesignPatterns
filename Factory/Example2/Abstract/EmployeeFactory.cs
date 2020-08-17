using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Example2.Abstract
{
    public abstract class EmployeeFactory
    {
        public abstract IFactory GetFactoryEmployee(string employeeType);
    }
}
