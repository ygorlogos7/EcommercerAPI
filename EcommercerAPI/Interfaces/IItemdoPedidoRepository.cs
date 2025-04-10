namespace EcommercerAPI.Interfaces
{
    public interface IItemdoPedidoRepository
    {
        // R - Read(Leitura) -RETORNO
        List<Models.ItemPedido> ListarTodos();
        // Recebe um identificador e retorna um produto correspondente
        Models.ItemPedido BuscarPorID(int id);
        // C - Create(Criar) - INSERÇÃO
        void Cadastrar(Models.ItemPedido itemdoPedido);
        // U - Update(Atualizar) - ATUALIZAÇÃO
        void Atualizar(int id, Models.ItemPedido itemdoPedido);
        // D - Delete(Deletar) - REMOÇÃO
        void Deletar(int id);
    }
}
