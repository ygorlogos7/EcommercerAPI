using EcommercerAPI.Models;

namespace EcommercerAPI.Interfaces
{
    public interface IPagamentoRepository
    {
        // R - Read(Leitura) -RETORNO
        List<Pagamento> ListarTodos();
        // Recebe um identificador e retorna um produto correspondente
        Pagamento BuscarPorID(int id);
        // C - Create(Criar) - INSERÇÃO
        void Cadastrar(Pagamento pagamento);
        // U - Update(Atualizar) - ATUALIZAÇÃO
        void Atualizar(int id,Pagamento pagamento);
        // D - Delete(Deletar) - REMOÇÃO
        void Deletar(int id);
    }
}
