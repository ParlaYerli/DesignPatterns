using Builder.Example2.Builder;
using Builder.Example2.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Example2.ConcreteBuilder
{
    public class ToyotaConcreteBuilder : ICarBuilder
    {
        public ToyotaConcreteBuilder()
        {
            car = new Car();
        }
       
        public override void SetKM()
        {
            car.KM = 392;
        }

        public override void SetMarka()
        {
            car.Marka = "Toyota";
        }

        public override void SetModel()
        {
            car.Model = "Corolla";
        }

        public override void SetVites()
        {
            car.Vites = true;
        }
    }
}
