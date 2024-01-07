using System;

class Program
{
    static void Main()
    {
        int quantidadeJogos = int.Parse(Console.ReadLine());

        string[]nomesJogos = new string[quantidadeJogos]; 

        for (int indice = 0; indice < quantidadeJogos; indice++) {
            
            AdicionarJogo(indice, nomesJogos);
        }       

        ExibirResumoAdicaoJogos(quantidadeJogos, nomesJogos);
    }

    static void AdicionarJogo(int indice, string[] nomes)
    {
        nomes[indice] = Console.ReadLine();
    }

    static void ExibirResumoAdicaoJogos(int quantidadeJogos, string[] nomes)
    {
        string nomesConcatenados = string.Join(", ", nomes);

        Console.WriteLine($"Foi adicionado '{quantidadeJogos}' jogos: {nomesConcatenados} ao catalogo.");
        
    }
}