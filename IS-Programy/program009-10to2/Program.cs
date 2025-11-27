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
    string number2 = "";
    do
    {
        uint remainder = number10 % 2;
        number2 = remainder.ToString() + number2;
        number10 = number10 / 2;
    } while (number10 > 0);

    // Výpis výsledku
    Console.WriteLine();
    Console.WriteLine("Číslo v dvojkové soustavě je: " + number2);










    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}
