using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Example1.Decorator
{
    public class SifreleDecorator : DecoratorMail
    {
        public SifreleDecorator(IMail mail) : base(mail)
        {
        }
        public override void Send()
        {
            base.Send();
            Console.WriteLine("şifrelendi ... ");
        }
    }
}
