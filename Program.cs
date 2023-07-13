using Microsoft.VisualBasic;
using Newtonsoft.Json;
using Tuplas.Models;


    LeituraArquivo arquivoLer = new LeituraArquivo();

    var (Sucesso, linhas, QuantidadeLinhas) = arquivoLer.LerArquivo("ArquivoTexto/Leitura.txt");

    if (Sucesso)
    {
        Console.WriteLine("Foi possível ler o arquivo: ");
        foreach (string linha in linhas)
        {
            Console.WriteLine(linha);
        }
    }
    else
    {
        Console.WriteLine("Erro: Não foi possível ler o arquivo");
    }

    Console.WriteLine("-------------------");

    string json = JsonConvert.SerializeObject(arquivoLer);
    Console.WriteLine(json);
    File.WriteAllText("ArquivoTexto/chazon.json", json);


// Use o "_" para descartar uma variável.