using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    // O funcionário é uma abstração de um conceito, não faz sentido instancia-lo diretamente.
    abstract public class Funcionario
    {

        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        // protected permited acesso da classe e tipos derivados.
        public double Salario { get; protected set; }

        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando Funcionário");
            TotalDeFuncionarios++;
            CPF = cpf;
            Salario = salario;
        }
        
        public abstract void AumentarSalario();

        // metodo virtual permite sobreescrita da implementação em outras classes
        // Abstract substitui o virtual e torna o método abstrato, sendo usado apenas em classes filhas para definir seus atributos.
        public abstract double GetBonificacao();

    }
}
