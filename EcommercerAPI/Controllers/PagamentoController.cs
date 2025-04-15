using EcommercerAPI.Context;
using EcommercerAPI.Interfaces;
using EcommercerAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommercerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagamentoController : ControllerBase
    {
        private readonly IPagamentoRepository _pagamentoRepository;
        private readonly EcommerceContext _context;

        // Construtor
        public PagamentoController(IPagamentoRepository pagamentoRepository)
        {

            _pagamentoRepository = pagamentoRepository;

        }

        // GET: api/<PagamentoController>
        [HttpGet]
        public IActionResult ListarPagamentos()
        {
            return Ok(_pagamentoRepository.ListarTodos());
        }
    }
}
