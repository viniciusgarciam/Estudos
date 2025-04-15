using System;
using System.Transactions;

namespace MeuProjetoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Gas station project program!");

            const double GAS_PRICE = 6.50;
            const double ETHA_PRICE = 3.90;
            const double GAS_DES_MINOR = 0.03;
            const double GAS_DES_MAJOR = 0.05;
            const double ETHA_DES_MINOR = 0.04;
            const double ETHA_DES_MAJOR = 0.06;
            const double FUEL_LIMIT = 20;
            const int GAS = 1, ETHA = 2;

            Console.WriteLine("What type of fuel do you want to fill up with? \n 1 - Gasoline \n 2 - Ethanol");
            int fuel = int.Parse (Console.ReadLine());
            
            Console.WriteLine("How many liters do you want to fill up?");
            double liters = double.Parse(Console.ReadLine());

            if( fuel == GAS)
            {   
                if (liters <= FUEL_LIMIT)
                {
                    double total = liters * GAS_PRICE;
                    double discount = total * GAS_DES_MINOR;
                    double finalPrice = total - discount;

                    Console.WriteLine($"The final price is: ${finalPrice}");
                }
                else
                {
                    double total = liters * GAS_PRICE;
                    double discount = total * GAS_DES_MAJOR;
                    double finalPrice = total - discount;

                    Console.WriteLine($"The final price is: ${finalPrice}");
                }
            }
            else if( fuel == ETHA)
            {
                if (liters <= FUEL_LIMIT)
                {
                    double total = liters * ETHA_PRICE;
                    double discount = total * ETHA_DES_MINOR;
                    double finalPrice = total - discount;

                    Console.WriteLine($"The final price is: ${finalPrice}");
                }
                else
                {
                    double total = liters * ETHA_PRICE;
                    double discount = total * ETHA_DES_MAJOR;
                    double finalPrice = total - discount;

                    Console.WriteLine($"The final price is: ${finalPrice}");
                }
            }
            else
            {
                Console.WriteLine("Invalid option!");
            }
            Console.WriteLine("Press ENTER to exit.");
            Console.ReadKey();
        }
    }
}

