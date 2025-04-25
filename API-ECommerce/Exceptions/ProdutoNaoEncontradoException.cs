namespace API_ECommerce.Exceptions
{
    public class ProdutoNaoEncontradoException : Exception
    {
        public ProdutoNaoEncontradoException(int idProduto)
            : base($"Produto com ID {idProduto} não encontrado")
        {
        }
    }

}
