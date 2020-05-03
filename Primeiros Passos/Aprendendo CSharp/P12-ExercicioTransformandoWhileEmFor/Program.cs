using System;

namespace P12_ExercicioTransformandoWhileEmFor
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int contador = 1;
            while (contador <= 10)
            {
                Console.WriteLine(contador);
                contador++;
            }*/

            Console.WriteLine("Executando Exercicio para transforma While em um for");
                
            for(int contador =1; contador <=10; contador++)
            {
                Console.WriteLine(contador);
            }

            Console.ReadLine();
        }
    }
}
