using System;
using System.IO;
using System.Text;

namespace ByteBankImportacaoExportacao
{ 
    // O partial indica que a classe está em varios arquivos separados mas ao final todos serão unicos para a execução
    partial class Program
    {
        static void LidandoComFileStreamDiretamente()
        {
            var enderecoDoArquivo = "contas.txt";

            // Using implementa try catch e chama a interface dispose que implementa o método Close no fluxo de dados.
            using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            {
                var buffer = new byte[1024]; //1 kb 

                var numeroDeBytesLidos = -1;

                while (numeroDeBytesLidos != 0)
                {
                    numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                    Console.WriteLine($"Bytes lidos: {numeroDeBytesLidos}");
                    EscreverBufferNaTela(buffer, numeroDeBytesLidos);
                }

                // Qualquer fluxo de dados(stream) precisa ser encerrado pelo metodo Close, a não ser que seja manipulado dentro de um metodo using.
                // fluxoDoArquivo.Close();
            }
        }

        static void EscreverBufferNaTela(byte[] buffer, int bytesLidos)
        {
            var utf8 = Encoding.Default;
            var texto = utf8.GetString(buffer, 0, bytesLidos);

            Console.Write(texto);

            //foreach(var meuByte in buffer)
            //{
            //    Console.Write(meuByte);
            //    Console.Write(" ");
            //}
        }
    }
}