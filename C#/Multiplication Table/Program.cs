using System;
using System.Transactions;

namespace MeuProjetoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the multiplication table program!");
            int number = int.Parse (Console.ReadLine());

            Console.WriteLine($"Multiplication table for {number}:");

            Console.WriteLine($"Multiplication table whit FOR");
            for (int i = 0; i <= 10; i++) // Iterations with known count
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }

            Console.WriteLine($"Multiplication table whit WHILE");
            int j = 0;
            while (j <= 10) // Itertions whith event-based condition
            {
                Console.WriteLine($"{number} x {j} = {number * j}");
                j++;
            }
            
            Console.WriteLine($"Multiplication table whit DO WHILE");
            int k = 0; // When execuion must occur at least once
            do
            {
                Console.WriteLine($"{number} x {k} = {number * k}");
                k++;
            } while (k <= 10);

            Console.WriteLine("Press ENTER to exit.");
            Console.ReadKey();
        }
    }
}