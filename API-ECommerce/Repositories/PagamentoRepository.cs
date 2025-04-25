using API_ECommerce.Context;
using API_ECommerce.DTO;
using API_ECommerce.Interfaces;
using API_ECommerce.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace API_ECommerce.Repositories
{
    public class PagamentoRepository : IPagamentoRepository
    {
        private readonly EcommerceContext _context;

        public PagamentoRepository(EcommerceContext context)
        {
            _context = context;
        }

        public void Atualizar(int id, Pagamento pagamento)
        {
            throw new NotImplementedException();
        }

        public Pagamento BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Pagamento pagamento)
        {
            _context.Pagamentos.Add(pagamento);
        }

        public void Cadastrar(CadastrarPagamentosDTO pagamento)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Pagamento> ListarPagamentosConcluidos(string nome)
        {
            var pagamentos = _context.Pagamentos
                .Where(p => p.FormaPagamento ==  nome)
                .ToList();
            return pagamentos;

        }

        public List<Pagamento> ListarTodos()
        {
            return _context.Pagamentos
                .Include(p => p.Pedido)
                .ToList();
        }
    }
}
