using Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Carro corcel = new Carro("Chevrolet", "2");
        corcel.LigarDesligar();
        corcel.Acelerar(5);
        corcel.Abastecer(500);
        corcel.Frear(30);

        for (int i = 1; i < 15 ; i++)
        {
            corcel.Acelerar(50);
            corcel.Frear(30);
        }
        corcel.Exibir(); 

    }
}