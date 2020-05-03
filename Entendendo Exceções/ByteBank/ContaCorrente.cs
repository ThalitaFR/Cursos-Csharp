// using _05_ByteBank;

using System;

namespace ByteBank
{
    public class ContaCorrente
    {
        public static double TaxaOperacao { get; private set; }

        public Cliente Titular { get; set; }

        public static int TotalDeContasCriadas { get; private set; }

        public int ContadorSaquesNaoPermitidos { get; private set; }
        public int ContadorTransferenciasNaoPermitidas { get; private set; }

        // private int _agencia;
        public int Agencia { get; }

        // private readonly int _numero;
        // Um getter declarado dessa maneira define um campo como readonly, ou seja, não é possível alterar o valor da propriedade em si. 
        public int Numero { get; }

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

        public ContaCorrente(int numero, int agencia)
        {
            if (numero <= 0)
            {
                // Name of transforma em uma string numeroAgencia, e faz com que seja sempre a string correta do argumentException
                throw new ArgumentException("O Argumento agência deve ser maior que 0.", nameof(numero));
            }
            if (agencia <= 0)
            {
                throw new ArgumentException("O Argumento número deve ser maior que 0.", nameof(agencia));
            }

            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;
        }

        public void Sacar(double valor)
        {
            if (valor < 0)
            {
                // usado nameof para forçar a troca do nome do argumento caso "valor" for alterado no método.
                throw new ArgumentException("Valor Invalido para o Saque ", nameof(valor));
            }
            if (_saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(Saldo, valor);
            }

            _saldo -= valor;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                // usado nameof para forçar a troca do nome do argumento caso "valor" for alterado no método.
                throw new ArgumentException("Valor Invalido para a transferência ", nameof(valor));
            }
            try
            {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException e)
            {
                ContadorTransferenciasNaoPermitidas++;
                // Lançando a exceção em um objeto a maquina virtual troca o stackTrace e volta direto para o Main.
                // O throw no contexto do Catch pode ser vazio e irá deixar o stackTrace sem alterações
                // Uma forma de guardar os dados sigilosos de uma exceção é lançar uma nova exception com construtor de mensagem e o objeto referente à exceção que originou o erro.
                throw new OperacaoFinanceiraException("Operação não realizada", e); 
            }
            contaDestino.Depositar(valor);
        }
    }
}
