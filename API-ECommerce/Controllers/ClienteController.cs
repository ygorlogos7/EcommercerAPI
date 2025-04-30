using API_ECommerce.Context;
using API_ECommerce.DTO;
using API_ECommerce.Interfaces;
using API_ECommerce.Repositories;
using API_ECommerce.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_ECommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly EcommerceContext _context;
        private   IClienteRepository _clienteRepository;

        private PasswordService passwordService = new PasswordService();

        public ClienteController(EcommerceContext context)
        {
            _context = context;
            _clienteRepository = new ClienteRepository(_context);
            
        }

        [HttpGet]
        
        public IActionResult ListarTodos()
        {
            return Ok(_clienteRepository.ListarTodos());
        }

        [HttpPost]

        public IActionResult CadastrarCliente(CadastrarClienteDTO cliente)
        {
   
            _clienteRepository.Cadastrar(cliente);
            return Created();
        }

        [HttpGet("/buscar/{nome}")]
        public IActionResult ListarPorNome(string nome)
        {
            return Ok(_clienteRepository.ListarPorNome(nome));
        }

        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            var cliente = _clienteRepository.BuscarPorId(id);
            if (cliente == null)
            {
                return NotFound();
            }
            return Ok(cliente);
        }


        
        [HttpPost("login")]
        public IActionResult Login(LoginDTO login)
        {
            var cliente = _clienteRepository.BuscarPorEmailSenha( login.Email, login.Senha);

            if (cliente == null)
            {
                return Unauthorized("Email ou Senha invalidados!");
            }

             var tokenService = new TokenService();

            var token = tokenService.GenerateToken(cliente.Email);

            return Ok(token);
        }
    }
}
