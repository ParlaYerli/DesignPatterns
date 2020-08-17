using Factory.Example2.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Example2.Manager
{
    public class PermanentEmployee : IFactory
    {
        public void Details()
        {
            Console.WriteLine("This is permanent employee type object");
        }
    }
}
