using Builder.Example2.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Example2.Director
{
    public class DirectorCar
    {
        public void Construction(ICarBuilder car)
        {
            car.SetKM();
            car.SetMarka();
            car.SetModel();
            car.SetVites();
        }
    }
}
