
using NPOI.Util;
using Singleton.Example2;
using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Example2
{
    public class StaticBlockInitialization
    {
        private static StaticBlockInitialization instance = createInstance();
		private StaticBlockInitialization()
		{

		}
        public static StaticBlockInitialization createInstance()
        {
			try
			{
				return instance = new StaticBlockInitialization();
			}
			catch (Exception e)
			{
				throw new RuntimeException("Hata", e);
			}
        }
		public static StaticBlockInitialization getInstance() 
		{ 
			return instance; 
		}


    }
}
//static block yöntemi Eager yöntemine benzer ancak aradaki fark, exceptionları
//ele alabiliriz. Yine sınıfın instanceıi uygulama çalıştığında oluşur.