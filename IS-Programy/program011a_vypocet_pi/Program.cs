string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("*************** Výpočet PI *****************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Jan Ulrich  ******************");
    Console.WriteLine("************** 4.12.2025 *******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();
    
    Console.Write("Zadejte přesnost výpočtu (např: 0,0001 ): ");
    double presnost;
    while (!double.TryParse(Console.ReadLine(), out presnost))
    {
        Console.Write("desetinné číslo. Zadejte desetinné číslo znovu: ");
    }

    int i = 1;    
    double piCtvrt = 1;
    int znamenko = 1;

    while ((1.0 / i) >= (presnost))
    {
        i = i + 2;
        znamenko = -znamenko;
        piCtvrt = piCtvrt + znamenko * 1.0 / i;
    }

    double pi = 4 * piCtvrt;

    Console.WriteLine();
    Console.WriteLine("Pi s danou přesností je: {0}", pi);



    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}
