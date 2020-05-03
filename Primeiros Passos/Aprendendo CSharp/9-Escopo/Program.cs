using System;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 9 - Escopo");

            int idadeJoao = 18;    
            bool acompanhado = true;

            string mensagemAdicional;


            if (acompanhado)
            {
                mensagemAdicional = "João Está Acompanhado";

            }
            else
            {
                mensagemAdicional = "João não está acompanhado";
                Console.WriteLine(mensagemAdicional);
            }

            if (idadeJoao >= 18 || acompanhado)
            {
                Console.WriteLine("João pode entrar.");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {

                Console.WriteLine("João não pode entrar.");

            }

            Console.ReadLine();
        }
    }
}
