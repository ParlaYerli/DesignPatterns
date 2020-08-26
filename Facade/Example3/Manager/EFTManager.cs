using Facade.Example3.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Example3.Manager
{
    public class EFTManager
    {
        public void SendEFT(Customer fromCustomer, Customer toCustomer, decimal eftAmount)
        {
            if (ControlManager.CheckHasEnoughCashInBankAccount(fromCustomer, eftAmount))
            {
                fromCustomer.CashAmount -= eftAmount;
                Console.WriteLine("EFT " + toCustomer.CustomerNumber + " nolu hesaba gönderildi..");
            }
            else
                Console.WriteLine("Hesabınızda yeterli miktar olmadığı için EFT işleminiz gerçekleştirilemedi.");
        }
    }

}
