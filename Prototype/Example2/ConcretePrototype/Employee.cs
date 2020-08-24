using Prototype.Example2.AbstractPrototype;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Example2.ConcretePrototype
{
    public class Employee : PrototypeEmployee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public Employee Clone()
        {
            return (Employee) MemberwiseClone();
        }
    }
}
