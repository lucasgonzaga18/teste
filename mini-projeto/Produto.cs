namespace mini_projeto
{
    class Produto
    {
        private int codigo;
        private string descricao;
        private double preco;

        public Produto(int codigo, string descricao, double preco)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.preco = preco;

        }
        public void setCodigo(int codigo)
        {
            this.codigo = codigo;
        }

        public void setPreco(double preco)
        {
            this.preco = preco;
        }

        public void setDescricao(string descricao)
        {
            this.descricao = descricao;
        }

        public int getCodigo()
        {
            return codigo;
        }
        public double getPreco()
        {
            return preco;
        }
        public string getDesc()
        {
            return descricao;
        }

    }
}
