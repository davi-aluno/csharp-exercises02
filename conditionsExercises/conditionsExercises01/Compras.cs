namespace conditionsExercises01
{
    class Compras
    {
        private string nomeDoProduto;
        private string preco;

        public Compras(string nomeDoProduto, string preco)
        {
            this.nomeDoProduto = nomeDoProduto;
            this.preco = preco;
        }

        public string Name
        {
            get => nomeDoProduto;
        }
        public string Preco
        {
            get => preco;
        }
    }
}
