string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************************");
    Console.WriteLine("**************Výpis číselné řady************************");
    Console.WriteLine("********************************************************");
    Console.WriteLine("*****************Jan Ulrich*****************************");
    Console.WriteLine("********************************************************");
    Console.WriteLine("********************************************************");
    Console.WriteLine("********************************************************");
    Console.WriteLine();

    //Vstup hodnoty do program, ale špatně řešený
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());

    //Lépe řešeno
    Console.Write("Zadejte první číslo řady: ");
    int first;
    while (!int.TryParse(Console.ReadLine(), out first))
    {
        Console.Write("Neplatný vstup. Zadejte prosím celé číslo: ");
    }

    Console.Write("Zadejte poslední číslo řady: ");
    int last;
    while (!int.TryParse(Console.ReadLine(), out last))
    {
        Console.Write("Neplatný vstup. Zadejte prosím celé číslo: ");
    }

    Console.Write("Zadejte diferenci mezi číslicemi: ");
    int step;
    while (!int.TryParse(Console.ReadLine(), out step))
    {
        Console.Write("Neplatný vstup. Zadejte prosím celé číslo: ");
    }

    //Výpis hodnot
    Console.WriteLine();
    Console.WriteLine("========================================================");
    Console.WriteLine("Zadali jste tyto hodnoty:");
    Console.WriteLine("První číslo řady: {0} ", first);
    Console.WriteLine("Poslední číslo řady: {0} ", last);
    Console.WriteLine("Diferenci mezi číslicemi: {0}", step);
    Console.WriteLine("========================================================");
    Console.WriteLine("První číslo řady je: {0}; Poslední číslo řady je: {1}; Diference mezi číslicemi je: {2}", first, last, step);
    Console.WriteLine("========================================================");

  //Výpis číselné řady
    Console.WriteLine();
    Console.WriteLine("========================================================");
    Console.WriteLine("Číselná řada je:");
    
    int current = first;
    while (current <= last)
    {
        Console.WriteLine(current);
        current = current + step;
    }
    again = Console.ReadLine();





}
    
