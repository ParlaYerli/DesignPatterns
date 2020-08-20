using Builder.Example2.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Example2.Builder
{
    public abstract class ICarBuilder
    {
        protected Car car; // protected olmasının sebebi  builderclassın uygulanacağı Deliver classlardan bu fielda erişebilmesi içindir. concrete sınıf modeli üretmişs olacak.
        public Car Car { get { return car; } }
        public abstract void SetMarka();
        public abstract void SetModel();
        public abstract void SetKM();
        public abstract void SetVites();
    }
}
