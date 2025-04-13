using EcommercerAPI.Models;

namespace EcommercerAPI.Interfaces
{
    public interface IPedidoRepository
    {
        List<Pedido> ListarTodos();
        Pedido BuscarPorID(int id);
        void Cadastrar(Pedido pedido);
        void Atualizar(int id,Pedido pedido);
        void Deletar(int id);
    }
}
