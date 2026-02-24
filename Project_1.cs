using System;
using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
internal class Kalkulator
{

    static (int, int) PoburDwuchLiczb()
    {
        Console.WriteLine("podaj pierwszą liczbe: ");
        int a = int.Parse(Console.ReadLine());
        
        Console.WriteLine("podaj drugą liczbe: ");
        int b = int.Parse(Console.ReadLine());

        return (a, b);
    }

    static void Main()
    {
        int output;

        Console.WriteLine("witaj w kalkulatorze obecne funkcjie to:");
        Console.WriteLine("1 dodawanie");
        Console.WriteLine("2 odejmowanie");


        if (wybur == "1")
        {
            var (input1, input2) = PoburDwuchLiczb();
            output = input1 + input2;
            Console.WriteLine($"{input1} + {input2} = {output}");
        }
        else if (wybur == "2")
        {
            var (input1, input2) = PoburDwuchLiczb();
            output = input1 - input2;
            Console.WriteLine($"{input1} - {input2} = {output}");
        }
        else
        {
            Console.WriteLine("otrzymalen nieodpowiednią liczbe");
            return;
        }
        Console.ReadLine();
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
