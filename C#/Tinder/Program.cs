using System;

namespace MeuProjetoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Tinder project program!");

            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            Console.Write("What is your sex? (1 - Woman, 2 - Man): ");
            int sex = int.Parse(Console.ReadLine());

            Console.Write("What is your age? ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("What is your height (e.g., 1.70)? ");
            double height = double.Parse(Console.ReadLine());

            Console.Write("What is your weight (kg)? ");
            double weight = double.Parse(Console.ReadLine());

            Console.Write("What is your hair color? (1 - Blond, 2 - Red, 3 - Other): ");
            int hairColor = int.Parse(Console.ReadLine());

            if (
                sex == 1 &&
                height >= 1.60 && height <= 1.75 &&
                weight >= 50 && weight <= 80 &&
                age >= 22 && age <= 30 &&
                (hairColor == 1 || hairColor == 2)
            )
            {
                Console.WriteLine($"\n{name}, you are a match! 💘");
            }
            else
            {
                Console.WriteLine($"\nSorry {name}, you are not a match. 😢");
            }

            Console.WriteLine("\nPress ENTER to exit.");
            Console.ReadKey();
        }
    }
}
