using System;

namespace MeuProjetoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao programa Antecessor e Sucessor!");

            #region Entrada de dados
                
            Console.Write("Valor que o João deu: ");
            double Amigo1 = double.Parse(Console.ReadLine());

            Console.Write("Valor que o Vitor deu: ");
            double Amigo2 = double.Parse(Console.ReadLine());

            Console.Write("Valor que o Matteo deu: ");
            double Amigo3 = double.Parse(Console.ReadLine());

            Console.Write("Valor que o Matteo deu: ");
            double Premio = double.Parse(Console.ReadLine());
            #endregion

            #region Processamento
            double Total = Amigo1 + Amigo2 + Amigo3;
            double Premioamigo1 = Amigo1 / Total * Premio;
            double Premioamigo2 = Amigo2 / Total * Premio;
            double Premioamigo3 = Amigo3 / Total * Premio;
        
            #endregion

            #region Saída de dados

            Console.WriteLine($"Amigo1:  {Premioamigo1 : 0.00}");
            Console.WriteLine($"Amigo2:  {Premioamigo2 : 0.00}");
            Console.WriteLine($"Amigo3:  {Premioamigo3 : 0.00}");
            #endregion

            Console.WriteLine("Pressione ENTER para sair.");
            Console.ReadKey();
        }
    }
}
