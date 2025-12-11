using System.Diagnostics;

string again = "a";
while (again.ToLower() == "a")
{
    Console.Clear();

    //Metoda pro výpis hlavičky razítka
    razitko();
    ulong a = nactiCislo("Zadejte číslo A: ");
    ulong b = nactiCislo("Zadejte číslo B: ");

    ulong nsd = vypocitatNSD(a, b);
    ulong nsn = vypocitatNSN(a, b, nsd);

    zobrazVysledek(a, b, nsd);
    zobrazVysledek(a, b, nsn);




    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}

static void razitko()
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("*********** Výpočet NSD a NSN  *************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("*************** Jan Ulrich *****************");
    Console.WriteLine("*************** 11.12. 2025 ****************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();
}

static ulong nactiCislo(string zprava)
{
    Console.WriteLine(zprava);
    ulong cislo;
    while (!ulong.TryParse(Console.ReadLine(), out cislo))
    {
        Console.WriteLine("Nezadali jste číšlo jáj koník. Zdeejte vstup znovu");
    }

    return cislo;

}

static ulong vypocitatNSD(ulong a, ulong b)
{
    while(a != b)
    {
        if (a > b)
        {
            a = a-b;
        }
        else
        {
            b = b-a;
        }
    }

    return a;
}

static void zobrazVysledek(ulong a, ulong b, ulong nsd)
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("NSD čísel {0} a {1} je {2}", a, b, nsd);
    Console.ResetColor();
}

static ulong vypocitatNSN(ulong a, ulong b, ulong nsd)
{
    return (a * b) / nsd;
}

