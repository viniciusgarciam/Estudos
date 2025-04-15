using System;

namespace MeuProjetoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the school project program!");

            const int MAXABSENCES = 80;
            const int ABSCENLIMIT = (int) (0.25 * MAXABSENCES);
            const double AVERAGENOTE = 7;

            Console.WriteLine("Enter how absesnces you had? ");
            int faults = int.Parse (Console.ReadLine());
            
            if(faults >= ABSCENLIMIT)
            {
               
                Console.WriteLine("Enter the first note? ");
                double note1 = double.Parse (Console.ReadLine());
                Console.WriteLine("Enter the second note? ");
                double note2 = double.Parse (Console.ReadLine());
                Console.WriteLine("Enter the third note? ");
                double note3 = double.Parse (Console.ReadLine());
                Console.WriteLine("Enter the fourth note? ");
                double note4 = double.Parse (Console.ReadLine());

                double average = (note1 + note2 + note3 + note4) / 4;

                if (average >= AVERAGENOTE)
                    Console.WriteLine("Student approved!");
                else 
                    Console.WriteLine("Student failed due to note!");
            }
            else
                Console.WriteLine("Student failed due to absences!");

            Console.WriteLine("Press ENTER to exit.");
            Console.ReadKey();
        }
    }
}
