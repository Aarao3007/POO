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
        public Apontador(string _marca, string cor, double _comprimento,)
        {
            Marca = _marca;
            QuantidadeFolha = _quantidadeFolha;
            QuantidadeMateria = _quantidadMateria;
        }

    }
}
