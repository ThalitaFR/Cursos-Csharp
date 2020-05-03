using ByteBank.Modelos;
using System;

namespace ByteBank.SistemaInterno
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(784,5841);
            Console.WriteLine(conta.Saldo);

            conta.Sacar(-10);
            string nome = "Guilherme";

            Console.ReadLine();
        }
    }
}
