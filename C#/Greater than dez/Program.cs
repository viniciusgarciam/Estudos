using System;
using System.Transactions;

namespace MeuProjetoConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the program, which number is bigger out of the ten given!");
            
            int greater = int.MinValue;
            for (int i = 1; i <= 10 ; i++ ) // Iterations with known count
            {
                Console.WriteLine($"Enter a number: {i} ");
                int number = int.Parse(Console.ReadLine());
                    if (number > greater)
                        greater = number;
            }
            Console.WriteLine($"Greatest: {greater}");

            Console.WriteLine("Press ENTER to exit.");
            Console.ReadKey();
        }
    }
}