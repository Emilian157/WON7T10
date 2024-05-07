using System;
namespace Curs10T;
public class CashPayment : PaymentMethod
{
    public void MakePayment(double amount)
    {
        Console.WriteLine($"Deschide casa de marcat...");
        Console.WriteLine($"Introdu suma de {amount} lei in casa de marcat...");
        Console.WriteLine($"Inchide casa de marcat...");
        Console.WriteLine($"Emite chitanta pentru suma de {amount} lei.");
    }
}   