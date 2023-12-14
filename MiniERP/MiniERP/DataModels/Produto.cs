using System;
using System.Collections.Generic;

namespace MiniERP.DataModels;

public partial class Produto
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public int Quantidade { get; set; }

    public string? Descricao { get; set; }

    public decimal Preco { get; set; }

    public int FkFornecedor { get; set; }

    public virtual Fornecedor FkFornecedorNavigation { get; set; } = null!;

    public virtual ICollection<Itempedido> Itempedidos { get; set; } = new List<Itempedido>();
}
