using Builder.Example2.Builder;
using Builder.Example2.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Example2.ConcreteBuilder
{
    public class BMWConcreteBuilder : ICarBuilder
    {
        public BMWConcreteBuilder()
        {
            car = new Car();
        }
        public override void SetKM()
        {
            car.KM = 346;
        }

        public override void SetMarka()
        {
            car.Marka = "BMW";
        }

        public override void SetModel()
        {
            car.Model = "X";
        }

        public override void SetVites()
        {
            car.Vites = true;
        }
    }
}
