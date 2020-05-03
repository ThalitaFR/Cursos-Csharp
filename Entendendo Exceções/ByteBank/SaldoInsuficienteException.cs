using ByteBank;
using System;

public class SaldoInsuficienteException : OperacaoFinanceiraException
{
   // Uma boa pratica para exceções é seguir as declarações da classe base.
    public double Saldo { get; }
    public double ValorSaque { get; }

    //É uma convenção no .NET a criação do construtor sem argumentos para os tipos de exceções.
    public SaldoInsuficienteException()
    {
    }

    public SaldoInsuficienteException(double saldo, double valorSaque)
        : this("Tentativa de saque no valor de " + valorSaque + " em uma conta com saldo de " + saldo)
    {
        Saldo = saldo;
        ValorSaque = valorSaque;
    }

    // Usando um construtor com parâmetro de mensagem, é possível definir uma mensagem para a exceção.
    public SaldoInsuficienteException(string mensagem)
        : base(mensagem)
    {

    }

    public SaldoInsuficienteException (string mensagem, Exception excecaoInterna): base (mensagem,excecaoInterna)
    {

    }
}