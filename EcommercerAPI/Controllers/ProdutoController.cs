using EcommercerAPI.Context;
using EcommercerAPI.Interfaces;
using EcommercerAPI.Models;
using EcommercerAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommercerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private IProdutoRepository _produtoRepository;

        // Injeçao de dependencia
        public ProdutoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;

        }

        // GET: api/<ProdutoController>
        [HttpGet]
        public IActionResult ListarProdutos()
        {
            return Ok(_produtoRepository.ListarTodos());
        }

        [HttpPost]
        public IActionResult CadastrarProduto(Produto prod)
        {
            // 1 - Coloco o Produto no Banco de Dados
            _produtoRepository.Cadastrar(prod);

            // 2 - Retorno o resultado
            // 201 - Created
            return Created();
        }

        // Buscar por ID
        [HttpGet("{id}")]
        public IActionResult BuscarProdutoPorID(int id)
        {
            // 1 - Busco o produto no banco de dados
            Produto produtoEncontrado = _produtoRepository.BuscarPorID(id);
            // 2 - Verifico se o produto foi encontrado
            if (produtoEncontrado == null)
            {
                // 404 - Not Found
                return NotFound("Produto não encontrado");
            }
            // 3 - Retorno o resultado
            return Ok(produtoEncontrado);
        }

        // Atualizar Produto
        [HttpPut("{id}")]
        public IActionResult AtualizarProduto(int id, Produto produto)
        {
            try
            {
                // 1 - Atualizo o produto no banco de dados
                _produtoRepository.Atualizar(id, produto);
                // 2 - Retorno o resultado
                // 204 - No Content
                return NoContent();
            }
            catch (Exception ex)
            {
                // 404 - Not Found
                return NotFound("Produto não encontrado");
            }
        }

        // Deletar Produto
        [HttpDelete("{id}")]
        public IActionResult DeletarProduto(int id)
        {
            try
            {
             _produtoRepository.Deletar(id);

                // 204 - No Content
                return NoContent();
            }
            catch (Exception ex)
            {
                // 404 - Not Found
                return NotFound("Produto não encontrado");

            }
        }

    } 
}

