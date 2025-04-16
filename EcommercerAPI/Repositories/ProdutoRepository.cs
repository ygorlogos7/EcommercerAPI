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
            Produto produtoEncontrado = _context.Produtos.Find(id); // Busca o produto pelo id

            if (produtoEncontrado == null) // condicao sendo null, me retorne um erro
            {
                throw new Exception("Produto não encontrado");
            }

            produtoEncontrado.Nome = produto.Nome;
            produtoEncontrado.Descricao = produto.Descricao;
            produtoEncontrado.Preco = produto.Preco;
            produtoEncontrado.Imagem = produto.Imagem;
            produtoEncontrado.EstoqueDisponivel = produto.EstoqueDisponivel;
            produtoEncontrado.Categoria = produto.Categoria;

            _context.SaveChanges(); // Salvo a Alteracao
        }

        private void Ok(Produto produtoEncontrado)
        {
            throw new NotImplementedException();
        }        

        public Produto BuscarPorID(int id)
        {
            // FirstOrDefault retorna o primeiro elemento que satisfaz a condição ou null se nenhum elemento for encontrado
            return _context.Produtos.FirstOrDefault(produto => produto.IdProduto == id); 
           
           // Para cada P, me retorne o IdProduto que seja igual ao id
        }

        public void Cadastrar(Produto produto)
        {
            _context.Produtos.Add(produto); // Adiciona o produto no contexto
                              
            _context.SaveChanges();  //  Salvo a Alteracao

        }

        public void Deletar(int id)
        {
            
            Produto produtoBuscado = _context.Produtos.Find(id); // Busca o produto pelo id

            if (produtoBuscado == null) // condicao sendo null, me retorne um erro
            {
                throw new Exception("Produto não encontrado");
            }

            _context.Produtos.Remove(produtoBuscado); // Remove o produto do contexto

            _context.SaveChanges(); // Salvo a Alteracao


        }

        public List<Produto> ListarTodos()
        {
            return _context.Produtos.ToList(); // Retorna a lista de produtos   
        }
    }
}
