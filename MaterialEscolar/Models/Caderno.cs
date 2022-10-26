namespace Models
{
    internal class Caderno
    {
        private string marca;
        private int quantidadeFolha;
        private int quantidadeMateria;
        public string Marca 
        { 
            get { return marca; }
            set { marca = value; }
        }
        public int QuantidadeFolha
        {
            get { return quantidadeFolha; }
            set { quantidadeFolha = value; }
        }
        public int QuantidadeMateria
        {
            get { return quantidadeMateria; }
            set { quantidadeMateria = value; }
        }

        public Caderno(string _marca, int _quantidadeFolha, int _quantidadMateria)
        {
            Marca = _marca;
            QuantidadeFolha = _quantidadeFolha;
            QuantidadeMateria = _quantidadMateria;
        }


    }
}
