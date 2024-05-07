using System;
namespace Curs10T;
public interface PaymentMethod
{
    void MakePayment(double amount);
}