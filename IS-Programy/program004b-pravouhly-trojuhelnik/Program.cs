using System;

class Program
{
    static void Main()
    {
        Console.Write("Zadej výšku trojúhelníku: ");
        int vyska = int.Parse(Console.ReadLine());

        for (int i = 1; i <= vyska; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }
    }
}
