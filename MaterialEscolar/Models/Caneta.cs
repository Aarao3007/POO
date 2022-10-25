namespace Models
{
    public class Caneta
    {
        private string cor;
        private string marca;
        private int percentualCarga;
        private string material;
        private bool estourada;
        private bool caida;
        private bool tampada;
        private double ponta;
        private string tipoPonta;
        private double tamanho;
        private double peso;


        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public int PercentualCarga
        {
            get { return percentualCarga; }
            set { percentualCarga = value; }
        }
        public string Material
        {
            get { return material; }
            set { material = value; }
        }
        public bool Estourada
        {
            get { return estourada; }
            set { estourada = value; }
        }
        public bool Caida
        {
            get { return caida; }
            set { caida = value; }
        }
        public bool Tampada
        {
            get { return tampada; }
            set { tampada = value; }
        }
        public double Ponta
        {
            get { return ponta; }
            set { ponta = value; }
        }
        public string TipoPonta
        {
            get { return tipoPonta; }
            set { tipoPonta = value; }
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

        public void Tampar()
        {
            Tampada = true;
        }
        public void Destampar()
        {
            Tampada = false;
        }
        public void Derrubar()
        {
            Caida = true;
        }
        public void PegarDoChao()
        {
            Caida = false;
        }
        public void Estourar()
        {
            Estourada = true;
        }
        public void Escrever(string _texto)
        {
            if (Tampada == true)
            {
                Console.WriteLine("Destampe a caneta para escrever!");
                return;
            }
            if(Estourada == true)
            {
                Console.WriteLine("A caneta está estourada!");
                return;
            }
            if(Caida == true)
            {
                Console.WriteLine("Pegue a caneta do chão primeiro");
                return;
            }
            Console.WriteLine(_texto);
            PercentualCarga -= 10;
        }
        public Caneta(string _cor, string _marca, string _material, double _ponta, string _tipoPonta, double _tamanho, double _peso)
        {
            Cor = _cor;
            Tamanho = _tamanho;
            Peso = _peso;
            Marca = _marca;
            Material = _material;
            Ponta = _ponta;
            TipoPonta = _tipoPonta;
            PercentualCarga = 100;
            Tampar();

        }
    }
}