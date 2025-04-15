using System;
using System.Transactions;

namespace MeuProjetoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the electoral project program!");
            Console.WriteLine("Enter your vote: \n Example \nNumbers 1, 2, 3 and 4 for the respective candidate. \nNumber 5 to vote null. \nNumber 6 to vote blank.");
            int vote = int.Parse (Console.ReadLine());

            if( vote >= 1 && vote <= 5)
                Console.WriteLine("Vote counted successfully!");
            else if (vote == 5)
                Console.WriteLine("Null vote counts!");
            else if (vote == 6)
                Console.WriteLine("White vote counts!");
            else if(vote == 0 || vote > 6)
                Console.WriteLine("Invalid vote!");

            Console.WriteLine("Press ENTER to exit.");
            Console.ReadKey();
        }
    }
}
