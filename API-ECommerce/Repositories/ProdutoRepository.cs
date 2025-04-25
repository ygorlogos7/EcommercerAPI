using API_ECommerce.Context;
using API_ECommerce.DTO;
using API_ECommerce.Exceptions;
using API_ECommerce.Interfaces;
using API_ECommerce.Models;

namespace API_ECommerce.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        // Métodos que acessam o Banco de Dados

        // Injetar o Context
        // Injeção de Dependência
        private readonly EcommerceContext _context;

        // Metodo Construtor
        // Quando criar um objeto o que eu preciso ter?
        public ProdutoRepository(EcommerceContext context)
        {
            _context = context;
        }

        public void Atualizar(int id, Produto produto)
        {
            // Encontro o produto que desejo
            Produto produtoEncontrado = _context.Produtos.Find(id);

            // Caso nao encontre o produto, lanco um erro
            if (produtoEncontrado == null)
            {
                throw new Exception();
            }

            produtoEncontrado.Nome = produto.Nome;
            produtoEncontrado.Descricao = produto.Descricao;
            produtoEncontrado.Preco = produto.Preco;
            produtoEncontrado.Categoria = produto.Categoria;
            produtoEncontrado.Imagem = produto.Imagem;
            produtoEncontrado.EstoqueDisponivel = produto.EstoqueDisponivel;

            _context.SaveChanges();
        }

        public Produto BuscarPorId(int id)
        {
            // ToList() - Pegar Varios
            // FirstorDefault - Traz o Primeiro que Encontrar, ou null

            // Expressao Lambda
            // _context.Produtos - Acesse a tabela Produtos do Contexto
            // FirstOrDefault - Pegue o primeiro que encontrar
            // p => p.IdProduto == id
            // Para cada produto P, me retorne aquele que tem o IdProduto igual ao id
            return _context.Produtos.FirstOrDefault(produto => produto.IdProduto == id);
        }

        // DTO - Data Transfer Object - Objeto de Transferencia de Dados
        // DTO - Objeto que vai ser enviado para o Frontend
        public void Cadastrar(CadastrarProdutoDTO produtodto)
        {
            Produto produtoCadastro = new Produto
            {
                Nome = produtodto.Nome,
                Descricao = produtodto.Descricao,
                Preco = produtodto.Preco,
                Categoria = produtodto.Categoria,
                Imagem = produtodto.Imagem,
                EstoqueDisponivel = produtodto.EstoqueDisponivel
            };

            _context.Produtos.Add(produtoCadastro);

            _context.SaveChanges();
        }

        public void Deletar(int id)
        {
            // 1 - Encontrar o que eu quero Excluir
            // Find - Procura pela chave primaria
            Produto produtoEncontrado = _context.Produtos.Find(id);

            // Caso nao encontre o produto, lanco um erro
            if(produtoEncontrado == null)
            {
                throw new ProdutoNaoEncontradoException(id);
            }

            // Caso eu encontre o produto, removo ele
            _context.Produtos.Remove(produtoEncontrado);

            // Salvo as alteracoes
            _context.SaveChanges();
        }


        public List<Produto> ListarProdutoMaisBarato(string nome)
        {
            var ListaProdutos = _context.Produtos
                .OrderByDescending(p => p.Preco)
                .ToList();
            // .Where(c => c.NomeCompleto.Contains(nome)) - Para pesquisar por parte do nome
            return ListaProdutos;
        }

        public List<Produto> ListarTodos()
        {
            return _context.Produtos.ToList();
        }
    }
}
