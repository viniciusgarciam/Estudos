using System;

namespace MeuProjetoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao programa Antecessor e Sucessor!");

            Console.Write("Digite um número: ");
            int nun = int.Parse(Console.ReadLine());

            Console.WriteLine("Antecessor: " + (nun - 1));
            Console.WriteLine("Sucessor: " + (nun + 1));
            
            Console.WriteLine("Pressione ENTER para sair.");
            Console.ReadKey();
        }
    }
}
