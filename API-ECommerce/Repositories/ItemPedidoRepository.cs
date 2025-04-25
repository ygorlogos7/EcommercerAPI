using API_ECommerce.Context;
using API_ECommerce.DTO;
using API_ECommerce.Interfaces;
using API_ECommerce.Models;

namespace API_ECommerce.Repositories
{
    public class ItemPedidoRepository : IItemPedidoRepository
    {
        private readonly EcommerceContext _context;
        public ItemPedidoRepository(EcommerceContext context)
        {
            _context = context;
        }

        public void Atualizar(int id, ItemPedido itemPedido)
        {
            throw new NotImplementedException();
        }

        public ItemPedido BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(CadastrarItemPedidoDTO itemPedido)
        {
            // Verifica se o produto existe no banco de dados
            var item = new ItemPedido
            {
                IdProduto = itemPedido.IdProduto,
                IdPedido = itemPedido.IdPedido,
                Quantidade = itemPedido.Quantidade,
            };
            // Adiciona o itemPedido na tabela ItemPedido
            _context.Add(itemPedido);
            // Salva as alterações no banco de dados
            _context.SaveChanges();

        }


        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<ItemPedido> ListarTodos()
        {
            return _context.ItemPedidos.ToList();
        }
    }
}
