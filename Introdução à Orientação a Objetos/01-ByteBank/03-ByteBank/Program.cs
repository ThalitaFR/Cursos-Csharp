using System;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;

            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
            contaDaGabrielaCosta.titular = "Gabriela";
            contaDaGabrielaCosta.agencia = 863;
            contaDaGabrielaCosta.numero = 863452;

            Console.WriteLine("Igualdade de tipo de referência: " + (contaDaGabriela == contaDaGabrielaCosta));

            int idade = 27;
            int idade2 = 27;

            Console.WriteLine("Igualdade de Tipo de Valor: " + (idade == idade2));

            // Apagando a referência de contaDaGabriela e atribuindo ela à mesma referência que contaGabrielaCosta.
            contaDaGabriela = contaDaGabrielaCosta;

            // Agora os dois objetos instanciados estão no mesmo endereço da memória e seus valores comparados retornam True.
            Console.WriteLine(contaDaGabriela == contaDaGabrielaCosta);

            // Como estão apontando para o mesmo objeto da memória, ao atribuir o saldo = 300 para contaDaGabriela, a contaDaGabrielaCosta também recebe o valor.
            contaDaGabriela.saldo = 300;
            Console.WriteLine(contaDaGabriela.saldo);
            Console.WriteLine(contaDaGabrielaCosta.saldo);

    }
}
