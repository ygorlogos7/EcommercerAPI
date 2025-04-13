using EcommercerAPI.Context;
using EcommercerAPI.Models;

namespace EcommercerAPI.Repositories
{
    public class PedidoRepository : Interfaces.IPedidoRepository
    {
        private EcommerceContext context;

        public PedidoRepository(EcommerceContext context)
        {
            this.context = context;
        }

        public void Atualizar(int id, Pedido pedido)
        {
            throw new NotImplementedException();
        }

        public Pedido BuscarPorID(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Pedido pedido)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Pedido> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
