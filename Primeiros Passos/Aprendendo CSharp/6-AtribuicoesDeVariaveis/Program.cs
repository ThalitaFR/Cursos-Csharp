using System;

namespace _6_AtribuicoesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 6..");

            int idade = 32;
            int gustavoIdade = idade;

            idade = 20;

            Console.WriteLine(idade);
            Console.WriteLine(gustavoIdade);

            Console.ReadLine();
        }
    }
}
