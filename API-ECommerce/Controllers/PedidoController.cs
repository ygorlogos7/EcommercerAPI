using API_ECommerce.DTO;
using API_ECommerce.Interfaces;
using API_ECommerce.Models;
using API_ECommerce.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace API_ECommerce.Controllers
{
    public class PedidoController : ControllerBase
    {
        private IPedidoRepository _pedidoRepository;
        // Injeção de Dependência
        // Ao invés de EU instanciar a classe
        // Eu aviso que DEPENDO dela
        // E a responsibilidade de criar vem pra classe que chama (C#)
        public PedidoController(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }
        // GET
        [HttpGet]
        public IActionResult ListarPedidos()
        {
            return Ok(_pedidoRepository.ListarTodos());
        }
        // Cadastrar Pedido
        [HttpPost]
        public IActionResult CadastrarPedido(CadastrarPedidoDTO pedido)
        {
            // 1 - Coloco o Pedido no Banco de Dados
            _pedidoRepository.Cadastrar(pedido);
            // 2 - Retorno o resultado
            // 201 - Created
            return Created();
        }
        // Buscar Pedido por Id
        // /api/pedidos
        // /api/pedidos/1
        [HttpGet("{id}")]
        public IActionResult ListarPorId(int id)
        {
            Pedido pedido = _pedidoRepository.BuscarPorId(id);
            if (pedido == null)
            {
                // 404 - Nao Encontrado
                return NotFound();
            }
            return Ok(pedido);
        }
        // Atualizar Pedido
        [HttpPut("{id}")]
        public IActionResult AtualizarPedido(int id, Pedido pedido)
        {
            // 1 - Coloco o Pedido no Banco de Dados
            _pedidoRepository.Atualizar(id, pedido);
            // 2 - Retorno o resultado
            // 204 - No Content
            return NoContent();
        }
        // Deletar Pedido
        [HttpDelete("{id}")]
        public IActionResult DeletarPedido(int id)
        {
            try
            {
                _pedidoRepository.Deletar(id);

                // 204 - Deu certo!
                return NoContent();
            }
            // Caso de erro
            catch (Exception ex)
            {
                return NotFound("Pedido não encontrado!");
            }
           
        }

    }
}
    