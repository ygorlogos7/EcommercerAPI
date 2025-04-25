using API_ECommerce.DTO;
using API_ECommerce.Models;

namespace API_ECommerce.Interfaces
{
    public interface IPagamentoRepository
    {
        List<Pagamento> ListarTodos();
        Pagamento BuscarPorId(int id);
        void Cadastrar(CadastrarPagamentosDTO pagamento);
        void Atualizar(int id, Pagamento pagamento);
        void Deletar(int id);

        List<Pagamento> ListarPagamentosConcluidos(string nome);
    }
}
