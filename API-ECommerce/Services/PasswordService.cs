using API_ECommerce.DTO;
using API_ECommerce.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using PasswordVerificationResult = Microsoft.AspNetCore.Identity.PasswordVerificationResult;

namespace API_ECommerce.Services
{
    public class PasswordService
    {
        // outro metodo -> private readonly PasswordHasher<Cliente> _hasher = new();/ new PasswordHasher<Cliente>();

        private readonly PasswordHasher<Cliente> _hasher = new();

        // 1 - Gerar o Hash
        public string HashPassword(Cliente cliente)
        {
            return  _hasher.HashPassword(cliente, cliente.Senha);
        }

        // 2 - Verificar o Hash
        public bool VerifyPassword(Cliente cliente, string senhainfo)
        {
            var result = _hasher.VerifyHashedPassword(cliente, cliente.Senha, senhainfo);

            return result == PasswordVerificationResult.Success;

            // outro metodo com if else ->
            /*if (result == PasswordVerificationResult.SuccessRehashNeeded)
            {
                return true;
            }
            else
            {
                return false;
            }*/
            // Se o resultado for igual a Success, a senha está correta


        }

    }
}
