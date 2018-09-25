
namespace mini_projeto
{
    class ItemPedido
    {
        private int quantidade;
        private double desconto;
        private Produto p;
        public ItemPedido(int quantidade, double desconto, Produto p)
        {
            this.quantidade = quantidade;
            this.desconto = desconto;
            this.p = p;
        }
 
    }
}
