using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Example2.Decorator
{
    public class AirBagDecorator : CarDecoratorBase
    {
        public AirBagDecorator(ICarDecorator car): base(car)
        {

        }
        public override void PrintDetail()
        {
            base.Car.AddPrice(6.0m);
            base.Car.AddDescription(" AirBag added to current car");
            base.Car.PrintDetail();
        }
    }
}
