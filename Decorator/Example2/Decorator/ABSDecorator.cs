using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Example2.Decorator
{
    public class ABSDecorator : CarDecoratorBase
    {
        public ABSDecorator(ICarDecorator car) : base(car)
        {

        }

        public override void PrintDetail()
        {
            Car.AddPrice(23.0m);
            Car.AddDescription(" ABS added to current car");
            Car.PrintDetail();
        }
    }
}
