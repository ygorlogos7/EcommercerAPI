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
    }
}

