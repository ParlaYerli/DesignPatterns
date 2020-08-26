using Facade.Example3.Manager;
using Facade.Example3.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Example3.Facade
{
    public class FacadeCustomer
    {
        private EFTManager _eftManager;
        private CreditManager _creditManager;

        public FacadeCustomer()
        {
            _eftManager = new EFTManager();
            _creditManager = new CreditManager();
        }

        public void SendEFT(Customer fromCustomer, Customer toCustomer, decimal eftAmount)
        {
            _eftManager.SendEFT(fromCustomer, toCustomer, eftAmount);
        }

        public void UseCredit(Customer customer)
        {
            _creditManager.UseCredit(customer);

        }
    }
}
