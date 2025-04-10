using EcommercerAPI.Models;

namespace EcommercerAPI.Interfaces
{
    // Contrato para a implementação do repositório de produtos
    public interface IProdutoRepository
    {
        // R - Read(Leitura) -RETORNO
        List<Produto> ListarTodos();
        // Recebe um identificador e retorna um produto correspondente
        Produto BuscarPorID(int id);

        // C - Create(Criar) - INSERÇÃO
        void Cadastrar(Produto produto);

        // U - Update(Atualizar) - ATUALIZAÇÃO
        void Atualizar(int id, Produto produto);

        // D - Delete(Deletar) - REMOÇÃO
        void Deletar(int id);



    }
}
