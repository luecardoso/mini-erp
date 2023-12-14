using System;
using System.Collections.Generic;

namespace MiniERP.DataModels;

public partial class Cliente
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public string? DataNascimento { get; set; }

    public string? Telefone { get; set; }

    public string? Sexo { get; set; }

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
