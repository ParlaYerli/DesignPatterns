using Builder.Example2.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Example2.Builder
{
    public abstract class ICarBuilder
    {
        protected Car car;
        public Car Car { get { return car; } }
        public abstract void SetMarka();
        public abstract void SetModel();
        public abstract void SetKM();
        public abstract void SetVites();
    }
}
