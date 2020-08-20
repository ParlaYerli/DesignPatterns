using Builder.Example1.Builder;
using Builder.Example1.ConcreteBuilder;
using Builder.Example1.Director;
using Builder.Example2.Builder;
using Builder.Example2.ConcreteBuilder;
using Builder.Example2.Director;
using Builder.Example2.Model;
using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            /// example1
            IBuilderMobilePhone builderMobilePhone = new AndroidMobilePhone();
            DirectorMobilePhone mobilePhone = new DirectorMobilePhone(builderMobilePhone);
            mobilePhone.Construction();
            Console.WriteLine(builderMobilePhone.GetMobilePhone().ToString());



            /// example2
            ICarBuilder carBuilder = new OpelConcreteBuilder();
            DirectorCar car = new DirectorCar();
            car.Construction(carBuilder);
            Console.WriteLine(carBuilder.Car.ToString());
            Console.ReadLine();
        }
    }
}

// model : olay sonunda elde etmek istediğimiz nesnedir. ConcreteBuilder tarafından sınıfı tarafından üretilmektedir.
// concretebuilder : product nesnesini oluşturur. oluşturulacak modelin temel özellik ve donanımını sağlayan sınıftır.
// builder : model nesnesinin oluşturulması için gerekli arayüzü sağlar. ConcreteBuilder nesnesi ile kalıtsak bir durum söz konusudur.
// director : yapılan tasarım sonunda bir builder referansı üzerinden Client tarafından nesne üretim talebine cevap verir.