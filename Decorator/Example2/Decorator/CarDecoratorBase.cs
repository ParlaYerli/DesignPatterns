using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Example2.Decorator
{
    public class CarDecoratorBase : ICarDecorator
    {
        internal ICarDecorator Car;
        public CarDecoratorBase(ICarDecorator car)
        {
            Car = car;
        }
        public virtual void AddDescription(string addedDesc)
        {
            Car.AddDescription(addedDesc);
        }

        public virtual void AddPrice(decimal addedPrice)
        {
            Car.AddPrice(addedPrice);
        }

        public virtual void PrintDetail()
        {
            Car.PrintDetail();
        }
    }
}
