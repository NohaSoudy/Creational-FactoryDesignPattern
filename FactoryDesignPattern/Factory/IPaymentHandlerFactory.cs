using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Factory
{
    public interface IPaymentHandlerFactory
    {
        IBank GetBank(string bankCode);

        IPaymentCard GetCard(string cardCode);
    }
}
