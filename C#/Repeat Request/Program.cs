using System;
using System.Transactions;

namespace MeuProjetoConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the repeat request program!");
            
            for (int i = 1; i == 1 ; ) // Iterations with known count
            {
                Console.WriteLine($"Do you want to contitue FOR? 1 - Yes / 2 - No");
                i = int.Parse(Console.ReadLine());
            }

            int j = 1;
            while (j == 1) // Itertions whith event-based condition
            {
                Console.WriteLine($"Do you want to contitue WHILE? 1 - Yes / 2 - No");
                j = int.Parse(Console.ReadLine());
            }
            
            int k = 1; // When execuion must occur at least once
            do
            {
                Console.WriteLine($"Do you want to contitue DO WHILE? 1 - Yes / 2 - No");
                k = int.Parse(Console.ReadLine());
            } while (k == 1);

            Console.WriteLine("Press ENTER to exit.");
            Console.ReadKey();
        }
    }
}