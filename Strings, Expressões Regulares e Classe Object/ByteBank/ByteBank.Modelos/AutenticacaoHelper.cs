using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    // Classes sem modificadores de acesso são internal e isso define que apenas o projeto de onde ela deriva (byteBank.Modelos no caso) pode ter acesso as definições dessa classe.
     class AutenticacaoHelper
    {
        public bool CompararSenhas(string senhaVerdadeira, string senhaTentativa)
        {
            return senhaVerdadeira == senhaTentativa;        }
    }
}
