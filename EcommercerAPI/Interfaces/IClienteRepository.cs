using EcommercerAPI.Models;

namespace EcommercerAPI.Interfaces
{
    public interface IClienteRepository
    {
        List<Cliente> ListarTodos();
        Cliente BuscarPorID(int id);
        
        Cliente BuscarPorEmailSenha(string email, string senha);    
        void Cadastrar(Cliente cliente);
        void Atualizar(int id, Cliente cliente);
        void Deletar(int id);
    }
}
