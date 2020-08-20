using Builder.Example2.Builder;
using Builder.Example2.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Example2.ConcreteBuilder
{
    public class OpelConcreteBuilder : ICarBuilder
    {
        public OpelConcreteBuilder()
        {
            car = new Car();
        }
        public override void SetKM()
        {
            car.KM = 172;
        }

        public override void SetMarka()
        {
            car.Marka = "Opel";
        }

        public override void SetModel()
        {
            car.Model = "Astra";
        }

        public override void SetVites()
        {
            car.Vites = true;
        }
    }
}
