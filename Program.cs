using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение M:");
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение N:");
        int n = int.Parse(Console.ReadLine());

        PrintNaturalNumbersInRange(m, n);

        Console.ReadLine(); 
    }

    static void PrintNaturalNumbersInRange(int m, int n)
    {
        if (m <= n)
        {
            Console.Write($"{m} ");
            PrintNaturalNumbersInRange(m + 1, n);
        }
    }
}