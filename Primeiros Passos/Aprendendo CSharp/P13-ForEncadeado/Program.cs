using System;

namespace P13_ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 13");

            //*
            //**
            //***
            //****
            //*****
            //******
            //*******
            //********

            // Esrevendo asteriscos com o Break.
            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                Console.WriteLine();
                for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
                {
                    Console.Write("*");
                    if(contadorColuna>=contadorLinha)
                    {
                        break;
                    }
                }
                Console.WriteLine();
            }

            // Uma forma diferente de fazer o desenho
            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                Console.WriteLine();
               // Da para tirar as chaves do for porquê ele só tem uma instrução
                for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
                
                    Console.Write("*");                  
                
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
