using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá Mundo!");
            Console.WriteLine(123);
            Console.WriteLine(10.5);
            Console.WriteLine(true);

            object conta = new ContaCorrente(478, 285);

            string contaToString = conta.ToString();

            Console.WriteLine(contaToString);
            Console.WriteLine(conta);

            Cliente carlos_1 = new Cliente();
            carlos_1.Nome = "Carlos";
            carlos_1.CPF = "458.623.120-03";
            carlos_1.Profissao = "Designer";

            Cliente carlos_2 = new Cliente();
            carlos_2.Nome = "Carlos";
            carlos_2.CPF = "458.623.120-03";
            carlos_2.Profissao = "Designer";

            if (carlos_1.Equals(carlos_2))
            {
                Console.WriteLine("São iguais!");
            }
            else
            {
                Console.WriteLine("Não São Iguais");
            }

            Console.ReadLine();
        }

        static void TestaString()
        {
            // Me ligue em 7894-4654
            // Meu número de telefone é 7894-4654
            // O numero 7894-4654 é para contato profissional

            // string padrao = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]"
            // string padrao = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
            // Usando quantificador na string {4} significa que será um digito de 0-9 4x, {4,5} significa 4 até 5..
            // string padrao = "[0-9]{4,5}[-][0-9]{4}";
            // Usando {0,1} após [1] significa que 0 ou 1 digito pode ser "-", não dando mais erro se o numero digitado não tiver "-'
            // string padrao = "[0-9]{4,5}[-]{0,1}[0-9]{4}";
            // O [-] não precisa ter colchetes pois é um unico caractere, não um grupo.
            // string padrao = "[0-9]{4,5}-{0,1}[0-9]{4}";

            // O ? é o quantificador para 0 até 1.
            string padrao = "[0-9]{4,5}-?[0-9]{4}";
            string textoDeTeste = "Meu número de telefone é 78944654";
            Match resultado = Regex.Match(textoDeTeste, padrao);

            Console.WriteLine(resultado.Value);

            Console.ReadLine();
            //
            string urlTeste = "https://www.bytebank.com/cambio";
            int indiceByteBank = urlTeste.IndexOf("https://www.bytebank.com/cambio");
            Console.WriteLine(urlTeste.StartsWith("https://www.bytebank.com"));
            Console.WriteLine(urlTeste.EndsWith("cambio"));

            Console.WriteLine(urlTeste.Contains("bytebank"));

            Console.ReadLine();
            //
            // ctrl k + c
            // shift + alt seleção
            string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParametros);

            string valorMoedaOrigem = extratorDeValores.GetValor("moedaOrigem");
            Console.WriteLine("Tipo de moedaOrigem: " + valorMoedaOrigem);
            string valor = extratorDeValores.GetValor("moedaDestino");
            Console.WriteLine("Tipo de moedaDestino: " + valor);
            Console.WriteLine(extratorDeValores.GetValor("VALOR"));

            Console.ReadLine();
            //
            // Testando o método remove
            string testeRemocao = "primeiraParte&parteParaRemover"; ;
            int indiceEComercial = testeRemocao.IndexOf('&');
            Console.WriteLine(testeRemocao.Remove(indiceEComercial, 4));
            Console.ReadLine();
            //
            // <nome>=<valor>
            string palavra = "moedaOrigem=moedaDestino&moedaDestino=dolar";
            string nomeArgumento = "moedaDestino=";
            // o IndexOf sempre vai considerar a primeira ocorrência do argumento.
            int indice = palavra.IndexOf(nomeArgumento);

            Console.WriteLine(indice);
            Console.WriteLine("Tamanho da String:" + nomeArgumento.Length);
            Console.WriteLine(palavra.Substring(indice));
            Console.WriteLine(palavra.Substring(indice + nomeArgumento.Length));

            // Testando IsNullOrEmpty
            string textoVazio = "";
            string textoNulo = null;
            Console.WriteLine(string.IsNullOrEmpty(textoVazio));
            Console.WriteLine(string.IsNullOrEmpty(textoNulo));

            Console.ReadLine();
        }
    }
}

