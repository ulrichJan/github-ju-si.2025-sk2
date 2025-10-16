using System;

class Program
{
    static void Main()
    {
        Console.Write("Zadej číslo: ");
        string vstup = Console.ReadLine();  // Načteme číslo jako text

        int soucet = 0;

        foreach (char znak in vstup)
        {
            if (char.IsDigit(znak))  // Ověříme, že jde o číslici
            {
                soucet += znak - '0'; // Převedeme znak na číslo pomocí ASCII
            }
        }

        Console.WriteLine($"Součet číslic je: {soucet}");
    }
}
