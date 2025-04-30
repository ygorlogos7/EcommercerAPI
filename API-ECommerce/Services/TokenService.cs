using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
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
            var chave = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("chave-secreta-original-para-seguranca-da-aplicacao"));

            // criptografando a chave
            // signingCredentials -> credenciais de assinatura 
            // SecurityAlgorithms.HmacSha256 -> algoritmo de hash
            var creds = new SigningCredentials(chave, SecurityAlgorithms.HmacSha256);

            // criar o token
            var token = new JwtSecurityToken(
                issuer: "API_ECommerce",
                audience: "API_ECommerce",
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: creds
            );

            // jwtSecurityTokenHandler -> classe que manipula o token; escreve o token
            // WriteToken -> escreve o token
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}

        
