using API_ECommerce.DTO;
using API_ECommerce.Models;

namespace API_ECommerce.Interfaces
{
    public interface IItemPedidoRepository
    {
        List<ItemPedido> ListarTodos();
        ItemPedido BuscarPorId(int id);
        void Cadastrar(CadastrarItemPedidoDTO itemPedido);
        void Atualizar(int id, ItemPedido itemPedido);
        void Deletar(int id);
    }
}
