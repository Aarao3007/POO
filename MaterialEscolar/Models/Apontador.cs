namespace Models
{
    public class Apontador
    {
        private string marca;
        private string cor;
        private double comprimento;
        private double largura;
        private double altura;
        private double peso;
        private bool caido;
        private bool deposito;
        private bool cheio;
        private int percentualDaLamina;

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
        public bool Caido
        {
            get { return caido; }
            set { caido = value; }
        }
        public bool Deposito
        {
            get { return deposito; }
            set { deposito = value; }
        }
        public bool Cheio
        {
            get { return cheio; }
            set { cheio = value; }
        }
        public int PercentualDaLamina
        {
            get { return percentualDaLamina; }
            set { percentualDaLamina = value; }
        }
        public void Derrubar()
        {
            caido = true;
        }
        public void PegarDoChao()
        {
            caido = false;
        }
        public void Esvaziar()
        {
            cheio = false;
        }
        public void Apontar()
        {
            if(PercentualDaLamina <= 3)
            {
                Console.WriteLine("Compre outro apontador!");
            }
            PercentualDaLamina -= 1;
            if (Deposito == true)
            {
                Cheio = true;
            }
        }
        public Apontador(string _marca, string _cor, double _comprimento, double _largura, double _altura, double _peso, bool _deposito)
        {
            Marca = _marca;
            Cor = _cor;
            Comprimento = _comprimento;
            Largura = _largura;
            Altura = _altura;
            Peso = _peso;
            Deposito = _deposito;
            Caido = false;
            Cheio = false;
            PercentualDaLamina = 100;
        }

    }
}
