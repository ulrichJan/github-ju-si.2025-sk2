using System.Diagnostics;
using System.Linq;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("******** Interval **************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Jan Ulrich  ******************");
    Console.WriteLine("************** 4.12.2025 *******************");
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
    while (n < 0)
    {
        Console.Write("Počet musí být nezáporné celé číslo. Zadejte počet znovu: ");
        while (!int.TryParse(Console.ReadLine(), out n))
        {
            Console.Write("Nezadali jste celé číslo. Zadejte počet znovu: ");
        }
    }

    Console.Write("Zadejte dolní mez (celé číslo): ");
    int lb; // lower bound
    while (!int.TryParse(Console.ReadLine(), out lb))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte mez znovu: ");
    }
    while (lb < 0)
    {
        Console.Write("Dolní mez musí být přirozené číslo (>= 0). Zadejte dolní mez znovu: ");
        while (!int.TryParse(Console.ReadLine(), out lb))
        {
            Console.Write("Nezadali jste celé číslo. Zadejte mez znovu: ");
        }
    }

    Console.Write("Zadejte horní mez (celé číslo): ");

    int ub; // upper bound
    while (!int.TryParse(Console.ReadLine(), out ub))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte mez znovu: ");
    }

    while (ub < lb)
    {
        Console.Write("Horní mez musí být větší nebo rovna dolní meze. Zadejte horní mez znovu: ");
        while (!int.TryParse(Console.ReadLine(), out ub))
        {
            Console.Write("Nezadali jste celé číslo. Zadejte mez znovu: ");
        }
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


    Console.WriteLine();
    // Rozdělení základního intervalu na 4 části a spočítání počtu čísel v každém
    int totalRange = ub - lb + 1; // počet čísel včetně obou mezí
    if (totalRange <= 0)
    {
        Console.WriteLine("Neplatný interval (žádná čísla v rozsahu).\n");
    }
    else
    {
        int baseWidth = totalRange / 4;
        int remainder = totalRange % 4; // přerozdělíme zbytek mezi první intervaly
        int start = lb;
        for (int part = 0; part < 4; part++)
        {
            int width = baseWidth + (part < remainder ? 1 : 0);
            int end = start + width - 1;
            if (width <= 0)
            {
                // Pokud je šířka 0 (např. příliš úzký interval), nastavíme end tak, aby byl start-1
                end = start - 1;
            }

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (myRandNums[i] >= start && myRandNums[i] <= end)
                    count++;
            }

            Console.WriteLine("Počet čísel v intervalu <{0}-{1}>: {2}", start, end, count);
            start = end + 1;
        }
    }
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine() ?? "";

}
