﻿namespace API_ECommerce.DTO
{
    public class CadastrarClienteDTO
    {
        public string NomeCompleto { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string? Telefone { get; set; }

        public string? Endereco { get; set; }

        public string Senha { get; set; } = null!;
    }
}
