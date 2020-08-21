using Builder.Example1.Builder;
using Builder.Example1.ConcreteBuilder;
using Builder.Example1.Director;
using Builder.Example2.Builder;
using Builder.Example2.ConcreteBuilder;
using Builder.Example2.Director;
using Builder.Example2.Model;
using Builder.Example3.ConcreteBuilder;
using Builder.Example3.Director;
using Builder.Example3.IBuilder;
using Builder.Example3.Model;
using Builder.Example4.Builder;
using Builder.Example4.Model;
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
           

            /// example 3
            MesajDirector mesaj = new MesajDirector();
            mesaj.Construction(new DogumGunuTebrikBuilder());
            mesaj.Show();
            MesajBuilder builder = new BayramTebrikMesajBuilder();
            mesaj.Construction(builder);
            mesaj.Show();


            /// exampl4 
            var pizzaOrder = new PizzaBuilder(Size.Medium)
                                            .AddCheese()
                                            .AddHam()
                                            .AddMushrooms()
                                            .AddOlives()
                                            .AddPepperoni()
                                            .AddSauce();
            Console.WriteLine("Size : {0}, Sauce : {1}, Pepperoni : {2}, Olives : {3}, Pepperoni : {4}, Ham : {5}",pizzaOrder.Size,pizzaOrder.Sauce,pizzaOrder.Pepperoni,pizzaOrder.Olives,pizzaOrder.Mushrooms,pizzaOrder.Ham);
            Console.ReadLine();
        }
    }
}

// model : olay sonunda elde etmek istediğimiz nesnedir. ConcreteBuilder tarafından sınıfı tarafından üretilmektedir.
// concretebuilder : product nesnesini oluşturur. oluşturulacak modelin temel özellik ve donanımını sağlayan sınıftır.
// builder : model nesnesinin oluşturulması için gerekli arayüzü sağlar. ConcreteBuilder nesnesi ile kalıtsak bir durum söz konusudur.
// director : yapılan tasarım sonunda bir builder referansı üzerinden Client tarafından nesne üretim talebine cevap verir.