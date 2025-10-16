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

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiknětě klávesu *A*");
    again = Console.ReadLine();



}
    
