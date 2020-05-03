using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Sistemas
{
    // A interface possui todos os atributos publicos e soluciona o problema de não existir herança múltipla no c#
    public interface IAutenticavel
    {
        bool Autenticar(string senha);
    }
}
