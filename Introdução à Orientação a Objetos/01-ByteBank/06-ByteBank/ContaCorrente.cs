// using _05_ByteBank;

namespace _06_ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        
        /* Substitui:
         private Cliente _titular;

        public Cliente Titular
        {
            get
            {
                return _titular;
            }
            set
            {
                _titular = value;
            }
        }*/
      
        public int Agencia { get; set; }      
        public int Numero { get; set; }
        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value;
            } 
        }


        /* encapsulamento do saldo
        public void SetSaldo(double saldo)
        {
            if (saldo < 0)
            {
                // return sem nada para de executar o método imediatamente.
                return;
            }


            this.saldo = saldo;

        }

        public double GetSaldo()
        {
            return saldo;
        }*/

        // Função sempre em maiúsculo usando verbos para a ação que ela representa.
        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }
            // É possível retirar o else pois o return volta retorna o que o usuário pediu e volta para o método principa ou seja, só vai executar as linhas de baixo se a execução não entrar no If.
            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;


        }
    }
}
