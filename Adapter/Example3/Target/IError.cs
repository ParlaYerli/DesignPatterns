using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Example3.Target
{
    public interface IError
    {
        public int ErrorNumber { get; set; }
        public string Description { get; set; }
        public void SendMail();
    }
}
