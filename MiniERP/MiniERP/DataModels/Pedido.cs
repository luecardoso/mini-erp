using System;
using System.Collections.Generic;

namespace MiniERP.DataModels;

public partial class Pedido
{
    public int Id { get; set; }

    public decimal? Total { get; set; }

    public DateTime? DataCompra { get; set; }

    public int FkCliente { get; set; }

    public virtual Cliente FkClienteNavigation { get; set; } = null!;

    public virtual ICollection<Itempedido> Itempedidos { get; set; } = new List<Itempedido>();
}
