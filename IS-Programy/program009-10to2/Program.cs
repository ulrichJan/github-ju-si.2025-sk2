string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("*********** Deset na dvoják** *************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Jan Ulrich  ******************");
    Console.WriteLine("************** 27.10.2025 *******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    // Vstup hodnoty do programu, ale špatně řešený
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());

    // Vstup hodnoty do programu, řešený lépe
    Console.Write("Zadejte desítkové číslo (přirozené číslo): ");
    uint number10;
    while (!uint.TryParse(Console.ReadLine(), out number10))
    {
        Console.Write("Nezadali jste přirozené číslo. Zadejte číslo znovu: ");
    }

    // Převod z desítkové do dvojkové soustavy
    uint[]myArray = new uint[32];
    uint backupNumber = number10;
    uint zbytek;

    int i;
    for (i = 0; backupNumber > 0; i++)
    {
        zbytek = backupNumber % 2;
        myArray[i] = zbytek;
        backupNumber = backupNumber / 2;
    }

    // Výpis výsledku
    Console.WriteLine();
    Console.Write("Číslo " + number10 + " v dvojkové soustavě je: ");
    for (int j = i - 1; j >= 0; j--)
    {
        Console.Write(myArray[j]);
    }

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}
