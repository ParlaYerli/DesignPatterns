
using Factory.Example3.Abstract;
using Factory.Example3.Manager;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Example3
{
    public class Creator
    {
        public IProduct GetProduct(ProductType productType)
        {
            IProduct product = null;
            switch (productType)
            {
                case ProductType.Product1:
                    product = new Product1();
                    break;
                   
                case ProductType.Product2:
                    product = new Product2();
                    break;
                default:
                    break;
            }
            return product;
        }
    }
}
