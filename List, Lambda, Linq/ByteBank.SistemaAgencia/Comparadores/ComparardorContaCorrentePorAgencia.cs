using ByteBank.Modelos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia.Comparadores
{
    public class ComparardorContaCorrentePorAgencia : IComparer<ContaCorrente>
    {
        public int Compare(ContaCorrente x, ContaCorrente y)
        {

            if (x == y)
            {
                return 0;
            }
            if (x == null)
            {
                return 1;
            }
            if (y == null)
            {
                return -1;
            }

            return x.Agencia.CompareTo(y.Agencia);

            //if(x.Agencia < y.Agencia)
            //{
            //    return -1; // x fica na frente de y
            //}

            //if(x.Agencia == y.Agencia)
            //{
            //    return 0; // São equivalentes
            //}

            //return 1; //Y fica na frente de X
            // Essa comparação ja é equivalente ao que está implementado na interface IComparer do tipo Int no .NET
        }
    }
}
