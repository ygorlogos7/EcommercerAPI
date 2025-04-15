using EcommercerAPI.Models;

namespace EcommercerAPI.Interfaces
{
    public interface ItemdoPedidoRepository
    {
        // R - Read(Leitura) -RETORNO
        List<ItemPedido> ListarTodos();
        // Recebe um identificador e retorna um produto correspondente
        ItemPedido BuscarPorID(int id);
        // C - Create(Criar) - INSERÇÃO
        void Cadastrar(ItemPedido itemdoPedido);
        // U - Update(Atualizar) - ATUALIZAÇÃO
        void Atualizar(int id, ItemPedido itemdoPedido);
        // D - Delete(Deletar) - REMOÇÃO
        void Deletar(int id);
    }
}
