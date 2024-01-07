using System;

class Program
{
    static void Main()
    {
        string nome = Console.ReadLine();
        double quilometrosPorDia = double.Parse(Console.ReadLine());
        int horasDeEletronicos = int.Parse(Console.ReadLine());
        int refeicoesComCarne = int.Parse(Console.ReadLine());

        double pegadaDeCarbono = CalcularPegadaDeCarbono(quilometrosPorDia, horasDeEletronicos, refeicoesComCarne);

        Console.WriteLine($"{nome}, sua pegada de carbono e de {pegadaDeCarbono} toneladas de CO2 por ano.");

        Console.ReadLine();
    }
    static double CalcularPegadaDeCarbono(double quilometrosPorDia, int horasDeEletronicos, int refeicoesComCarne)
    {
        double transporte = quilometrosPorDia * 365 * 0.2;
        double eletrônicos = horasDeEletronicos * 0.1;
        double consumoCarne = refeicoesComCarne * 0.5;

        double total = transporte + eletrônicos + consumoCarne;
        return total;
    }

}