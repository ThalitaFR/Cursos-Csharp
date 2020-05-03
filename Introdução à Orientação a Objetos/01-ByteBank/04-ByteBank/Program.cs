using System;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = "Bruno";

            Console.WriteLine("Saldo da Conta: " + contaDoBruno.saldo);

            // contaDoBruno.Sacar(50);
            bool resultadoSaque = contaDoBruno.Sacar(500);
            Console.WriteLine("Saldo da Conta Após saque: " + contaDoBruno.saldo);
            Console.WriteLine("Sucesso ao Realizar o saque: "+ resultadoSaque);

            contaDoBruno.Depositar(500);

            Console.WriteLine("Novo Saldo após deposito: " + contaDoBruno.saldo);

            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";

            bool resultadoTransferencia = contaDoBruno.Transferir(2000,contaDaGabriela);

            Console.WriteLine("Saldo do Bruno após transferência: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo Gabriela: " + contaDaGabriela.saldo);
            Console.WriteLine("Sucesso na Transferência do Valor: " + resultadoTransferencia);

            contaDaGabriela.Transferir(100, contaDoBruno);

            Console.WriteLine("Saldo da Gabriela após transferência: " + contaDaGabriela.saldo);
            Console.WriteLine("Saldo Bruno: " + contaDoBruno.saldo);

            Console.ReadLine();
        }
    }
}
