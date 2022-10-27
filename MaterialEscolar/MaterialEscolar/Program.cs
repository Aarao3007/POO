using Models;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Caneta caneta = new Caneta("Azul", "Bic","Plástico",1, "Esferográfica", 14, 20);
        caneta.Destampar();
        caneta.Escrever("Teste");

        Lapis lapis = new Lapis("2B","Faber Castell", "Madeira", "Cinza", "Triangular", 14, 20);
        Console.WriteLine(lapis.PercentualGrafite);
        lapis.QuebrarPonta();
        Console.WriteLine(lapis.PercentualGrafite);
        lapis.Apontar();
        lapis.Escrever("Teste");
        Console.WriteLine(lapis.PercentualGrafite);

        Borracha borracha = new Borracha("Mercur", "Branca", 5, 5, 1, 70);
        Console.WriteLine(borracha.Percentual);
        borracha.Apagar(7);
        Console.WriteLine(borracha.Percentual);
        borracha.Apagar(11);
        Console.WriteLine(borracha.Percentual);

        Apontador apontador = new Apontador("Maped", "Verde", 30, 125, 90, 18.6, true);
        Console.WriteLine(apontador.PercentualDaLamina);
        Console.WriteLine(apontador.Cheio);
        apontador.Apontar();
        Console.WriteLine(apontador.PercentualDaLamina);
        Console.WriteLine(apontador.Cheio);

    }
}