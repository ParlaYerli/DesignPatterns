using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Example2
{
    public class EagerInitialization
    {
        private static EagerInitialization instance = new EagerInitialization();
        private EagerInitialization()
        {

        }
        public static EagerInitialization GetEagerInitialization()
        {
            return instance;
        }
    }

}

//bu yöntemde sınıfın instancei sınıfın yüklenme anında oluşur.kolaydır fakat
//sınıf kullanılmasa bile instance oluşur ve gereksiz yer kaplar.