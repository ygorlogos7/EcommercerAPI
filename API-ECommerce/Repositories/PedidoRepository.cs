using API_ECommerce.Context;
using API_ECommerce.DTO;
using API_ECommerce.Interfaces;
using API_ECommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace API_ECommerce.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly EcommerceContext _context;

        // Injeção de Dependência - Construtor
        public PedidoRepository(EcommerceContext context)
        {
            _context = context;
        }
        public void Atualizar(int id, Pedido pedido)
        {
            throw new NotImplementedException();
        }
        public Pedido BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }
        public void Cadastrar(CadastrarPedidoDTO pedidoDTO)
        {
            // Cadastrar o pedido no banco de dados
            // Criar um novo objeto Pedido e atribuir os valores do DTO - variavel
            var Pedido = new Pedido
            {
                DataPedido = pedidoDTO.DataPedido,
                ValorTotal = pedidoDTO.ValorTotal,
                Status = pedidoDTO.Status,
                IdCliente = pedidoDTO.IdCliente
            };
            // Adicionar o pedido à lista de pedidos
            _context.Pedidos.Add(Pedido);
            // Salvar as alterações no banco de dados
            _context.SaveChanges();

            // Cadastrar os ItensPedidos
            // Para cada PRODUTO, eu crio um Item Pedido

            for (int i = 0; i < pedidoDTO.Produtos.Count; i++)
            {
                // Buscar o produto no banco de dados
                var produto = _context.Produtos.Find(pedidoDTO.Produtos[i]);

                // TODO: lancar erro se produto nao existe

                // variavel itemPedido
                var itemPedido = new ItemPedido
                {
                    IdProduto = produto.IdProduto,
                    IdPedido = Pedido.IdPedido,
                    Quantidade = 0
                };
                // Adicionar o item à lista de itens do pedido
                _context.ItemPedidos.Add(itemPedido);
                // Salvar as alterações no banco de dados
                _context.SaveChanges();
            }
        }
        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }
        public List<Pedido> ListarTodos()
        {
            return _context.Pedidos
                   .Include(p => p.ItemPedidos)
                   .ThenInclude(i => i.IdProdutoNavigation) // Carrega os produtos relacionados
                   .ToList();
        }
       
    }


}

