using EcommercerAPI.Context;
using EcommercerAPI.Interfaces;
using EcommercerAPI.Models;

namespace EcommercerAPI.Repositories
{
    public class PagamentoRepository : Interfaces.IPagamentoRepository
    {
        private EcommerceContext context;

        public PagamentoRepository(EcommerceContext context)
        {
            this.context = context;
        }

        public void Atualizar(int id, Pagamento pagamento)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Pagamento pagamento)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        Pagamento IPagamentoRepository.BuscarPorID(int id)
        {
            throw new NotImplementedException();
        }

        List<Pagamento> IPagamentoRepository.ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
