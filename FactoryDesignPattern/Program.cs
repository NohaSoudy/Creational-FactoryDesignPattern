// See https://aka.ms/new-console-template for more information
using FactoryDesignPattern.Factory;
using System.Xml;

string cardNumber, bankCode,cardCode;

Console.WriteLine("Enter please Card Number:");
cardNumber = Console.ReadLine();

bankCode = cardNumber.Substring(0, 6);

PaymentHandlerFactory payment = new PaymentHandlerFactory();
IBank bank =  payment.GetBank(bankCode);
Console.WriteLine(bank.Withdraw());

Console.WriteLine("Enter please Card Code:");
cardCode = Console.ReadLine();

cardCode = cardCode.Substring(0, 4);

IPaymentCard card = payment.GetCard(cardCode);
Console.WriteLine(card.GetName());

Console.ReadKey();