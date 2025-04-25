using API_ECommerce.Models;
using System.Text.Json.Serialization;

namespace API_ECommerce.DTO
{
    // Receber os dados do cliente para cadastrar um pedido
    // Recebo produtos comprados
    public class CadastrarPedidoDTO
    {
        public DateOnly DataPedido { get; set; }

        public string Status { get; set; } = null!;

        public decimal? ValorTotal { get; set; }

        public int IdCliente { get; set; }

        // Produtos Comprados

        public List<int> Produtos { get; set; }
    }
}
