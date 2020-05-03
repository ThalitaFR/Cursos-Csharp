﻿
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    class Auxiliar:FuncionarioAutenticavel
    {
        public Auxiliar (string cpf) : base(2000, cpf)
        {

        }
        public override void AumentarSalario()
        {
            Salario *= 1.1;
        }
        public override double GetBonificacao()
        {
            return Salario * 0.2;
        }
    }
}
