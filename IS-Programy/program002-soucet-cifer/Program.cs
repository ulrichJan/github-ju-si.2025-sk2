string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("*********** Výpis číselné řady *************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Jan Ulrich *******************");
    Console.WriteLine("************** 16.10.2025 *******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    // Vstup hodnoty do programu, ale špatně řešený
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());

    // Vstup hodnoty do programu, řešený lépe
    Console.Write("Zadejte celé číslo: ");
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte ho znovu: ");
    }

    int suma = 0;
    int numberBackup = number;
    int digit;

    //pokud je číslo záporné, tak ho uděláme kladné
    if (number < 0)
    {
        number = -number;
    }

    while (number > 0)
    {
        digit = number % 10; //získání poslední číslice
        number = (number - digit) / 10; //odstranění poslední číslice
        Console.WriteLine("Hodnota zbytku = {0}", digit);
        suma = suma + digit; //sčítání číslic
    }

    Console.WriteLine("Poslední zbytek je = {0}", number);


    Console.WriteLine("Součet číslic čísla {0} je {1}", numberBackup, suma);
    //musíme poslední zbytek přičíst k sumě
    suma = suma + number;

    Console.WriteLine();
    Console.WriteLine("Pro opakovaní stikněte a");
    again = Console.ReadLine();


}