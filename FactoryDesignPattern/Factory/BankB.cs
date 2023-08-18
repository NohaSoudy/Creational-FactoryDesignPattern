using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Factory
{
    public class BankB : IBank
    {
        public string Deposit()
        {
            return "Deposit B is done";
        }

        public string Withdraw()
        {
            return "Withdraw B is done";
        }
    }
}
