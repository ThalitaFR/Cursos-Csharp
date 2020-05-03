using System;
using System.IO;

public class LeitorDeArquivo:IDisposable
{
    public string Arquivo { get; }

    public LeitorDeArquivo(string arquivo)
    {
        Arquivo = arquivo;

       //throw new FileNotFoundException();

        Console.WriteLine("Abrindo arquivo: " + arquivo);
    }

    public string LerProximaLinha()
    {
        Console.WriteLine("Lendo linha...");

       // Exceção de entrada ou saída.
       throw new IOException();

        return "Linha do arquivo";
    }

    // O dispose é responsavel por liberar recursos em um contexto com using
    public void Dispose()
    {
        Console.WriteLine("Fechando arquivo.");

    }
}