using System;
using System.IO;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CarregarContas();
            }
            catch
            {
                Console.WriteLine("Catch no método main");
            }

            Console.ReadLine();
        }
        private static void CarregarContas()
        {
            using(LeitorDeArquivo leitor = new LeitorDeArquivo("teste.txt"))
            {
                leitor.LerProximaLinha();
            }
            

            //-----------------------------------------------------------------------------
            //LeitorDeArquivo leitor = null;

            //// O try pode ter só catch ou só finally e também os dois.
            //try
            //{
            //    leitor =  new LeitorDeArquivo("contasl.txt");

            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();

            //}
            //catch (IOException)
            //{
            //    Console.WriteLine("Exceção do tipo IOException Capturada e Tratada");
            //}
            //// Finally executa acontecendo ou nao uma exceção.
            //finally
            //{
            //    Console.WriteLine("Executando o Finally");
            //    if(leitor != null)
            //    {
            //        leitor.Fechar();
            //    }
                
            //}
        }

        private static void TestaInnerException()
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(544, 5465);
                ContaCorrente conta2 = new ContaCorrente(471, 8554);

                //conta1.Transferir(10000, conta2);
                conta1.Sacar(1000);
            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                // Informações sigilosas agora podem ser acessadas apenas pela propriedade Inner Exception
                //Console.WriteLine("Informações da INNER Exception (exceção interna): ");
                //Console.WriteLine(e.InnerException.Message);
                //Console.WriteLine(e.InnerException.StackTrace);
            }
        }

        // Teste com a cadeia de chamada:
        // Metodo -> TestaDivisao -> Dividir
        private static void Metodo()
        {
            TestaDivisao(2);
        }

        private static void TestaDivisao(int divisor)
        {

            int resultado = Dividir(10, divisor);
            Console.WriteLine("Resultado da divisão de 10 por" + divisor + " é:" + resultado);

        }

        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch
            {
                Console.WriteLine("Exceção com numero igual " + numero + " e divisor igual a " + divisor);
                // Throw é usado para lançar a exceção que o bloco está tratando para o próximo método da pilha, tirando o erro da falta de retorno no método.
                throw;
                // O throw sai do método, nunca irá executar o código a seguir.
                Console.WriteLine("Codigo depois do throw");
            }
        }
    }
}
