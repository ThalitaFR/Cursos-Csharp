using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {

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

            // Testando o método remove
            string testeRemocao = "primeiraParte&parteParaRemover"; ;
            int indiceEComercial = testeRemocao.IndexOf('&');
            Console.WriteLine(testeRemocao.Remove(indiceEComercial, 4));
            Console.ReadLine();
            
            // <nome>=<valor>
            string palavra = "moedaOrigem=moedaDestino&moedaDestino=dolar";
            string nomeArgumento = "moedaDestino=";
            // o IndexOf sempre vai considerar a primeira ocorrência do argumento.
            int indice = palavra.IndexOf(nomeArgumento);
            
            Console.WriteLine(indice);
            Console.WriteLine("Tamanho da String:" + nomeArgumento.Length);
            Console.WriteLine(palavra.Substring(indice)) ;
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
