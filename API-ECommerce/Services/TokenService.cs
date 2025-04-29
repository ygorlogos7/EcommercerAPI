using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;

namespace API_ECommerce.Services
{
    public class TokenService
    {
        // Claims são informações que você pode adicionar ao token
        public string GenerateToken(string email)
        {
            var claims = new[]
            {
                new Claim(ClaimTypes.Email, email)
            };
            
        // Criar uma chave de seguranca e criptografar o token
            var chave = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("chave-secreta-original"));
        }
    }
}

        
