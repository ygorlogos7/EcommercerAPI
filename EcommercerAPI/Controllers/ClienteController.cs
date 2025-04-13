using EcommercerAPI.Context;
using EcommercerAPI.Interfaces;
using EcommercerAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommercerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {

        private readonly ClienteController _clienteController;
        private readonly EcommerceContext _context;

        // Construtor
        public ClienteController(EcommerceContext context)
        {
            _context = context;
            _clienteController = new ClienteController(_context);

        }

        // GET: 
        [HttpGet]
        public IActionResult ListarCliente()
        {
            return Ok(_clienteController.ListarCliente());
        }
    }
}
