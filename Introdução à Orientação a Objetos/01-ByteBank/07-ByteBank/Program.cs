using System;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ContaCorrente.totalDeContasCriadas);

            ContaCorrente conta = new ContaCorrente(867,8675428);
            Console.WriteLine(ContaCorrente.totalDeContasCriadas);

            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            ContaCorrente contaDaGabriela = new ContaCorrente(867, 86745820);
            Console.WriteLine(ContaCorrente.totalDeContasCriadas);

            Console.ReadLine();
        }
    }
}
