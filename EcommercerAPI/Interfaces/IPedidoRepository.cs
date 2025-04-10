namespace EcommercerAPI.Interfaces
{
    public interface IPedidoRepository
    {
        List<Models.Pedido> ListarTodos();
        Models.Pedido BuscarPorID(int id);
        void Cadastrar(Models.Pedido pedido);
        void Atualizar(int id, Models.Pedido pedido);
        void Deletar(int id);
    }
}
