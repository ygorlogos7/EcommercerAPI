using EcommercerAPI.Context;
using EcommercerAPI.Interfaces;
using EcommercerAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommercerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemdoPedidoController : ControllerBase
    {

        private readonly ItemdoPedidoController _itemdoPedidoController;
        private readonly EcommerceContext _context;

        // Construtor
        public ItemdoPedidoController(EcommerceContext context)
        {
            _context = context;
            _itemdoPedidoController = new ItemdoPedidoController(_context);

        }

        // GET: 
        [HttpGet]
        public IActionResult ListaItemdoPedido()
        {
            return Ok(_itemdoPedidoController.ListaItemdoPedido());
        }
    }
}
