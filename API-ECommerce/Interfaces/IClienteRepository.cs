using API_ECommerce.DTO;
using API_ECommerce.Models;
using API_ECommerce.ViewModels;

namespace API_ECommerce.Interfaces
{
    public interface IClienteRepository
    {
        List<ListarClientesViewModel> ListarTodos();
        Cliente BuscarPorId(int id);
        Cliente? BuscarPorEmailSenha(string email, string senha);
        void Atualizar(int id, Cliente cliente);
        void Deletar(int id);
        List<Cliente> ListarPorNome(string nome);
        void Cadastrar(CadastrarClienteDTO cliente);
    }
}
