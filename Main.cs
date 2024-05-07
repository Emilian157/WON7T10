using System;
namespace Curs10T;
class Program
{
    static void Main(string[] args)
    {
        CashRegister cashRegister = new CashRegister(new CashPayment());

        Console.WriteLine("Plata cash:");
        cashRegister.MakePayment(100);


        cashRegister = new CashRegister(new CardPayment());

        Console.WriteLine("\nPlata cu cardul:");
        cashRegister.MakePayment(150);

        PosTerminal posTerminal = new PosTerminal();

        Console.WriteLine("\nPlata contact-full cu POS:");
        posTerminal.PayWithContactFull(200);

        Console.WriteLine("\nPlata contactless cu POS:");
        posTerminal.PayWithContactless(250);
    }
}