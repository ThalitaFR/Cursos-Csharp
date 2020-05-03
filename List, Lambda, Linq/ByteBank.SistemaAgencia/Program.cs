using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using ByteBank.SistemaAgencia.Comparadores;
using ByteBank.SistemaAgencia.Extensoes;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(142,85),
                new ContaCorrente(242,86),
                null,
                new ContaCorrente(443,8236),
                new ContaCorrente(242,1),
                new ContaCorrente(343,7236),
            };

            var contasNaoNulas = contas
                .Where(conta => conta != null)
                .OrderBy(conta=> conta.Numero);
            

            //IOrderedEnumerable<ContaCorrente> contasOrdenadas =
            //    contasNaoNulas.OrderBy(conta =>
            //    {
            //        if (conta == null)
            //        {
            //            return int.MaxValue;
            //        }

            //        return conta.Numero;
            //    });
                    
            //contas.Sort(new ComparardorContaCorrentePorAgencia());

            foreach (var conta in contasNaoNulas)
            {
                if (conta != null)
                {
                    Console.WriteLine($"Conta Número: {conta.Numero} e Agência {conta.Agencia}");
                }            
            }

            Console.ReadLine();
        }

        static void TestaSort()
        {
            var nomes = new List<string>()
            {
                "Thalita", "Tabata", "Thaisa", "Amanda"
            };
            nomes.Sort();
            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }

            Console.ReadLine();

            var idades = new List<int>();

            idades.Add(1);
            idades.Add(5);
            idades.Add(14);
            idades.Add(25);
            idades.Add(38);
            idades.Add(61);

            idades.AdicionarVarios(7, 8, 64);

            idades.AdicionarVarios(99, -1);

            idades.Sort();

            for (int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
            }
        }

        static void testaListaDeObject()
        {
            ListaDeObject listaDeIdades = new ListaDeObject();
            listaDeIdades.Adicionar(5);
            listaDeIdades.Adicionar(10);
            listaDeIdades.Adicionar(4);
            listaDeIdades.AdicionarVarios(16, 23, 60);

            for (int i = 0; i < listaDeIdades.Tamanho; i++)
            {
                int idade = (int)listaDeIdades[i];
                Console.WriteLine($"Idade no indice {i}: {idade}");
            }

            Console.ReadLine();
        }

        static int SomarVarios(params int[] numeros)
        {
            int acummulador = 0;
            foreach (int numero in numeros)
            {
                acummulador += numero;
            }
            return acummulador;
        }

        static void TestaArray()
        {
            ContaCorrente[] contas = new ContaCorrente[]
  {
                new ContaCorrente(154, 87456),
                new ContaCorrente(451, 45448),
                new ContaCorrente(781, 45785)
  };

            for (int indice = 0; indice < contas.Length; indice++)
            {
                ContaCorrente contaAtual = contas[indice];
                Console.WriteLine($"Conta {indice} {contaAtual.Numero}");
            }


            Console.ReadLine();
        }

        static void TestaArrayInt()
        {
            // Array de inteiros com cinco posições
            int[] idades = new int[3];

            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            //idades[3] = 50;
            //idades[4] = 28;
            //idades[5] = 60;

            Console.WriteLine(idades.Length);

            int acumulador = 0;
            for (int indice = 0; indice < idades.Length; indice++)
            {
                int idade = idades[indice];
                Console.WriteLine($"Acessando o Array Idades no Indice: {indice}");
                Console.WriteLine($"Valor de Idades[{indice}] = {idade}");

                acumulador += idade;
            }

            int media = acumulador / idades.Length;
            Console.WriteLine($"Média de idades= {media}");
        }
    }
}
