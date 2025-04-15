using System;
using System.Transactions;

namespace MeuProjetoConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Sum program!");
            
            int sun = 0;
            for (int i = 1; i <= 10 ; i++ ) // Iterations with known count
            {
                Console.WriteLine($"Enter a number: {i} ");
                int number = int.Parse(Console.ReadLine());
                sun = sun + number;
            }
            Console.WriteLine($"Sum: {sun}");

            Console.WriteLine("Press ENTER to exit.");
            Console.ReadKey();
        }
    }
}