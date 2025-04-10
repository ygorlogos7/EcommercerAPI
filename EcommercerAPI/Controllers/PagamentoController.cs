using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommercerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagamentoController : ControllerBase
    {


        // GET: api/<PagamentoController>
        [HttpGet]
        public IActionResult ListarPagamentos()
        {
            return Ok();
        }
    }
}
