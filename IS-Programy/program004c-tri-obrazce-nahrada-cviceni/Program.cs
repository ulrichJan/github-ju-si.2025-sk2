using System;

class Program
{
    static void Main()
    {
        Console.Write("Jaký obrazec chceš vykreslit (A - šachovnice, B - kosočtverec (obrys), C - písmeno N): ");
        char volba = Char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();

        Console.Write("Zadej velikost (celé číslo >= 2): ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n < 2)
        {
            Console.WriteLine("Neplatná velikost. Zadej celé číslo >= 2.");
            return;
        }
        Console.WriteLine();

        switch (volba)
        {
            case 'A':
                VykresliSachovnici(n);
                break;
            case 'B':
                VykresliKosoctverecObrys(n);
                break;
            case 'C':
                VykresliPismenoN(n);
                break;
            default:
                Console.WriteLine("Neplatná volba. Zvol A, B nebo C.");
                break;
        }
    }

    // A: šachovnice hvězdiček (střídání)
    static void VykresliSachovnici(int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                // střídání podle součtu indexů
                if ((i + j) % 2 == 0)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }

    // B: kosočtverec - pouze obrys
    // Používáme mřížku n x n, střed = n/2; obrys určujeme Manhattan vzdáleností
    static void VykresliKosoctverecObrys(int n)
    {
        int mid = n / 2;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                // body, které leží na "hranici" kosočtverce
                if (Math.Abs(i - mid) + Math.Abs(j - mid) == mid)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }

    // C: písmeno N (hvězdičky na první a poslední sloupci + diagonála)
    static void VykresliPismenoN(int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j == 0 || j == n - 1 || j == i)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
