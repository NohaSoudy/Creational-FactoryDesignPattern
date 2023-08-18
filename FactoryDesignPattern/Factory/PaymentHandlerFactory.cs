using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Factory
{
    public class PaymentHandlerFactory : IPaymentHandlerFactory
    {
     

        public IBank GetBank(string bankCode)
        {
            switch (bankCode)
            {
                case "123456":
                    return new BankA();
                case "111111":
                    return new BankB();
            }
            return null;
        }

        public IPaymentCard GetCard(string cardCode)
        {
            switch (cardCode)
            {
                case "4321":
                    return new Visa();
                case "2222":
                    return new CreditCard();
            }
            return null;
        }
    }
}
