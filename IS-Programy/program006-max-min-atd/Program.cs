using System;


string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("******** Generrátor random  čísel **********");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Jan Ulrich  ******************");
    Console.WriteLine("************** 13.11.2025 ******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    // Vstup hodnoty do programu, ale špatně řešený
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());

    // Vstup hodnoty do programu, řešený lépe
    Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte počet znovu: ");
    }

    Console.Write("Zadejte dolní mez (celé číslo): ");
    int lb; // lower bound
    while (!int.TryParse(Console.ReadLine(), out lb))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte mez znovu: ");
    }

    Console.Write("Zadejte horní mez (celé číslo): ");

    int ub; // upper bound
    while (!int.TryParse(Console.ReadLine(), out ub))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte mez znovu: ");
    }

    Console.WriteLine();
    Console.WriteLine("=========================================");
    Console.WriteLine("Počet čísel: {0}, Dolní mez: {1}, Horní mez: {2}", n, lb, ub);
    Console.WriteLine("=========================================");

    //deklarace pole
    int[] myRandNums = new int[n];
    Random rand = new Random();
    //naplnění pole náhodnými čísly
    for (int i = 0; i < n; i++)
    {
        myRandNums[i] = rand.Next(lb, ub + 1); // +1 protože horní mez je exkluzivní
    }
    
    //výpis pole
    Console.WriteLine("Generovaná čísla jsou:");
    for (int i = 0; i < n; i++)
    {
        Console.Write(myRandNums[i] + " ");
    }

    //hlednání maxima, pozice maxima, minima, pozice minima
    int max = myRandNums[0];
    int min = myRandNums[0];
    int posMax = 0;
    int posMin = 0;

    for (int i = 1; i < n; i++)
    {
        if (myRandNums[i] > max)
        {
            max = myRandNums[i];
            posMax = i;
        }
        if (myRandNums[i] < min)
        {
            min = myRandNums[i];
            posMin = i;
        }
    }


    Console.WriteLine();
    Console.WriteLine("==========================================");
    Console.WriteLine($"Maximum: {max}");
    Console.WriteLine($"Pozice maxima v poli: {posMax}");
    Console.WriteLine($"Minimum: {min}");
    Console.WriteLine($"Pozice minima v poli: {posMin}");
    Console.WriteLine("==========================================");

    //Vykreslování přesípacích hodin
    if (max >=3)
    {
        Console.WriteLine();
        Console.WriteLine("==========================================");
        Console.WriteLine();
        Console.WriteLine($"Vykreslování přesípacích hodin o velikosti {max}:");
        Console.WriteLine();

        // Tento cyklus se stará o psravný počet řádků
        for (int i = 0; i < max; i++)
        {
            int spaces, stars;
        }

    }
    else
    {
        Console.WriteLine("Maximální hodnota je příliš malá na vykreslení přesípacích hodin.");
    }

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}
