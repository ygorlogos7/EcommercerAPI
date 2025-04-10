namespace EcommercerAPI.Interfaces
{
    public interface IClienteRepository
    {
        List<Models.Cliente> ListarTodos();
        Models.Cliente BuscarPorID(int id);
        
        Models.Cliente BuscarPorEmailSenha(string email, string senha);    
        void Cadastrar(Models.Cliente cliente);
        void Atualizar(int id, Models.Cliente cliente);
        void Deletar(int id);
    }
}
