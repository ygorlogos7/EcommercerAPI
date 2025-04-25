using API_ECommerce.Models;

namespace API_ECommerce.DTO
{
    public class CadastrarPagamentosDTO
    {
        public string FormaPagamento { get; set; } = null!;

        public string Status { get; set; } = null!;

        public DateTime Data { get; set; }

        public virtual Pedido? Pedido { get; set; }
    }
}
