using System;
using System.Collections.Generic;
using System.Text;

namespace _9_Escopo
{
    class ExercicioAliquota
    {
        static void Main(string[] args)
        {
            // De 1900.0 até 2800.0 o IR é de 7.5% e pode deduzir R$ 142
            // De 2800.01 até 3751.0 o IR é de 15% e pode deduzir R$ 350
            // De 3751.01 até 4664.00 o IR é de 22.5% e pode deduzir R$ 636
            double salario = 3300.0;

            if (salario >= 1900.00 && salario <= 2800.00)
            {
                Console.WriteLine("Seu IR é de 7.5%");
                Console.WriteLine("Você pode deduzir 142,00");
            }
            else if (salario >= 2800.01 && salario <= 3751.0)
            {
                Console.WriteLine("Seu IR é de 15%");
                Console.WriteLine("Voce pode deduzir 350,00");
            }
            else if (salario >= 3751.01 && salario <= 4664.00)
            {
                Console.WriteLine("Seu IR é 22.5%");
                Console.WriteLine("Voce pode deduzir 636,00");
            }
        }


    }
}