using Facade.Example3.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Example3.Manager
{
    public static class ControlManager
    {
        public static bool CheckHasEnoughCashInBankAccount(Customer customer, decimal amount)
        {
            if (customer.CashAmount >= amount)
                return true;
            else
                return false;
        }

        public static bool CheckCanUseCredit(string IDNo)
        {
            //test için her zaman return true
            return true;
        }
    }
}
