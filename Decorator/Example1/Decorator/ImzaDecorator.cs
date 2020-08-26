using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Example1.Decorator
{
    public class ImzaDecorator : DecoratorMail
    {
        public string imza;
        public ImzaDecorator(IMail mail,string imza) : base(mail)
        {
            this.imza = imza;
        }
        public override void Send()
        {
            base.Send();
            Console.WriteLine("imza : {0} " , imza);
        }
    }
}
