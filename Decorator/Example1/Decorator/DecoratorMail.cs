using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Example1.Decorator
{
    public abstract class DecoratorMail : IMail
    {
        private IMail mail;
        public DecoratorMail(IMail mail)
        {
            this.mail = mail;
        }
        public virtual void Send()
        {
            mail.Send();
        }
    }
}
