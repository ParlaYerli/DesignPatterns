using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Example1
{
    public class GenelMail : IMail
    {
        public string from;
        public string to;
        public GenelMail(string from,string to)
        {
            this.from = from;
            this.to = to;
        }
        public void Send()
        {
            Console.WriteLine("Mail, {0} kişisinden {1} kişine gidiyor.", from, to);
        }
    }
}
