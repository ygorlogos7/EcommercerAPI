using EcommercerAPI.Context;
using EcommercerAPI.Interfaces;
using EcommercerAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommercerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoRepository _pedidoRepository;
        private readonly EcommerceContext _context;

        // Construtor
        public PedidoController(IPedidoRepository pedidoRepository )
        {
            
            _pedidoRepository = pedidoRepository;
        
        }

        // GET: api/<PedidoController>
        [HttpGet]
        public IActionResult ListarPedidos()
        {
            return Ok(_pedidoRepository.ListarTodos());
        }
    }
}
