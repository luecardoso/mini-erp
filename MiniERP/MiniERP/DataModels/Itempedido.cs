using System;
using System.Collections.Generic;

namespace MiniERP.DataModels;

public partial class Itempedido
{
    public int Id { get; set; }

    public int? QuantidadeComprada { get; set; }

    public decimal? ValorUnitario { get; set; }

    public decimal? ValorTotal { get; set; }

    public int FkProduto { get; set; }

    public int FkPedido { get; set; }

    public virtual Pedido FkPedidoNavigation { get; set; } = null!;

    public virtual Produto FkProdutoNavigation { get; set; } = null!;
}
