using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista<int> idades = new Lista<int>();
            idades.Adicionar(85);
            idades.AdicionarVarios(78,58,31);



            int idadeSoma = 0;
            
            for(int i= 0; i < idades.Tamanho; i++)
            {
                int idadeAtual = idades[i];
            }

            Console.WriteLine(somarVarios(1, 2, 3, 4, 5, 8, 7));
            Console.WriteLine(somarVarios(1, 2, 8, 7));

            Console.ReadLine();

            ContaCorrente contaDaThalita = new ContaCorrente(11111, 1111111);


            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            ContaCorrente[] contas = new ContaCorrente[]
            {
                contaDaThalita,
                new ContaCorrente(451, 258741),
                new ContaCorrente(258, 354713),
                new ContaCorrente(346, 454528)
            };

            lista.AdicionarVarios(
                    contaDaThalita,
                    new ContaCorrente(874, 5679787),
                    new ContaCorrente(874, 5679754));



            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista.getItemNoIndice(i);
                Console.WriteLine($"Item na posição {i} = Conta {itemAtual.Numero}/{itemAtual.Agencia}");
            }

            Console.ReadLine();
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

        static int somarVarios(params int[] numeros)
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
