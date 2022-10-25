internal class Program
{
    private static void Main(string[] args)
    {
        Models.Caneta caneta = new Models.Caneta("Azul", "Bic","Plástico",1, "Esferográfica", 14, 20);
        caneta.Destampar();
        caneta.Estourar();
        caneta.Escrever("Teste");
    }
}