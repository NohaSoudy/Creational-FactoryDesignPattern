using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Factory
{
    public class CreditCard : IPaymentCard
    {
        public string GetName()
        {
            return "CreditCard Name";
        }

        public string GetProviderInfo()
        {
            return "CreditCard Info";
        }
    }
}
