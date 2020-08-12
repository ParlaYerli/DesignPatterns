using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Example1
{
    public class MyClass
    {
        private static MyClass _intance;
        private MyClass()
        {

        }

        public static MyClass Instance
        {
            get
            {
                if(_intance==null)
                {
                    _intance = new MyClass();
                }
                return _intance;
            }
        }
        public void SaySomething()
        {
            Console.WriteLine("MyClass class working.. ");
        }
        public string Name { get; set; }
    }
}
