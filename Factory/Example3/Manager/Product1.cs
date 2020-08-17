using Factory.Example3.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Example3.Manager
{
    public class Product1 : IProduct
    {
        public void ShipFrom()
        {
            Console.WriteLine("Product is coming from Turkey");
        }
    }
}
