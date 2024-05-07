using System;
namespace Curs10T;
public class PosTerminal
{
    public void PayWithContactFull(double amount)
    {
        Console.WriteLine($"Introdu cardul...");
        Console.WriteLine($"Efectueaza plata de {amount} lei...");
        Console.WriteLine($"Retrage cardul...");
        Console.WriteLine($"Emite chitanta pentru suma de {amount} lei.");
    }

    public void PayWithContactless(double amount)
    {
        Console.WriteLine($"Apropiati cardul...");
        Console.WriteLine($"Efectueaza plata contactless de {amount} lei...");
        Console.WriteLine($"Emite chitanta pentru suma de {amount} lei.");
    }
}
