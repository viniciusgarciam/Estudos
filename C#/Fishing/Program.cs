using System;

namespace MeuProjetoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Fishing program!");

            Console.WriteLine("How many kg does the fish weign? ");
            double kgfish = double.Parse (Console.ReadLine());
            Console.WriteLine($"The fish weighs {kgfish : 0.00}kg.");

            const double kgallowed = 50.00;
            const double finekg = 4.0;

            if(kgfish <= kgallowed) 
            {
                Console.WriteLine("You can fish!");
            }
            else if(kgfish > kgallowed)
            {
                double excess = kgfish - kgallowed;
                double fine = excess * finekg;
                Console.WriteLine($"You have exceeded the limit of {kgallowed : 0.00} kg by {excess : 0.00} kg.");
                Console.WriteLine($"You will be fined $ {fine : 0.00}.");
            }

            Console.WriteLine("Press ENTER to exit.");
            Console.ReadKey();
        }
    }
}
