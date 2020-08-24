
using Prototype.Example2.ConcretePrototype;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Example2.AbstractPrototype
{
    public interface PrototypeEmployee
    {
        public Employee Clone();
    }
}
