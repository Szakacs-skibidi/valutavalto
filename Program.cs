using System;
using static ConsoleApp4.Class1;

class Program
{
    static void Main()
    {
        Console.Write("Adj meg egy összeget forintban (HUF): ");
        double huf1 = Convert.ToDouble(Console.ReadLine());
        double dollar1 = ValutaÁtváltó.HufToDollar(huf1);
        double eur1 = ValutaÁtváltó.HufToEur(huf1);
        Console.WriteLine($"{huf1} HUF = {dollar1} USD");
        Console.WriteLine($"{huf1} HUF = {eur1} EUR");

        Console.Write("Adj meg egy összeget dollárban (USD): ");
        double dollar2 = Convert.ToDouble(Console.ReadLine());
        double huf2 = ValutaÁtváltó.DollarToHuf(dollar2);
        Console.WriteLine($"{dollar2} USD = {huf2} HUF");

        Console.Write("Adj meg egy összeget euróban (EUR): ");
        double eur3 = Convert.ToDouble(Console.ReadLine());
        double huf3 = ValutaÁtváltó.EurToHuf(eur3);
        Console.WriteLine($"{eur3} EUR = {huf3} HUF");
    }
}
