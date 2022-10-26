namespace Models
{
    public class Lapis
    {
        private string dureza;
        private bool apontado;
        private bool caido;
        private int percentualGrafite;
        private string material;
        private string marca;
        private string cor;
        private string formato;
        private double tamanho;
        private double peso;


        public string Dureza
        {
            get { return dureza; }
            set { dureza = value; }
        }
        public bool Apontado
        {
            get { return apontado; }
            set { apontado = value; }
        }
        public bool Caido
        {
            get { return caido; }
            set { caido = value; }
        }
        public int PercentualGrafite
        {
            get { return percentualGrafite; }
            set { percentualGrafite = value; }
        }
        public string Material
        {
            get { return material; }
            set { material = value; }
        }
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
        public string Formato
        {
            get { return formato; }
            set { formato = value; }
        }
        public double Tamanho
        {
            get { return tamanho; }
            set { tamanho = value; }
        }
        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        public Lapis(string _dureza, string _marca, string _material, string _cor, string _formato, double _tamanho, double _peso)
        {
            Dureza = _dureza;
            Apontado = true;
            PercentualGrafite = 100;
            Marca = _marca;
            Material = _material;
            Cor = _cor;
            Formato = _formato;
            Tamanho = _tamanho;
            Peso = _peso;
        }

        public void Derrubar()
        {
            Caido = true;
        }
        public void PegarDoChao()
        {
            Caido = false;
        }
        public void QuebrarPonta()
        {
            if (PercentualGrafite < 15)
            {
                Console.WriteLine("Compre outro lápis.");
                return;
            }
            apontado = false;
            GastarGrafite(15);
        }
        public void Apontar()
        {
            if (PercentualGrafite < 5)
            {
                Console.WriteLine("Compre outro lápis.");
                return;
            }
            apontado = true;
            GastarGrafite(5);
        }
        private void GastarGrafite(int _percentual)
        {
            PercentualGrafite -= _percentual;
            if (PercentualGrafite < 0)
                PercentualGrafite = 0;
        }
        public void Escrever(string _texto)
        {
            if (PercentualGrafite < 10)
            {
                Console.WriteLine("Compre outro lápis.");
                return;
            }
            if (!Apontado)
            {
                Console.WriteLine("Aponte o lápis.");
                return;
            }
            if (Caido == true)
            {
                Console.WriteLine("Pegue o lápis do chão primeiro");
                return;
            }
            Console.WriteLine(_texto);
            GastarGrafite(10);
        }
    }
}
