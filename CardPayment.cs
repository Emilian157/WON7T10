using System;
namespace Curs10T;
public class CardPayment : PaymentMethod
{
    public void MakePayment(double amount)
    {
        Console.WriteLine($"Introdu cardul...");
        Console.WriteLine($"Efectueaza plata de {amount} lei...");
        Console.WriteLine($"Retrage cardul...");
        Console.WriteLine($"Emite chitanta pentru suma de {amount} lei.");
    }
}