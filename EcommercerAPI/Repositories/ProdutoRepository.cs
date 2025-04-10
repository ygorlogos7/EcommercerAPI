using EcommercerAPI.Context;
using EcommercerAPI.Models;

namespace EcommercerAPI.Repositories
{
    public class ProdutoRepository : Interfaces.IProdutoRepository
    {


        // Metodos  que acessa o banco de dados

        // Injetar o Context

        private readonly EcommerceContext _context;

        // Construtor
        public ProdutoRepository(EcommerceContext context)
        {
            _context = context; 
        }
        public void Atualizar(int id, Produto produto)
        {
            throw new NotImplementedException();
        }

        public Produto BuscarPorID(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Produto produto)
        {
            _context.Produtos.Add(produto); // Adiciona o produto no contexto

        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Produto> ListarTodos()
        {
            return _context.Produtos.ToList(); // Retorna a lista de produtos   
        }
    }
}
