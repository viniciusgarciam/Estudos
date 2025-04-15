using System;

namespace MeuProjetoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo a Calculadora");

            Console.Write("Digite um número: ");
            int nun1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número: ");
            int nun2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Soma: " + (nun1 + nun2));
            Console.WriteLine("Subtração: " + (nun1 - nun2));
            Console.WriteLine("Multiplicação: " + (nun1 * nun2));
            Console.WriteLine("Divisão: " + (nun1 / nun2));
            Console.WriteLine("Resto da divisão: " + (nun1 % nun2));
        
            Console.WriteLine("Pressione ENTER para sair.");
            Console.ReadKey();
        }
    }
}
