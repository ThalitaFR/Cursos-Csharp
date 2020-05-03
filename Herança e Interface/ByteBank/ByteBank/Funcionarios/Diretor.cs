using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {

        public Diretor(string cpf) : base(5000, cpf)
        {
            Console.WriteLine("Criando Diretor");
        }

        // GetBonificacao sobreescrevendo o comportamento de funcionario para o metodo virtual
        public override double GetBonificacao()
        {
            // É necessário chamar o getBonificacao da classe base (funcionario) para não gerar um stack overflow
            return Salario *= 0.5;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
    }
}
