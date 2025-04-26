using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API_ECommerce.Models;

public partial class ItemPedido
{

    public int IdItemPedido { get; set; }

    public int IdPedido { get; set; }

    public int IdProduto { get; set; }

    public int Quantidade { get; set; }

    [JsonIgnore]
    public Pedido Pedido { get; set; } = null!;

    public Produto Produto { get; set; } = null!;

    public virtual ICollection<ItemPedido> Pedidos { get; set; } = new List<ItemPedido>();
}


