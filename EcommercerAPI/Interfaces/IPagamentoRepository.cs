namespace EcommercerAPI.Interfaces
{
    public interface IPagamentoRepository
    {
        // R - Read(Leitura) -RETORNO
        List<Models.Pagamento> ListarTodos();
        // Recebe um identificador e retorna um produto correspondente
        Models.Pagamento BuscarPorID(int id);
        // C - Create(Criar) - INSERÇÃO
        void Cadastrar(Models.Pagamento pagamento);
        // U - Update(Atualizar) - ATUALIZAÇÃO
        void Atualizar(int id, Models.Pagamento pagamento);
        // D - Delete(Deletar) - REMOÇÃO
        void Deletar(int id);
    }
}
