using System;
namespace Curs10T;
public class CashRegister
{
    private PaymentMethod paymentMethod;

    public CashRegister(PaymentMethod method)
    {
        paymentMethod = method;
    }

    public void MakePayment(double amount)
    {
        paymentMethod.MakePayment(amount);
    }
}
