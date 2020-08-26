using Facade.Example3.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Example3.Manager
{
    public class CreditManager
    {
        public void UseCredit(Customer customer)
        {
            if (ControlManager.CheckCanUseCredit(customer.IDNo))
                Console.WriteLine("Kredi kullandırılmıştır.");
            else
                Console.WriteLine("Banka kredinizi onaylamamıştır.");
        }
    }
}
