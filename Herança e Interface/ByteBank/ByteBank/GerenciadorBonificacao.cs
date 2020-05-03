using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank
{
    public class GerenciadorBonificacao
    {
        private double _totalBonificacao; 
        public void Registrar(FuncionarioAutenticavel funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }

        // Quando dois metodos tem o mesmo nome o tipo do argumento precisa ser diferente.
        // Sobrecarga do método Registrar.
        public void Registrar (Diretor diretor)
        {
            _totalBonificacao += diretor.GetBonificacao();
        }

        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }
    }
}
