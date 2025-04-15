using System;

namespace MeuProjetoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Access program!");

                Console.Write("Enter your password: ");
            string access = Console.ReadLine();

            if(access == "904008")
            {
                Console.WriteLine("Access allowed.");
            }
            else
            {
                Console.WriteLine("Access denied.");
            }
            Console.ReadKey();
        }
    }
}