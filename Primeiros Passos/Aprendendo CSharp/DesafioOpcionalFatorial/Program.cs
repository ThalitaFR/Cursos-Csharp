using System;

namespace DesafioOpcionalFatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Desafio Opcional Fatorial");

            int fatorial = 1;
            for (int i = 1; i < 11; i++)
            {
                fatorial *= i;  // essa parte poderia ser escrita da mesma forma como fatorial=fatorial*i ou seja toda vez que passar por essa parte vai multiplicar o fatorial anterior pelo número i atual.
                Console.WriteLine("Fatorial de " + i + " = " + fatorial);
            }

            Console.ReadLine();
        }
    }
}
