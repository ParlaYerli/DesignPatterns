using Adapter.Example3.Adaptee;
using Adapter.Example3.Target;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Example3.Adapter
{
    public class FaxAdapter : IError
    {
        private Fax _fax;
        public FaxAdapter(Fax fax)
        {
            _fax = fax;
        }
        
        private int _errorNumber;
        private string _description;
        public int ErrorNumber
        {
            get { return _fax.FaxErrorCode; }
            set { _fax.FaxErrorCode = value; }
        }

        public string Description
        {
            get { return _fax.ErrorDescription; }
            set { _fax.ErrorDescription = value; }
        }

        public void SendMail()
        {
            Console.WriteLine("{0} {1} --> Fax Hatası gönderildi", ErrorNumber, Description);
        }
    }
}
