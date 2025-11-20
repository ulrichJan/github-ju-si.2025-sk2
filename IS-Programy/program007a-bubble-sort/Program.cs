using System.Diagnostics;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("******** Generrátor random  čísel **********");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Jan Ulrich  ******************");
    Console.WriteLine("************** 20.11.2025 ******************");
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

    Stopwatch myStopwatch = new Stopwatch();


    int compare = 0; //počet porovnání
    int change = 0; //počet výměn

    myStopwatch.Start();

    //bubble sort
    for (int i = 0; i < n - 1; i++)
    {
        
        for (int j = 0; j < n - i - 1; j++)
        {
            compare++;
            if (myRandNums[j] > myRandNums[j + 1])
            {
                //swap
                int temp = myRandNums[j];
                myRandNums[j] = myRandNums[j + 1];
                myRandNums[j + 1] = temp;
                change++;
            }
        }
    }
    myStopwatch.Stop();

    Console.WriteLine();
    Console.WriteLine("Seřazená čísla jsou:");
    for (int i = 0; i < n; i++)
    {
        Console.Write(myRandNums[i] + " ");
    }

    Console.WriteLine();
    Console.WriteLine("Počet porovnání: {0}", compare);
    Console.WriteLine("Počet výměn: {0}", change);
    Console.WriteLine("Doba běhu: {0} ms", myStopwatch.Elapsed);

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}
