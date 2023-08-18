using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Factory
{
    public class BankA : IBank
    {
        public string Deposit()
        {
            return "Deposit A is done";
        }

        public string Withdraw()
        {
            return "Withdraw A is done";
        }
    }
}
