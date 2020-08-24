using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Example3.Adaptee
{
    public class Fax
    {
        public int FaxErrorCode { get; set; }
        public string ErrorDescription { get; set; }
        public void Send()
        {
            //fax yolla
        }
        public void Get()
        {
            //fax al
        }
    }
}
