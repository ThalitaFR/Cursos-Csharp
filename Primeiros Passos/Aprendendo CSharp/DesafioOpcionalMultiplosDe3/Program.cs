using System;

namespace DesafioOpcionalMultiplosDe3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Desafio Opcional Multiplos de 3");

            for (int numero= 1; numero<=100 ;numero++)
            {
                if(numero%3==0)
                {
                    Console.WriteLine(numero);
                }
            }
                Console.ReadLine();
        }
    }
}
