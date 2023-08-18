using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Factory
{
    public class Visa : IPaymentCard
    {
        public string GetName()
        {
            return "Visa Name";
        }

        public string GetProviderInfo()
        {
            return "Visa Info";
        }
    }
}
