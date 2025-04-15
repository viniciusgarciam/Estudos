using System;

namespace MeuProjetoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao Programa Senha!");

            Console.Write("Digite a sua senha: ");
            string senha = Console.ReadLine();

            if(senha == "123456")
            {
                Console.WriteLine("Senha correta!");
                Console.WriteLine("Acesso permitido.");
            }
            else
            {
                Console.WriteLine("Senha incorreta!");
                Console.WriteLine("Acesso negado.");
            }
            Console.ReadKey();
        }
    }
}