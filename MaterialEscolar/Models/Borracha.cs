namespace Models
{
    public class Borracha
    {
        private string marca;
        private string cor;
        private double comprimento;
        private double largura;
        private double altura;
        private double peso;
        private bool caida;
        private int percentual;

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }
        public double Comprimento
        {
            get { return comprimento; }
            set { comprimento = value; }
        }
        public double Largura
        {
            get { return largura; }
            set { largura = value; }
        }
        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }
        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        public bool Caida
        {
            get { return caida; }
            set { caida = value; }
        }
        public int Percentual
        {
            get { return percentual; }
            set { percentual = value; }
        }
        public void Derrubar()
        {
            caida = true;
        }
        public void PegarDoChao()
        {
            caida = false;
        }
        public void Apagar(int Palavras)
        {
            if(caida == true)
            {
                Console.WriteLine("Pegue a borracha do chão primeiro");
                return;
            }
            if(Palavras <= 10)
            {
                Percentual -= 5;
            }
            if(Palavras > 10)
            {
                Percentual -= 10;
            }

        }
        public Borracha(string _marca, string _cor, double _comprimento, double _largura, double _altura, double _peso)
        {
            Marca = _marca;
            Cor = _cor;
            Comprimento = _comprimento;
            Largura = _largura;
            Altura = _altura;
            Peso = _peso;
            Caida = false;
            Percentual = 100;
        }
    }
}
