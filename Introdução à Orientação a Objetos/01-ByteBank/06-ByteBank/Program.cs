﻿using System;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();
            
            cliente.Nome = "Guilherme";
            cliente.Cpf = "434.564.879-20";
            cliente.Profissao = "Desenvolvedor";
            
            conta.Titular = cliente;
            conta.Saldo = -10;

            Console.WriteLine(conta.Saldo);
            Console.WriteLine(conta.Titular.Nome);

            Console.ReadLine();
        }
    }
}
